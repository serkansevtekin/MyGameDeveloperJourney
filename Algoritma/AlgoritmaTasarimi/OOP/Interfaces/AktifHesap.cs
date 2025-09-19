using System;

namespace Programlama.AlgoritmaTasarimi
{
    public class AktifHesap : ITrasfer
    {
        public decimal _bakiye;
        public decimal Bakiye => _bakiye;

        public bool Cek(decimal miktar)
        {
            if (miktar > _bakiye)
            {
                System.Console.WriteLine("Bakiye Yetersiz");
                return false;
            }

            _bakiye -= miktar;
            return true;
        }


        //ITransfer den implemente edilen ezilecek olan method
        public bool TrasferYap(IBankaHesap aliciHesap, decimal miktar)
        {
            bool sonuc = Cek(miktar);
            if (sonuc)
            {
                aliciHesap.Yatir(miktar);
            }
            return sonuc;
        }

        public void Yatir(decimal miktar) => _bakiye += miktar;

        public override string ToString() => $"Aktif hesap bakiye bilgisi: {_bakiye}";
    }
}