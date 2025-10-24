using System;
using CSharpProgramlama.IleriCSharpEgitimi.AbstractClass;

namespace CSharpProgramlama.IleriCSharpEgitimi.Constructor
{
    class ConstructorClass
    {
        public static void CollectionRun()
        {
            CustomerManagers customerManager = new CustomerManagers(10);
            customerManager.List();


            // 3 farklı kullanım
            Products products = new Products();
            Products products1 = new Products { Id = 1, Name = "Serkan" };
            Products products2 = new Products(1, "Serkan");

            //Constructor Injection
            EmployeeManagers employeeManagers = new EmployeeManagers(new DatabaseLoggerr());
            employeeManagers.Add();

            //Base sınıfa parametre göndermek
            PersonManager personManager = new PersonManager("Product");
            personManager.Add();


            //Static class
            Teacher.Number = 10;
            Utilities.Validate();

            Manager.DoSometing();//Static method
            Manager manager = new Manager(); // normal class
            manager.DoSometing2();//normal method


            //Singleton ornek kullanım
            // İlk erişim -> static constructor + normal cosntructor tetiklenir
            GameManager.Instance.AddScrore(10);

            // İkinci erişim -> aynı instance kullanılır, yenidem oluşturulmaz
            GameManager.Instance.AddScrore(20);

            // İki erişimde de aynı nesne kullanıldığı görülür
            System.Console.WriteLine("Final skor: " + GameManager.Instance.Score);
        }
    }

    class CustomerManagers
    {
        int _count = 15;
        public CustomerManagers(int count)
        {
            _count = count;
        }
        public CustomerManagers()
        {

        }
        public void List()
        {
            System.Console.WriteLine("Listed! {0} items", _count);
        }
        public void Add()
        {
            System.Console.WriteLine("Added!");
        }
    }


    class Products
    {

        public Products()
        {

        }

        private int _id;
        private string? _name;

        public Products(int id, string name)
        {
            _id = id;
            _name = name;
        }
        public int Id { get; set; }
        public string? Name { get; set; }
    }

    //Daha profesyonel
    interface ILoggerr
    {
        void Log();
    }

    class DatabaseLoggerr : ILoggerr
    {
        public void Log()
        {
            System.Console.WriteLine("Logged to database");
        }
    }
    class FileLoggerr : ILoggerr
    {
        public void Log()
        {
            System.Console.WriteLine("Logged to file");
        }
    }

    class EmployeeManagers
    {
        private ILoggerr _logger;
        public EmployeeManagers(ILoggerr logger)
        {
            _logger = logger;
        }
        public void Add()
        {
            _logger.Log();
            System.Console.WriteLine("Added!");
        }
    }

    //Base sınıfa parametre göndermek

    class BaseClass
    {
        string _entity;
        public BaseClass(string entity)
        {
            _entity = entity;
        }
        public void Message()
        {
            System.Console.WriteLine("{0} Message", _entity);
        }
    }

    class PersonManager : BaseClass
    {
        public PersonManager(string entity) : base(entity)
        {

        }

        public void Add()
        {
            System.Console.WriteLine("Added ");
            Message();
        }
    }


    //Static class ve metodlar
    static class Teacher
    {
        public static int Number { get; set; }
    }

    static class Utilities
    {
        static Utilities()
        {
            System.Console.WriteLine("Static Constructor çalıştı");
        }
        public static void Validate()
        {
            System.Console.WriteLine("Validation is done");
        }
    }

    class Manager
    {
        public static void DoSometing()
        {
            System.Console.WriteLine("done");
        }
        public void DoSometing2()
        {
            System.Console.WriteLine("done2");

        }
    }

    
}