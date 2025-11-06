using System;

namespace CleanCode
{
    // Kirli kodu düzelttik
    class ParametreliKirliCodeClass
    {
        public static void ParametreliKirliCodeRunMethod()
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new Customer
            {
                FirstName = "Serkan",
                LastName = "Sevtekin",
                IdentityNumber = "222"
            });
            customerManager.Add(new Customer
            {
                FirstName = "Hasan",
                LastName = "Dumrul",
                IdentityNumber = "123",
                CityId = 1
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


    class Customer
    {

        public int Id { get; set; }
        public int CityId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? IdentityNumber { get; set; }
    }

    interface ICustomerService
    {

        void Add(Customer customer);
    }
    class CustomerManager : ICustomerService
    {
        public void Add(Customer customer)
        {
            //code smell
            // Technical dept
            ValidateFirstNameIfEmpty(customer);
            ValidateLastNameIfEmpty(customer);
            

            CustomerDal customerDal = new CustomerDal();
            customerDal.Add(customer);


        }


        public void AddByOtherBusiness(Customer customer)
        {
            ValidateFirstNameIfEmpty(customer);
            ValidateLastNameIfEmpty(customer);
            ValidateFirstNameLengthMinTwoCharacter(customer);

            CustomerDal customerDal = new CustomerDal();
            customerDal.Add(customer);
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
    class CustomerDal
    {
        public void Add(Customer customer)
        {


            System.Console.WriteLine("Veritabanına Eklendi");


        }
    }


}