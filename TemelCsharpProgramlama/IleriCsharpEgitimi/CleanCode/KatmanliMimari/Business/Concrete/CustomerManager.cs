using System;
using Business.Abstract;
using Business.Utilities;
using Business.ValidationRules.CustomValidation;
using Business.ValidationRules.FluentValidation;
using DataAccess.Abstract;
using Entity.Concrete;

namespace Business.Concrete
{
    public class CustomerManager: ICustomerService
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

            Utility.Validate<Customer>(new CustomerValidator(), customer);

            Utility.CheckPersonExists(customer, _personService);

            _customerDal.Add(customer);


        }



        public void AddByOtherBusiness(Customer customer)
        {
            CustomValidation.ValidateFirstNameIfEmpty(customer);
            CustomValidation.ValidateLastNameIfEmpty(customer);
            CustomValidation.ValidateFirstNameLengthMinTwoCharacter(customer);

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

    
    }
}