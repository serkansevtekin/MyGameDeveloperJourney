using System;
using Entity.Concrete;


namespace Business.Abstract
{
    internal interface IProdctService
    {
        List<Product> GetAll();
    }

  
}