using System;
namespace Programlama.AlgoritmaTasarimi
{
    class ConstructorsOfderivedClassesCLass
    {
        public static void ConstructorsOfderivedClassesRunMethod()
        {
            Derived d = new Derived();

            System.Console.WriteLine();

            Derived2 s = new Derived2("Serkan", 31);

            System.Console.WriteLine();

            Derived3 a = new Derived3();
            Derived3 b = new Derived3("Ömer", 18);
        }
    }

    #region Tanım
    /*
    - Derived class constructors -> Yeni türetilmiş sınıfların yapıcı (constructor) metotları
    - Türetilmiş sınıflardan bir nesne üretildiğinde nesne üretildiğinde ilk olarak "Object" yapılandırıcısı çalışacaltır ve hiyerarşi aşağıya doğru takip edilecektir.
    - Her yapılandırıcı kendi alanları (fields) üzerinde işlem gerçekleştirecektir.


    */
    #endregion


    #region 1- Taban  sınıf (base class) consturctor'u önce çalışır
    // Bir sınıf miras aldığında, önce base class constructor'u tetiklenir.
    // Sonra derived class constructor çalışır.

    class Base
    {
        //Base class constructor
        public Base()
        {
            System.Console.WriteLine("Base constructor çalıştı");
        }
    }

    class Derived : Base
    {
        //Drived class constructor
        public Derived()
        {
            System.Console.WriteLine("Derived class constructor çalıştı");
        }
    }

    #endregion



    #region 2- Parametreli base constructor çağırmak
    // Eğer base class'ın parametresiz constructor'u yoksa, drived class base(..) ile paramtre göndermek zorunda.

    class Base2
    {
        public string? _name { get; }
        public Base2(string? Name)
        {
            _name = Name;
            System.Console.WriteLine($"Base class Construcutor: {Name}");
        }

    }


    class Derived2 : Base2
    {
        public int _age { get; }

        //Base'e parametre göndermek için: base(name) yazıyoruz
        public Derived2(string name, int Age) : base(name)
        {
            _age = Age;
            System.Console.WriteLine($"Derived constructor: {name} {Age}");
        }
    }

    #endregion

    #region 3- this ile constructor chaining
    // Aynı sınıf içindeki diğer cosntructor'u çağırabilirsin -> this(...)
    // Ama base(...) ve this(...) aynnı anda kullanılmaz

    class Base3
    {
        public Base3(string? msg)
        {
            System.Console.WriteLine("Base 3: " + msg);
        }
    }

    class Derived3 : Base3
    {
        public Derived3() : this("Default", 0)
        {

        }

        public Derived3(string name, int age) : base(name)
        {
            System.Console.WriteLine($"Derived 3 : {name} {age}");
        }
    }
        
    #endregion
}