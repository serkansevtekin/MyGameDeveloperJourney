using System;

namespace Programlama.AlgoritmaTasarimi
{
    public class Arac : Tasit // inheritance (kalıtım)
    {
        #region Fields değişkenleri
        private string? _marka, _model, _renk;
        private int _yil;

        #endregion

        #region Properties
        public string? Marka { get => _marka; set => _marka = value; }
        public string? Model { get => _model; set => _model = value; }
        public string? Renk { get => _renk; set => _renk = value; }
        public int Yil { get => _yil; set => _yil = value; }


        #endregion

        #region Constructors
        public Arac()
        {

        }
        public Arac(string marka, string model, string renk, int yil)
        {
            Marka = marka;
            Model = model;
            Renk = renk;
            Yil = yil;
            
        }


        #endregion

        #region Methods
        public void Calistir() => System.Console.WriteLine("Araç çalıştı!");
            
        public void Durdur() => System.Console.WriteLine("Araç durduruldu.");
        #endregion
    }
}