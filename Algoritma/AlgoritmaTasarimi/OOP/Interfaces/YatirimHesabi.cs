using System;

namespace Programlama.AlgoritmaTasarimi
{
    public class YatirimHesabi : IBankaHesap
    {
        //İmplemente edilen bakiye bilgisi sadece okunduğu için field alanı oluşutruyoruz
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

        public void Yatir(decimal miktar) => _bakiye += miktar;

        public override string ToString() => $"Yatırım hesabı bakiye bilgisi: {_bakiye}";
    }
}