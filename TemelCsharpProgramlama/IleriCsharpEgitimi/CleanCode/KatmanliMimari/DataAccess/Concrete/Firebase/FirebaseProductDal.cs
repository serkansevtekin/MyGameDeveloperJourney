using System;
using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;

namespace DataAccess.Concrete.Firebase
{
    public class FirebaseProductDal : IProductDal
    {
        public List<Product> GetAll()
        {
            return new List<Product>
            {
                new Product{Name ="Laptop"}
            };
        }
    }

}