using System;
using Entity.Concrete;
using DataAccess.Abstract;

namespace DataAccess.Concrete.Firebase
{
    public class FirebaseCustomerDal : ICustomerDal
    {
      public void Add(Customer customer)
        {
            System.Console.WriteLine("Firebase kullanarak veritabanına Eklendi");
        }

        public bool CustomerExists(Customer customer)
        {
            return true;
        }
    }

}