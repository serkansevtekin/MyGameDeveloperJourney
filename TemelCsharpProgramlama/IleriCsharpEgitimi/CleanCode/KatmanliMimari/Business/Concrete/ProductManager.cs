using System;
using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;

namespace Business.Concrete
{
    class ProductManager : IProdctService
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal )
        {
            _productDal = productDal;
        }
        public List<Product> GetAll()
        {
            return _productDal.GetAll();
        }
    }
}