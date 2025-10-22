using System;

namespace CSharpProgramlama.IleriCSharpEgitimi
{
    public class Siniflar
    {
        public static void SiniflarRun()
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();

            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();

            Customer customer = new Customer();
            customer.ID = 1;
            customer.FirstName = "Serkan";
            customer.LastName = "Sevtekin";
            customer.City = "İzmir";
            System.Console.WriteLine(customer.FirstName);

            Customer customer1 = new Customer { ID = 2, City = "Istanbul", FirstName = "Derin", LastName = "Tap" };
            System.Console.WriteLine(customer1.FirstName);

        }
    }

    class CustomerManager
    {
        public void Add()
        {
            System.Console.WriteLine("Custommer Added!");
        }

        public void Update()
        {
            System.Console.WriteLine("Customer Updated!");
        }
    }
    class ProductManager
    {
        public void Add()
        {
            System.Console.WriteLine("Product Added!");
        }

        public void Update()
        {
            System.Console.WriteLine("Product Updated!");
        }



    }
    class Customer
    {
        //Field
        //string? _firstName;

        //Properties ( en çok kullanılan )
        public int ID { get; set; }
       public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? City { get; set; }
    }
}