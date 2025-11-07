using System;

using Business.Abstract;
using Business.Concrete;
using Business.ServiceAdapters;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.Firebase;
using DataAccess.Concrete.MysqlServer;
using DataAccess.Concrete.NHibernate;

namespace Business.Core.Dependency.DependencyResolver
{
    public static class CustomerDependencyResolver
    {

        public static void Configure()
        {
            // DataAccess katmanı
            ServiceProvider.Register<ICustomerDal, FirebaseCustomerDal>();
            ServiceProvider.Register<IEmployeeDal, FirebaseEmployeeDal>();
            ServiceProvider.Register<IProductDal, FirebaseProductDal>();


            // Servis Katmanı
            ServiceProvider.Register<ICustomerService, CustomerManager>();
            ServiceProvider.Register<IEmployeeService, EmployeeManager>();
            ServiceProvider.Register<IProdctService, ProductManager>();

            // Diğer Servisler
            ServiceProvider.Register<IPersonService, KpsServiceAdapter>();

        }

    }
}