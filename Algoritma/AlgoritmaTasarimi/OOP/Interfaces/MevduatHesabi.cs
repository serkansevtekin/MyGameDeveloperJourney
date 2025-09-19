using System;

namespace Programlama.AlgoritmaTasarimi
{
    public class MevduatHesabi : IBankaHesap
    {
        private decimal _bakiye;
        public decimal Bakiye => _bakiye; // sadece okunabilir yaptık ondan yukarıda _bakiye değişkeninin tanımladık

        public bool Cek(decimal miktar)
        {
            if (_bakiye >= miktar)
            {
                _bakiye -= miktar;
                return true;
            }
            else
            {
                System.Console.WriteLine("Bakiye Yetersiz!");
                return false;
            }
        }

        public void Yatir(decimal miktar) => _bakiye += miktar;

        public override string ToString() => $"Mevduat hesabı bakiye bilgisi {_bakiye}";
    }

}