using System;

namespace CSharpProgramlama.IleriCSharpEgitimi.Interfaces.KendiOrnegim
{
    public class SqlPersonDAL : IPersonDal
    {

        public int personId { get; set; }

        public SqlPersonDAL(){}

        public SqlPersonDAL(int id)
        {
            this.personId = id;
        }


        public void Add()
        {
            System.Console.WriteLine("Sql Adedd");
        }

        public void Delete()
        {
            System.Console.WriteLine("Sql Deletted");

        }

        public void Update()
        {
            System.Console.WriteLine("Sql Uptadedd");

        }
    }
}