using System;

namespace CleanCode.ReferaceTypes
{
    class ReferaceTypesClass
    {

        //99.2 ve 99.3 nolu videolar
        public static void ReferaceTypesRunMain()
        {
            //Temel();

            Customer customer = new Customer { Id = 1, FirstName = "Serkan" };
            Customer custemer2 = customer;

            Person person1 = customer;
            Person person2 = new Employee();

            PersonDal personDal = new PersonDal();
            personDal.Add(new Visitor());
        }

        private static void Temel()
        {
            //Değer tip
            int sayi1 = 20;
            int sayi2 = 25;
            sayi1 = sayi2;
            sayi2 = 30;
            System.Console.WriteLine(sayi1);//25
            System.Console.WriteLine(sayi2);//30

            /*
        +-----------------------------+        +---------------------+
        |          STACK              |        |        HEAP         |
        +-----------------------------+        +---------------------+
        | sayi1 : int = 25            |        | (boş – değer tip    |
        | sayi2 : int = 30            |        |  heap kullanmaz)    |
        +-----------------------------+        +---------------------+

            */


            //Referance type
            int[] sayilar1 = new int[] { 1, 2, 3 };
            int[] sayilar2 = new int[] { 4, 5, 6 };

            sayilar1 = sayilar2;
            sayilar2[0] = 30;

            System.Console.WriteLine(sayilar1[0]);//30
            System.Console.WriteLine(sayilar2[0]);//30

            /*
          +-----------------------------------------------+
          |                    STACK                      |
          +-----------------------------------------------+
          | sayilar1 : int[] --------------------┐         |
          | sayilar2 : int[] --------------------┘───┐     |
          +-----------------------------------------------+
                                                     │
                                                     ▼
                          +--------------------------------+
                          |             HEAP               |
                          +--------------------------------+
                          | Array<int> (Addr: 0x001)       |
                          |------------------------------- |
                          | [0] = 30                       |
                          | [1] = 5                        |
                          | [2] = 6                        |
                          +--------------------------------+

            
            */


            //Referance ve Value Type Karşılaştırma
            /*
+-----------------------+         +----------------------+
|       VALUE TYPE      |         |    REFERENCE TYPE    |
+-----------------------+         +----------------------+
| Stack:                |         | Stack:               |
|  - sayi1 = 25         |         |  - sayilar1 → obj#1  |
|  - sayi2 = 30         |         |  - sayilar2 → obj#1  |
|                       |         |                      |
| Heap: (kullanılmaz)   |         | Heap:                |
|                       |         |  - obj#1: [30,5,6]   |
+-----------------------+         +----------------------+

            */
        }
    }
    
    class Person
    {
         public int Id { get; set; }
        public string? FirstName { get; set; }
    }

    class Customer : Person
    {
        public string? CreditCardNo { get; set; }
    }
     class Employee : Person
    {
       public decimal Salary { get; set; }
    }
     class Visitor : Person
    {
       public decimal VisitorCard { get; set; }
    }

    class Product
    {
        public string? Name { get; set; }
    }

    class PersonDal
    {
        public void Add(Person person)
        {
            
        }
    }



}