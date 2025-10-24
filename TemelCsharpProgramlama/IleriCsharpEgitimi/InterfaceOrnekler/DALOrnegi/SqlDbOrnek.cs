using System;

namespace CSharpProgramlama.IleriCSharpEgitimi.Interfaces
{
    class SQLServerCustomerDAL : ICustomerDAL
    {
        public void Add()
        {
            System.Console.WriteLine("Sql Adedd");
        }

        public void Delete()
        {
           System.Console.WriteLine("Sql Deleted");
        }

        public void Update()
        {
           System.Console.WriteLine("Sql Updated");
        }
    }
}