using System;

namespace CSharpProgramlama.IleriCSharpEgitimi.Kalitim
{
    public class InheritanceKalitim
    {
        public static void InheritanceRun()
        {
            Person[] person = new Person[3]
            {
                new Customer{FirstName = "Engin"},
                 new Student{FirstName = "Derin"},
                  new Person{FirstName = "Salih"}
            };
            foreach (var item in person)
            {
                System.Console.WriteLine(item.FirstName);
            }


            //virtual method

            SqlServer sqlServer = new SqlServer();
            sqlServer.Add();
           

            MySqlServer mySqlServer = new MySqlServer();
            mySqlServer.Add();
          
        }
    }

    class Person
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
    }

    class Customer : Person
    {
        public string? City { get; set; }
    }
    class Student : Person
    {
        public string? Department { get; set; }
    }


    #region Virtual Method
    class Database
    {
        public virtual void Add()
        {
            System.Console.WriteLine("Adedd by default");
        }
        public virtual void Delete()
        {
            System.Console.WriteLine("Deleted by default");

        }
    }
    
    class SqlServer : Database
    {
        public override void Add()
        {
            System.Console.WriteLine("Adedd by Sql Code");
         //   base.Add();
        }
    }
    class MySqlServer : Database
    {
        public override void Add()
        {
            base.Add(); // virtual method kodlarını da çalıştır
        }
    }
    
        
    #endregion
}