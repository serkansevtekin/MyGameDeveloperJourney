using System;

namespace Programlama.AlgoritmaTasarimi
{
    class Matris
    {

        #region Matris Oluşturma
       
       /// <summary>
       /// Matris Oluşturur
       /// </summary>
       /// <param name="satir">Satır sayısı</param>
       /// <param name="sutun">Sütun sayısı</param>
       /// <param name="min">Minimum değer</param>
       /// <param name="max">Maksimum değer</param>
       /// <returns>x matrisi döner</returns>
         internal int[,] MatrisOlusturma(int satir = 3, int sutun = 3, int min = 1, int max = 9)
        {
            //Satır ve sütun sayısı kadar 2D matris oluşturma
            int[,] x = new int[satir, sutun];

            //1. Döngü satır
            for (int i = 0; i < satir; i++)
            {
                //2. Döngü Sütun
                for (int j = 0; j < sutun; j++)
                {
                    //2D x dizisinin i ve j'nin ci elemanlarına verilen min ve max değerlerine göre rasgele değerler ver
                    x[i, j] = new Random().Next(min, max);
                }
            }

            return x;
        }
       #endregion




    }
}