using System;
using Entity.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(c => c.FirstName).NotEmpty().WithMessage("Adı boş olamaz");
            RuleFor(c => c.FirstName).MinimumLength(2).WithMessage("Adı 2 karakterden az olamaz");
           

            RuleFor(c => c.LastName).NotEmpty().WithMessage("Soyadı boş olamaz");
            RuleFor(c => c.IdentityNumber).NotEmpty().WithMessage("Tc kimlik numarası boş olamaz");
            RuleFor(c => c.IdentityNumber).Must(HaveEvenLastDigit).WithMessage("Kimlik numarasının son rakamı çift olmalı");
        }

        private bool HaveEvenLastDigit(string? arg)
        {
            if (string.IsNullOrEmpty(arg))
            {
                return false;
            }

            // son karakteri al
            char lasChar = arg[^1];

            // rakamsa ve çift ise true
            if (char.IsDigit(lasChar))
            {
                return (lasChar - '0') % 2 == 0;
            }
            return false;
        }
    }
}