using System;
using Entity.Concrete;

namespace DataAccess.Abstract

{
    public interface IEmployeeDal
    {
        List<Employee> GeAll();
    }
}