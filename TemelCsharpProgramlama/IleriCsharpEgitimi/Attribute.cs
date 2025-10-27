using System;
using System.ComponentModel.DataAnnotations;

namespace CSharpProgramlama.IleriCSharpEgitimi.Attributes
{
    class AttrbuteClass
    {
        public static void AttrbuteRun()
        {
            Customer customer = new Customer { Id = 1, LastName = "Sevtekin", Age = 32 };
            CustomerDal customerDal = new CustomerDal();
            //customerDal.Add(customer);
            customerDal.AddNew(customer);

        }
    }

    [ToTable("Customers")]
    [ToTable("TblCustomers")]

    class Customer
    {
        public int Id { get; set; }

        [RequiredProperty]
        public string? FirtsName { get; set; }

        [RequiredProperty]
        public string? LastName { get; set; }

        [RequiredProperty]
        public int Age { get; set; }


    }
    class CustomerDal
    {

        // Hazır Attribute -> Obsolete, bir öğenin (metot, sınıf, özellik vb.) artık kullanılmaması gerektiğini belirtir.
        // Derleyici, bu öğe kullanıldığında uyarı veya hata verir
        // Parantez içindeki metin geliştiriciye hangi alternatifin kullanılacağını açıklar.
        [Obsolete("Don't use Add, instead use AddNew Method")]
        public void Add(Customer customer)
        {
            System.Console.WriteLine("{0} , {1} , {2}, {3}",
            customer.Id,
            customer.FirtsName,
            customer.LastName,
            customer.Age);
        }
        public void AddNew(Customer customer)
        {
            System.Console.WriteLine("{0} , {1} , {2}, {3}",
            customer.Id,
            customer.FirtsName,
            customer.LastName,
            customer.Age);
        }
    }
    // AttributeUsage -> Bu attribute'un hangi program öğelerine (class, property, fields, methods vb.) uygulanabileceğini belirtir.
    // "|" operatörü -> Birden fazla hedef belirtmek için kullanılır (örnek: Property ve Field)
    //  AllowMultiple -> true ise, aynı öğe üzerinde bu attribute birden fazla kez kullanılabilir.

    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = true)]
    class RequiredPropertyAttribute : Attribute
    {

    }

    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct, AllowMultiple = true)]
    class ToTableAttribute : Attribute
    {
        string? _tableName;
        public ToTableAttribute(string tableName)
        {
            _tableName = tableName;
        }
    }


}