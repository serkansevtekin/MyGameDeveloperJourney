using System;
using CSharpProgramlama.IleriCSharpEgitimi.Interfaces.KendiOrnegim;

namespace CSharpProgramlama.IleriCSharpEgitimi.Interfaces
{
    class InterfaceClass
    {
        public static void InterfaceRun()
        {
            // InterfacesIntro();

            // GercekHayatOrnek1();

            // GercekHayatOrnek2();

            // KendiOrnegim();

            // Çoklu İmplementasyon
            IWorker[] workers = new IWorker[3]
            {
                new Manager(),
                new Workers(),
                new Robot()
            };

            foreach (var worker in workers)
            {
                worker.Work();
            }

            List<IEat> eats = new List<IEat>(){
                new Workers(),
                new Manager(),

            };

            foreach (var item in eats)
            {
                item.Eat();
            }


           
        }

        private static void KendiOrnegim()
        {
            List<IPersonDal> personDals = new List<IPersonDal>();
            personDals.Add(new SqlPersonDAL());
            personDals.Add(new FirebasePersonDAL());
            foreach (var item in personDals)
            {
                item.Add();
            }

            SqlPersonDAL sqlPersonDAL = new SqlPersonDAL(2);
            PersonManager pm = new PersonManager(sqlPersonDAL);
            pm.Add();
        }

        private static void GercekHayatOrnek2()
        {
            List<ICustomerDAL> customers = new List<ICustomerDAL>()
            {
                new SQLServerCustomerDAL(),
                new OracleServerCustomerDAL()
            };

            foreach (var item in customers)
            {
                item.Add();

            }
        }

        private static void GercekHayatOrnek1()
        {
            /* CustomManager customManager = new CustomManager();
            customManager.Add(new SQLServerCustomerDAL());
            customManager.Add(new OracleServerCustomerDAL()); */

            ICustomerDAL sqlDal = new SQLServerCustomerDAL();
            CustomManager manager = new CustomManager(sqlDal);
            manager.Add();
            manager.Update();



            ICustomerDAL orackleDal = new OracleServerCustomerDAL();
            CustomManager manager2 = new CustomManager(orackleDal);

            manager2.Add();
        }

        private static void InterfacesIntro()
        {
            PersonMenager menager = new PersonMenager();

            IPerson customer = new Customer
            {
                id = 1,
                FirstName = "serkan",
                LastName = "Serkan",
                Adress = "İzmir"
            };




            IPerson student = new Student
            {
                id = 1,
                FirstName = "Haluk",
                LastName = "Tarhana",
                Departmant = "Computer Sciences"
            };

            IPerson worker = new Worker(1, "Kemal", "Dekor", "Security");

            menager.Add(student);
            menager.Add(worker);
            menager.Add(customer);
        }
    }

    //soyut nesne
    interface IPerson
    {
        int id { get; set; }
        string? FirstName { get; set; }
        string? LastName { get; set; }

    }

    //somut nesne
    class Customer : IPerson
    {
        public string? Adress { get; set; }

        //implemented properties
        public int id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }




    }
    //somut nesne
    class Student : IPerson
    {
        public string? Departmant { get; set; }

        //implemented properties
        public int id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }

    }

    //somut nesne
    class Worker : IPerson
    {
        //Worder class properties
        public string? Departmant { get; private set; }

        //IPerson Implemented properties
        public int id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }

        //Constructor
        public Worker(int id, string firsName, string lastName, string Departmant)
        {
            this.id = id;
            this.FirstName = firsName;
            this.LastName = lastName;
            this.Departmant = Departmant;
        }

    }

    class PersonMenager
    {
        public void Add(IPerson person)
        {
            System.Console.WriteLine(person.FirstName);
        }
    }


    #region Çoklu İmplementasyon
    interface IWorker
    {
        void Work();

    }

    interface IEat
    {
        void Eat();
    }

    interface ISalary
    {
        void GetSalary();
    }
    class Manager : IWorker, IEat, ISalary
    {
        public void Eat()
        {
            System.Console.WriteLine("Menager Eat");
        }

        public void GetSalary()
        {
            System.Console.WriteLine("Menager GetSalary");
        }

        public void Work()
        {
            System.Console.WriteLine("Menager Work");
        }
    }

    class Workers : IWorker, IEat, ISalary
    {
        public void Eat()
        {
            System.Console.WriteLine("Workers Eat");
        }

        public void GetSalary()
        {
            System.Console.WriteLine("Workers GetSalary");
        }

        public void Work()
        {
            System.Console.WriteLine("Workers Work");
        }
    }
    class Robot : IWorker
    {
        public void Work()
        {
            System.Console.WriteLine("Robot Work");
        }
    }
    #endregion






    #region Tanım
    /*
    - Interface (Arayüz): Bir sınıfın hanig metotları ve özellikleri içermesi gerektiğini belirleyen bir şablondur.
    - İçinde sadece tanımlar vardır, gövde (implementation) yoktur.

    Interface İçinde:
        * Metot imazası olur
        * Property, event ve indexer tanımı olur
        * Interface uzerinde referans tutabilirsin ( bağımlılığı azaltırsın, polymorfizm kullanırsın.)
       
        !*! Alan (field) veya yapıcı (constructor) olamaz

    Basit Tanım:
        - Kalıtım değil, Sözleşme gibidir (Bu interface'i uygulayan sınıf şu metotları mutlaka yazacak)
        - Bir sınıf birden fazla interface'i uygulayabilir.
        - Kodun esnekliğini ve test edilebilirliğini artırır.
        - Interface miras alınabilir
        - Farklı sınıfları ortak davranış altında toplamak
    
    Formül:
        * Class = "Nasıl Yapılır"
        * Interface = "Ne yapılır"
        * Abstract class = " Hem ne, hem nasılın karışımı "
    

    | Özellik                 | Interface           | Abstract Class   |
| ----------------------- | ------------------- | ---------------- |
| Gövde içerir mi         | Hayır (C# 8+ hariç) | Evet             |
| Field tanımlanabilir mi | Hayır               | Evet             |
| Çoklu kalıtım           | Evet                | Hayır            |
| Amaç                    | Davranış tanımı     | Ortak temel yapı |



Yazılım geliştirmede en çok kabul gören 5 temel prensip SOLID prensipleridir.

Açılım:

S — Single Responsibility Principle (Tek Sorumluluk İlkesi)
Bir sınıfın yalnızca bir görevi olmalı. Birden fazla işi yapmaya başlarsa bakım zorlaşır.

O — Open/Closed Principle (Açık/Kapalı İlkesi)
Kod genişletmeye açık, değişikliğe kapalı olmalı. Yeni özellik eklerken mevcut kodu değiştirmemek hedeflenir.

L — Liskov Substitution Principle (Liskov Yerine Geçme İlkesi)
Türetilmiş sınıf, taban sınıfın yerine sorunsuz geçebilmeli. Yani kalıtım mantıksal olarak uyumlu olmalı.

I — Interface Segregation Principle (Arayüz Ayrımı İlkesi)
Bir sınıfa gereksiz metotları zorla uygulatmamak gerekir. Büyük arayüzleri küçük, amaca uygun parçalara böl.

D — Dependency Inversion Principle (Bağımlılığı Tersine Çevirme İlkesi)
Yüksek seviyeli modüller, düşük seviyeli detaylara değil soyutlamalara (interface) bağımlı olmalı.

Bu 5 ilke, yazılımın esnek, test edilebilir, sürdürülebilir olmasını sağlar.
Kısaca: SRP, OCP, LSP, ISP, DIP = SOLID.



    */
    #endregion
}