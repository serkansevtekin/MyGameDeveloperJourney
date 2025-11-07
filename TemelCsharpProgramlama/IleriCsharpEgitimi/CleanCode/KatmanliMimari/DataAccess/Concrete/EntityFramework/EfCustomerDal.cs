using System;
using DataAccess.Abstract;
using Entity.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCustomerDal : ICustomerDal
    {
        public void Add(Customer customer)
        {
            System.Console.WriteLine("Entitty Freamwork kullanarak veritabanına Eklendi");
        }

        public bool CustomerExists(Customer customer)
        {
            return true;
        }
    }
}