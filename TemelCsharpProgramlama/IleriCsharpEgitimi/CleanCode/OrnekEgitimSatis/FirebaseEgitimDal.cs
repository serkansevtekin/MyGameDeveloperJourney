using System;

namespace EgitimSatis
{
    class FirebaseEgitimDal : IEgitimDal
    {
        public List<Egitim> ListeleEgitimler()
        {
            return new List<Egitim>
            {
                new Egitim{Id=1 , Ad="C# Kursu", Fiyat = 400},
                new Egitim{Id=2 , Ad="Java Kursu", Fiyat = 300},
                new Egitim{Id=3 , Ad="Pyhon Kursu", Fiyat = 400}
            };
        }
    }
}