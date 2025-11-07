using System;
using DataAccess.Abstract;
using Entity.Concrete;

namespace DataAccess.Concrete.MysqlServer
{
    public class MysqlCustomerDal : ICustomerDal
    {
        public void Add(Customer customer)
        {
            System.Console.WriteLine("Myqsl veritabanına Eklendi");

        }

        public bool CustomerExists(Customer customer)
        {
            return true;
        }
    }

}