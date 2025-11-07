using System;
using Business.Abstract;
using Entity.Concrete;

namespace Business.ServiceAdapters
{
      // Bu koda dokunamıyoruz mesela (dll, servicee, api) olduğunu düşün KpsService class'ını
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
}