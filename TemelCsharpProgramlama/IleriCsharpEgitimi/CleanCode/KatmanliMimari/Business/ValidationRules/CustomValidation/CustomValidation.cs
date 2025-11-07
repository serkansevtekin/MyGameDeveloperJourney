using System;
using Entity.Concrete;

namespace Business.ValidationRules.CustomValidation
{
    public static class CustomValidation
    {
        
        public static void ValidateFirstNameIfEmpty(Customer customer)
        {
            if (String.IsNullOrEmpty(customer.FirstName))
            {
                throw new Exception("Validasyon hatası FirstName empty");
            }
        }
        public static void ValidateFirstNameLengthMinTwoCharacter(Customer customer)
        {
            if (customer.FirstName!.Length < 2)
            {
                throw new Exception("FirsName 2 karakterden az olamaz");
            }
        }


        public static void ValidateLastNameIfEmpty(Customer customer)
        {
            if (String.IsNullOrEmpty(customer.LastName))
            {
                throw new Exception("Validasyon hatası LastName empty");

            }
        }
        public static void ValidateIdentityNumberIfEmpty(Customer customer)
        {
            if (String.IsNullOrEmpty(customer.IdentityNumber))
            {
                throw new Exception("Validasyon hatası IdentityNumber empty");

            }
        }
    }
}