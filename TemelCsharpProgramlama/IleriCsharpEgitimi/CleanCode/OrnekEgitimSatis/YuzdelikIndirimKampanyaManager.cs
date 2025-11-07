using System;

namespace EgitimSatis
{
    public class YuzdelikIndirimKampanyaService : IKampanyaService
    
    {
        public void FiyatGuncelle(List<Egitim> egitimler)
        {
            foreach (var egitim in egitimler)
            {
                egitim.Fiyat = egitim.Fiyat - (egitim.Fiyat * YuzdelikIndirimiGetir());
            }
        }
        private decimal YuzdelikIndirimiGetir()
        {
            // veri tabanına bağlan 
            return Convert.ToDecimal(0.90);// veri tanından geliyor farzet
        }
    }
}