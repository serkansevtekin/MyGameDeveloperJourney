using System;

namespace Programlama.StructNameSpace //Namespace aynı
{

    public struct Nokta
    {
        #region Properties
        private int x { get; set; }
        private int y { get; set; }
        #endregion


        #region Constructor
        //Default constructor tanımlanamaz
        /* public Nokta()
          {

          } */
        //Parametreli constructor tanımlanabilir
        public Nokta(int X, int Y)
        {
            this.x = X;
            this.y = Y;
        }

        #endregion



        #region Getter-Setter Metotları
        public int publicX
        {
            get => x;
            set => x = value;
        }

        public int publicY
        {
            get => y;
            set => y = value;
        }
        #endregion



        #region Method Overloading toString
        public override string ToString()
        {
            return $"{x} , {y}";
        }
        #endregion


        #region Yapımıza yeni üye ekeleme -> Method

        public void SetOrigin()
        {
            this.x = 0;
            this.y = 0;
        }

        public void Degistir()
        {
            var gecici = this.x;
            this.x = this.y;
            this.y = gecici;
        }

        #endregion

    }
}