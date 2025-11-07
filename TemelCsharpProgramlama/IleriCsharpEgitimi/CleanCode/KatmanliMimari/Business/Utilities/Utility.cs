using System;
using Business.Abstract;
using Entity.Concrete;
using FluentValidation;

namespace Business.Utilities
{
     public static class Utility
    {

        /// <summary>
        /// Verilen entity nesnesini belirtilen FluentValidation validator'ı ile doğrular
        /// Hatalar varsa ValidationExpection fırlatır
        /// </summary>
        /// <typeparam name="T">Doğrulanacak nesne tipi</typeparam>
        /// <param name="validator">FluentValidation validator nesnesi</param>
        /// <param name="entity">Doğrulanacak entity nesnesi</param>
        /// <exception cref="FluentValidation.ValidationException">
        /// Doğrulama hataları oluştuğunda fırlatılır
        /// </exception>
        public static void Validate<T>(IValidator<T> validator, T entity)
        {

            var result = validator.Validate(entity);
            if (result.Errors.Count > 0)
            {
                throw new FluentValidation.ValidationException(result.Errors);
            }


        }


        /// <summary>
        /// Verilen kişi nesnesinin geçerli olup olmadığını kontrol eder.
        /// Bilgiler hatalıysa Exception fırlatır
        /// </summary>
        /// <param name="person"> Doğrulanacak kişi nesnesi </param>
        /// <param name="personService"> Kişi doğrulama servisi </param>
        /// <exception cref="Exception">Kişi bilgileri hatalıysa fırlatılır</exception>
        public static void CheckPersonExists(Persons persons, IPersonService personService)
        {
            if (!personService.CheckPerson(persons))
            {
                throw new Exception("Kişi bilgileri hatalı");
            }
        }
    }
}