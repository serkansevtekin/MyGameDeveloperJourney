using System;

namespace EgitimSatis
{
    class EgitimSatisClass
    {
        public static void EgitimSatisRunMain()
        {
            IEgitimService egitimService = new EgitimManager(
                new FirebaseEgitimDal(),
                new YuzdelikIndirimKampanyaService()
                );
            foreach (var egitim in egitimService.ListeleEgitimler())
            {
                System.Console.WriteLine(egitim.Ad + " = "+ egitim.Fiyat);
            }
        }
    }
    

}