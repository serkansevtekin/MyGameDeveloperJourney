using System;

namespace CSharpProgramlama.IleriCSharpEgitimi.Interfaces.KendiOrnegim
{
    class FirebasePersonDAL : IPersonDal
    {
        public int personId { get; set; }

        public FirebasePersonDAL(){}

        public FirebasePersonDAL(int id)
        {
            this.personId = id;
        }

        public void Add()
        {
            System.Console.WriteLine("Firebase Adedd");
        }

        public void Delete()
        {
            System.Console.WriteLine("Firebase Deletted");

        }

        public void Update()
        {
            System.Console.WriteLine("Firebase Uptadedd");

        }
    }
}