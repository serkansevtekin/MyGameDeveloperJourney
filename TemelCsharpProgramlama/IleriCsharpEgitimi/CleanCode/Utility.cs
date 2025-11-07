using System;
using FluentValidation;

namespace CleanCode
{
    public static class Utility
    {
        public static void Validate<T>(IValidator<T> validator, T entity)
        {

            var result = validator.Validate(entity);
            if (result.Errors.Count > 0)
            {
                throw new FluentValidation.ValidationException(result.Errors);
            }


        }


        public static void CheckPersonExists(Persons person, IPersonService personService)
        {
            if (!personService.CheckPerson(person))
            {
                throw new Exception("Kişi bilgileri hatalı");
            }
        }
    }

}