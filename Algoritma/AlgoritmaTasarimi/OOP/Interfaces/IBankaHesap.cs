using System;

namespace Programlama.AlgoritmaTasarimi
{
    public interface IBankaHesap
    {
        void Yatir(decimal miktar);
        bool Cek(decimal miktar);

        decimal Bakiye{ get; }
    }
   
}