using System;
using System.ComponentModel.DataAnnotations;
using Business.Abstract;
using Business.Concrete;
using Business.Core.Dependency;
using Business.Core.Dependency.DependencyResolver;
using Business.ServiceAdapters;

using Entity.Concrete;
using DataAccess.Concrete.EntityFramework;

using FluentValidation;
namespace CleanCode
{

    //Kirli kodu düzelttik Katmanlı mimari yaptık
    class ParametreliKirliCodeClass
    {
        public static void ParametreliKirliCodeRunMethod()
        {
            CustomerDependencyResolver.Configure();
            // CustomerDemo();
            //EmployeeDemo();

            //Intertional Programing -> ihtiyaç olduğunda oluşturua oluştura 
            IProdctService prodctService = ServiceProvider.Resolve<IProdctService>();
            var result = prodctService.GetAll();
                foreach (var product in result)
                {
                    System.Console.WriteLine(product.Name);
                }
            
        }

        private static void CustomerDemo()
        {
            ICustomerService customerService = ServiceProvider.Resolve<ICustomerService>();

            customerService.Add(new Customer
            {
                Id = 1,
                CityId = 36,
                FirstName = "Serkan",
                LastName = "Sevtekin",
                IdentityNumber = "1234",
                YearOfBirth = 1998
            });
        }

        private static void EmployeeDemo()
        {
            IEmployeeService employeeService = ServiceProvider.Resolve<IEmployeeService>();
            var result = employeeService.GetAll();

            foreach (var employee in result)
            {
                System.Console.WriteLine($"{employee.FirstName}");
            }
        }

    }

   

    /*
    
    Unity ile uyumlu pratik kullanım

    // Awake ile sahnede birkez çağırıyoruz
  void Awake()
{
    ServiceProvider.Register<ICustomerService, CustomerManager>();
    ServiceProvider.Register<IEnemySpawner, EnemySpawner>();
}

// sonra her yerde kullanıla bilir
var customer = ServiceProvider.Resolve<ICustomerService>();


    */



}












