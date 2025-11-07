using System;
using DataAccess.Abstract;
using Entity.Concrete;


namespace DataAccess.Concrete.NHibernate
{
    public class NhCustomerDal : ICustomerDal
    {
        public void Add(Customer customer)
        {
            System.Console.WriteLine("Oracle veritabanına Eklendi");

        }

        public bool CustomerExists(Customer customer)
        {
            return true;
        }
    }
}