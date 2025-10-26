using System;


namespace CSharpProgramlama.IleriCSharpEgitimi.GenericSinifVeMetot
{
    class GenericSinifVeMetotClass
    {
        public static void GenericSinifVeMetotRun()
        {
            Utilities utilities = new Utilities();
            List<string> result = utilities.BuildList<string>("Ankara", "İzmir", "Adana");
            foreach (var item in result)
            {
                System.Console.WriteLine(item);
            }
            System.Console.WriteLine("-------------------------");

            List<Customer> result2 = utilities.BuildList<Customer>(
                new Customer { FirstName = "serkan" },
                new Customer { FirstName = "Hakan" },
                new Customer { FirstName = "Ahmet" },
                new Customer { FirstName = "Turan" }
                );

                foreach (var item in result2)
                {
                    System.Console.WriteLine(item.FirstName);
                }
        }
    }


    // Generic Methods
    class Utilities
    {
        public List<T> BuildList<T>(params T[] items)
        {
            return new List<T>(items);
        }
    }






    /// <summary>
    /// ///////////////
    /// </summary>


    interface IProductDAL : IRepository<Product>
    {

    }

    //IEntity generic kısıttan geliyor
    class Product: IEntity
    {

    }
    class ProductDal : IProductDAL
    {
        public void Add(Product entitiy)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product entitiy)
        {
            throw new NotImplementedException();
        }

        public Product Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Product entitiy)
        {
            throw new NotImplementedException();
        }
    }

    interface ICustomerDAL : IRepository<Customer>
    {
        void Custom();
    }

     //IEntity generic kısıttan geliyor
    class Customer: IEntity
    {
        public string? FirstName { get; set; }
    }
    class CustomerDal : ICustomerDAL
    {
        public void Add(Customer entitiy)
        {
            throw new NotImplementedException();
        }

        public void Custom()
        {
            throw new NotImplementedException();
        }

        public void Delete(Customer entitiy)
        {
            throw new NotImplementedException();
        }

        public Customer Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Customer entitiy)
        {
            throw new NotImplementedException();
        }
    }

    // IStudentDal: Student entity'sine özel veri erişim arayüzü
    // IReposityor<Student>'ı kalıttığı için CRUD metotlarını alır
    interface IStudentDAL : IRepository<Student>
    {

    }
    // Studen: IEntity arayüzünü uygulayan bir entity sınıfıdır
    // Bu sayede IReposityoru tarafından kabul edilir
    class Student : IEntity
    {

    }

    // StudentDal: IStudentDal arayüzünü implement eden somut veri eirişim sınıfı
    // Tüm Crud operasyonları burada tanımlar 
    class StudentDal : IStudentDAL
    {
        public void Add(Student entitiy)
        {
            throw new NotImplementedException();
        }

        public void Delete(Student entitiy)
        {
            throw new NotImplementedException();
        }

        public Student Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Student> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Student entitiy)
        {
            throw new NotImplementedException();
        }
    }

    // IEntity: Her veri modelinin (örnek: Studen, Product, Customer)
    // uygulaması gereken temel işaretçi (marker) arayüzüdür
    // Genellikle veritabanı varklıklarını (entity) temsil eder
    interface IEntity
    {
    }

    

    //Repository arayüzü, yanzlıca referans tip (class) olan,
    //Entity arayüzünü uygulayan
    // ve parametresiz bir kuru (new()) metodu bulunan
    // türlerle (T) çalışabilir
    //class yerine struct yazsa idik Value Type kullana bilirdik
    interface IRepository<T> where T: class, IEntity, new() // T referans tip olamalı "class". T new'lenebilir bir tip olmalı. Generic tip kısıtlaması.
    {
        //Ortak veri erişim metotları
        List<T> GetAll();
        T Get(int id);
        void Add(T entitiy);
        void Delete(T entitiy);
        void Update(T entitiy);
    }
}