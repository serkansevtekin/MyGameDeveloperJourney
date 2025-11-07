using System;
using DataAccess.Abstract;
using Entity.Concrete;

namespace DataAccess.Concrete.Firebase
{
    public class FirebaseEmployeeDal : IEmployeeDal
    {
        public List<Employee> GeAll()
        {
            return new List<Employee> {
                 new Employee {
                    Id = 1,
                    FirstName = "Elif",
                    LastName = "Del",
                    IdentityNumber = "12345",
                    YearOfBirth=1994,
                    Salay=2000
                     },

                new Employee {
                    Id = 2,
                    FirstName = "Seher",
                    LastName = "Jonl",
                    IdentityNumber = "98745",
                    YearOfBirth=1986,
                    Salay=1000
                     },
            };


        }
    }

}