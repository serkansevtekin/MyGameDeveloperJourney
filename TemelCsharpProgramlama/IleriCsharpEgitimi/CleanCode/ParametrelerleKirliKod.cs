using System;
using System.ComponentModel.DataAnnotations;
using CleanCode.ReferaceTypes;
using FluentValidation;
namespace CleanCode
{
    
    class ParametreliKirliCodeClass
    {
        public static void ParametreliKirliCodeRunMethod()
        {
            CustomerManager customerManager = new CustomerManager(new MysqlCustomerDal(),new KpsServiceAdapter() );
            customerManager.Add(new Customer
            {
                FirstName = "Serkan",
                LastName = "Sevtekin",
                IdentityNumber = "222"
            });

            //Sadece bunda FirstName min 2 karakter isteniyor
            customerManager.AddByOtherBusiness(new Customer
            {
                FirstName = "SS",
                LastName = "Ordakal",
                IdentityNumber = "444"
            });



        }
    }


    public class Customer : Persons
    {


        public int CityId { get; set; }

    }

    public interface ICustomerService
    {

        void Add(Customer customer);
    }
    public class CustomerManager : ICustomerService
    {

        private ICustomerDal _customerDal;
        private IPersonService _personService;
        public CustomerManager(ICustomerDal customerDal, IPersonService personService)
        {
            _customerDal = customerDal;
            _personService = personService;
        }

        public void Add(Customer customer)
        {

            Utility.Validate(new CustomerValidator(), customer);

            Utility.CheckPersonExists(customer, _personService);

            _customerDal.Add(customer);


        }



        public void AddByOtherBusiness(Customer customer)
        {
            ValidateFirstNameIfEmpty(customer);
            ValidateLastNameIfEmpty(customer);
            ValidateFirstNameLengthMinTwoCharacter(customer);

            Utility.CheckPersonExists(customer, _personService);
            _customerDal.Add(customer);

        }

        private void CheckCustomerExists(Customer customer)
        {

            if (_customerDal.CustomerExists(customer))
            {
                throw new Exception("Müşteri zaten mevcut");
            }
        }



        private void ValidateFirstNameIfEmpty(Customer customer)
        {
            if (String.IsNullOrEmpty(customer.FirstName))
            {
                throw new Exception("Validasyon hatası FirstName empty");
            }
        }
        private void ValidateFirstNameLengthMinTwoCharacter(Customer customer)
        {
            if (customer.FirstName!.Length < 2)
            {
                throw new Exception("FirsName 2 karakterden az olamaz");
            }
        }


        private void ValidateLastNameIfEmpty(Customer customer)
        {
            if (String.IsNullOrEmpty(customer.LastName))
            {
                throw new Exception("Validasyon hatası LastName empty");

            }
        }
        private void ValidateIdentityNumberIfEmpty(Customer customer)
        {
            if (String.IsNullOrEmpty(customer.IdentityNumber))
            {
                throw new Exception("Validasyon hatası IdentityNumber empty");

            }
        }
    }

    public interface ICustomerDal
    {
        void Add(Customer customer);
        bool CustomerExists(Customer customer);
    }


    public class EnfCustomerDal : ICustomerDal
    {
        public void Add(Customer customer)
        {
            System.Console.WriteLine("Nhibernate kullanarak veritabanına Eklendi");
        }

        public bool CustomerExists(Customer customer)
        {
            return true;
        }
    }

    public class NhCustomerDal : ICustomerDal
    {
        public void Add(Customer customer)
        {
            System.Console.WriteLine("Entity Freamwork kullanarak veritabanına Eklendi");
        }

        public bool CustomerExists(Customer customer)
        {
            return true;
        }
    }

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


    // Bu koda dokunamıyoruz mesela
    public class KpsService
    {
        public bool CheckPerson(long tcNo, string adi, string soyadi, int yil)
        {
            return true;
        }
    }

    public class KpsServiceAdapter : IPersonService
    {
        public bool CheckPerson(Persons person)
        {
            KpsService kpsService = new KpsService();
            return kpsService.CheckPerson(Convert.ToInt64(person.IdentityNumber), person.FirstName!, person.LastName!, person.YearOfBirth);
        }
    }
    public interface IPersonService
    {
        bool CheckPerson(Persons person);
    }

    public class Persons
    {
        public int Id { get; set; }

        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? IdentityNumber { get; set; }
        public int YearOfBirth { get; set; }
    }
}