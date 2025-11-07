using System;

namespace Business.Core.Dependency
{
    public static class ServiceProvider
    {
        public static readonly Dictionary<Type, Type> _services = new Dictionary<Type, Type>();

        public static void Register<TInterface, TImplementation>()
        {
            _services[typeof(TInterface)] = typeof(TImplementation);
        }

        public static TInterface Resolve<TInterface>()
        {
            if (!_services.TryGetValue(typeof(TInterface), out var implementationType) || implementationType == null)
            {
                throw new InvalidOperationException($"{typeof(TInterface).Name} için bir implementasyon bulunamadı");
            }

            var constructor = implementationType.GetConstructors().First();
            var paramaters = constructor.GetParameters();

            if (paramaters.Length == 0)
            {
                var instance = Activator.CreateInstance(implementationType);
                if (instance is null)
                {
                    throw new InvalidOperationException($"{implementationType.Name} örneği oluşturulamadı");
                }
                return (TInterface)instance;
            }

            var parameterInstances = paramaters.Select(
                p =>
                {
                    var method = typeof(ServiceProvider).GetMethod(nameof(Resolve))!.MakeGenericMethod(p.ParameterType);
                    return method.Invoke(null, null);
                }
            ).ToArray();

            return (TInterface)constructor.Invoke(parameterInstances);
        }
    }

    /*
    
    Unity ile uyumlu pratik kullanım 
    
    Not!!!:
        Unity tarafında Activator.CreateInstance() gibi reflection tabanlı new işlemleri runtime’da pahalı ve GC alloc üretir. Özellikle mobil cihazlarda bu sistemle instance oluşturmak mikro optimizasyon düzeyinde bile maliyetlidir.

ScriptableObject yaklaşımı bu yüzden daha uygundur çünkü:

Editor’den preload edilir, runtime’da new çalışmaz.

Unity’nin kendi yaşam döngüsüne entegredir (Asset olarak saklanır, GC'ye yük binmez).

Sahne dışı singleton gibi davranır, DontDestroyOnLoad gerekmez.

DI sistemini inspector üzerinden yönetebilirsin (hangi Dal → hangi Manager ilişkisi gibi).

Mobil build’de hem performans hem bellek stabilitesi sağlar.

Sonuç:
Bu ServiceProvider reflection kullanan yapı .NET ortamı için iyidir (Console, ASP.NET, WPF vb.),
ama Unity oyun motorunda ScriptableObject tabanlı service container yaklaşımı hem daha hafif hem de maintain edilebilir.
    
    */
}