using System;

namespace EgitimSatis
{
    public class StandartFiyatKampanyaManager : IKampanyaService
    {
        public void FiyatGuncelle(List<Egitim> egitimler)
        {
            foreach (var egitim in egitimler)
            {
                egitim.Fiyat = GuncelStandartFiyatiGetir();
            }
        }


        private decimal GuncelStandartFiyatiGetir()
        {
            // veri tabanına bağlan 
            return 25; // veri tanından geliyor farzet
        }
    }

}