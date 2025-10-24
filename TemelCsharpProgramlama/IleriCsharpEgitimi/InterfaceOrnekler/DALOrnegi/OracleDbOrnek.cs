using System;

namespace CSharpProgramlama.IleriCSharpEgitimi.Interfaces
{
    class OracleServerCustomerDAL : ICustomerDAL
    {
        public void Add()
        {
            System.Console.WriteLine("Oracle Adedd");
        }

        public void Delete()
        {
           System.Console.WriteLine("Oracle Deleted");
        }

        public void Update()
        {
           System.Console.WriteLine("Oracle Updated");
        }
    }
}