using System;

namespace MultitonDPNamespace
{
    class MultitonDPClass
    {
        public static void MultitonRun()
        {
            var a = Multiton.GetInstance("A");
            var b = Multiton.GetInstance("B");
            var a2 = Multiton.GetInstance("A");

            System.Console.WriteLine(a == a2);
            System.Console.WriteLine(a == b);
        }
    }

    class Multiton
    {
        private static Dictionary<string, Multiton> _instances = new Dictionary<string, Multiton>();

        public string Name { get; }
        private Multiton(string name)
        {
            Name = name;
        }

        public static Multiton GetInstance(string key)
        {
            if (!_instances.ContainsKey(key))
            {
                _instances[key] = new Multiton(key);
            }
            return _instances[key];
        }
    }

    #region Multiton DP | Tanım
    /*
    Amaç:
        Singleton sadece tek nesne yaratır. Multiton, her anahtar için tek bir nesne yaratır. Yani sınıf örnekleri bir dictionary’de tutulur.

    Temel Mantık:
        - Her nesne bir "anahtar" ile ilişkilendirilir
        - Aynı anahtar ile tekrar istenirse önceden oluşturulan nesne döner
        - Farklı anahtarlar için yeni nesne oluşturula bilir


    Farkı (Singleton vs Multiton):
        - Singleton → 1 global örnek            
        - Multiton → Her anahtar için 1 örnek

    UML ŞEMASI

+--------------------+
|      Multiton      |
+--------------------+
| - instances: Map   |
| - name: string     |
+--------------------+
| + GetInstance(key) |
+--------------------+

    */
    #endregion
}