using System;

namespace EgitimSatis
{
    class EgitimManager : IEgitimService
    {
        private IEgitimDal _egitimDal;
        private IKampanyaService _kampanyaService;
        public EgitimManager(IEgitimDal egitimDal, IKampanyaService kampanyaService)
        {
            _egitimDal = egitimDal;
            _kampanyaService = kampanyaService;
        }
        public List<Egitim> ListeleEgitimler()
        {

            List<Egitim> egitimler = _egitimDal.ListeleEgitimler();


            _kampanyaService.FiyatGuncelle(egitimler);
            return egitimler;
        }





    }
}