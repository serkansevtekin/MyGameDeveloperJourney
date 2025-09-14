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


        #region Matris Yazırma

        /// <summary>
        /// Parametre olarak aldığı matrisi ekrana yazar
        /// </summary>
        /// <param name="X">Paremetre olarak gelen Matris</param>
        internal void MatrisYazdir(int[,] X)
        {
            for (int i = 0; i < X.GetLength(0); i++) // GetLength(0) -> Satır
            {
                for (int j = 0; j < X.GetLength(1); j++) // X.GetLength(1) -> Sütun
                {
                    Console.Write("{0,3}", X[i, j]);

                }
                System.Console.WriteLine();
            }
        }

        //2. Yazdı foksiyon tek boyut için
        internal void MatrisYazdir(int[] X)
        {
            System.Console.WriteLine();
            for (int i = 0; i < X.GetLength(0); i++)
            {
                System.Console.Write("{0,5}", X[i]);
            }
            System.Console.WriteLine();
        }


        #endregion

        #region Sifir Matrisi Oluştur
        /// <summary>
        /// Sifir Matirisi matrisi oluşturur
        /// </summary>
        /// <param name="satir">Satır sayısı</param>
        /// <param name="sutun">Sütun sayısı</param>
        /// <returns>Sıfır matrisi</returns>
        internal int[,] SifirMatrisiOLustur(int satir, int sutun)
        {
            return MatrisOlusturma(satir, sutun, 0, 0);

        }
        #endregion

        #region Birler Matrisi Oluştur
        internal int[,] BirlerMatrisiOlustur(int satir = 3, int sutun = 3)
        {
            return MatrisOlusturma(satir, sutun, 1
            , 1);
        }
        #endregion

        #region Köşegen (Diyagonal) Matris | Sadece kare matrisler olabiliyor
        /// <summary>
        /// Köşegen Matris Oluşturur
        /// </summary>
        /// <param name="boyut">Satır ve sütun sayısı</param>
        /// <param name="min">Min</param>
        /// <param name="max">Max</param>
        /// <returns>Köşegen Matris</returns>
        internal int[,] DiyagonalMatris(int boyut = 3, int min = 1, int max = 9)
        {
            int[,] X = SifirMatrisiOLustur(boyut, boyut);
            for (int i = 0; i < boyut; i++)
            {
                X[i, i] = new Random().Next(min, max);
            }
            return X;
        }

        #endregion


        #region Scaler Matris
        /// <summary>
        /// Skaler Matris Oluşturur
        /// </summary>
        /// <param name="boyut">Satır ve sütun</param>
        /// <param name="skaler">Köşegenler üstündeki değerler</param>
        /// <returns>Scaler Matris temsil eder.</returns>
        internal int[,] ScalerMatris(int boyut = 3, int skaler = 3)
        {
            return DiyagonalMatris(boyut, skaler, skaler);
        }

        #endregion

        #region Kare Matris Mi?
        /// <summary>
        /// Verilen iki boyutlu dizinin kare matri( satır sayısı == sütun sayısı) olup olmadığını kontrol eder
        /// </summary>
        /// <param name="X">Kontrol edilecek 2D tamsayı dizisi</param>
        /// <returns>
        /// true: Kare matris ise
        /// false: Kare matris değilse
        /// </returns>
        internal bool KareMatrisMi(int[,] X)
        {
            //Satır sayısı ile sütun sayısı eşitse true, değilse false döndürür
            return X.GetLength(0) == X.GetLength(1);//True || False döner

            // return X.GetLength(0) == X.GetLength(1) ? true : false; // Uzun Yazım
        }
        #endregion

        #region Birim Matris Mi?

        internal int[,] BirimMatrisOlustur(int boyut = 3)
        {
            return ScalerMatris(boyut, 1);
        }


        internal bool BirimMatrisMi(int[,] X)
        {
            bool s = true;

            for (int i = 0; (i < X.GetLength(0) && s == true); i++)
            {
                for (int j = 0; (j < X.GetLength(1) && s == true); j++)
                {
                    // diyagonal elemanlar dısındaki değeriler 0 mi?
                    if (X[i, j] != 0 && i != j)
                    {
                        s = false;
                        break;
                    }
                    else // diyagonal elemanlar 1 mi?
                    {
                        if (X[i, i] != 1 && i == j)
                        {
                            s = false;
                            break;
                        }
                    }
                }
            }


            return s;
        }

        #endregion

        #region Diyagonel Elemanların Listelenmesi
        /// <summary>
        /// Diyagonal elemanlarin listesisini bir dizi olarak döner.
        /// </summary>
        /// <param name="X">Gelen Matris</param>
        /// <returns>Diyagonal elemanların listesi</returns>
        internal int[] DiyagonelElemanlariListele(int[,] X)
        {
            if (KareMatrisMi(X))
            {
                int[] D = new int[X.GetLength(0)];
                for (int i = 0; i < X.GetLength(0); i++)
                {
                    D[i] = X[i, i];

                }
                return D;
            }
            else
            {
                System.Console.WriteLine("Litfen Kare Martirs gir");
            }

            return new int[1];
        }

        #endregion

        #region Bir Matirisin izi (Trace)(Tr)
        /// <summary>
        /// Bir matrisin izini hesaplar
        /// </summary>
        /// <param name="X">Matris</param>
        /// <returns>İzi</returns>
        internal int BirMatrisinİziTrace(int[,] X)
        {
            int t = 0;
            if (KareMatrisMi(X))
            {


                int[] D = DiyagonelElemanlariListele(X);

                for (int i = 0; i < X.GetLength(0); i++)
                {
                    t += X[i, i];
                }
                return t;
            }
            else
            {
                return t;
            }
        }

        #endregion

        #region Transpoz (Devriği)

        /// <summary>
        /// Bir matrisin Transpozunu alır
        /// </summary>
        /// <param name="X">Matirs</param>
        /// <returns>Transpoz</returns>
        internal int[,] Transpoz(int[,] X)
        {
            int[,] Tr = new int[X.GetLength(1), X.GetLength(0)];

            for (int i = 0; i < Tr.GetLength(0); i++)
                for (int j = 0; j < Tr.GetLength(1); j++)
                    Tr[i, j] = X[j, i];
            return Tr;
        }
        #endregion

        #region Bir Matrisi Yeniden Şekillendirme (ReShape)

        internal int[,] ReshapeMatris(int[,] X, int yeniSatir, int yeniSutun)
        {

            if (X.Length == yeniSatir * yeniSutun)
            {
                int[] D = new int[X.Length];
                int sayac = 0;
                int[,] Y = new int[yeniSatir, yeniSutun];
                for (int i = 0; i < X.GetLength(0); i++)
                {
                    for (int j = 0; j < X.GetLength(1); j++)
                    {
                        D[sayac] = X[i, j];
                        sayac++;
                    }

                }
                MatrisYazdir(D);
                sayac = 0;
                for (int i = 0; i < Y.GetLength(0); i++)
                {
                    for (int j = 0; j < Y.GetLength(1); j++)
                    {
                        Y[i, j] = D[sayac];
                        sayac++;
                    }
                }
                return Y;
            }
            else
            {
                System.Console.WriteLine("Bir hata oluştur");
                return new int[1, 1];
            }
        }

        #endregion


        #region Matris Karşılaştırma

        internal bool MatrisKarsilastir(int[,] X, int[,] Y)
        {

            bool s = true;
            // boyut kontrolü
            if (X.GetLength(0) == Y.GetLength(0) && X.GetLength(1) == Y.GetLength(1))
            {
                for (int i = 0; i < X.GetLength(0); i++)
                {
                    for (int j = 0; j < X.GetLength(1); j++)
                    {
                        if (X[i, j] == Y[i, j])
                        {
                            s = true;
                            break;
                        }
                    }
                }
            }
            else
            {
                s = false;
            }

            return s;
        }
        #endregion




        #region HataYazdır
        internal void HataYazdır(string mesaj)
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            System.Console.WriteLine(mesaj);
            Console.ResetColor();
        }
        #endregion


        #region Matris Determinant Hesabı. | 2*2| |3*3|
        /// <summary>
        /// Determinant hesabı yapar
        /// </summary>
        /// <param name="X">Matris</param>
        /// <returns>Determinanat</returns>
        internal int DeterminantHesabi(int[,] X)
        {
            int d = -1;
            if (KareMatrisMi(X))
            {
                if (X.Length == 4)
                {
                    d = X[0, 0] * X[1, 1] - X[0, 1] * X[1, 0];
                }
                else if (X.Length == 9)//Matris Determinanat Üçe Üçlük Hesabı | 3*3 |
                {
                    d = X[0, 0] * (X[1, 1] * X[2, 2] - X[1, 2] * X[2, 1]) -
                    X[0, 1] * (X[1, 0] * X[2, 2] - X[2, 0] * X[1, 2]) +
                    X[0, 2] * (X[1, 0] * X[2, 1] - X[1, 1] * X[2, 0]);
                }
                else
                {
                    HataYazdır("Tanımlı bir boyut yok");
                }

                return d;
            }
            else
            {
                HataYazdır("Kare Matris Gir");
                return d;
            }

        }

        #endregion


        #region Skaler Çarpım
        /// <summary>
        /// Skaler bir değer ile matirisi carpar
        /// </summary>
        /// <param name="X">Matris</param>
        /// <param name="c">Skaler değer</param>
        /// <returns>çarpım sonucu</returns>
        internal int[,] SkalerCarpim(int[,] X, int c = 0)
        {
            for (int i = 0; i < X.GetLength(0); i++)
            {
                for (int j = 0; j < X.GetLength(1); j++)
                {
                    X[i, j] = c * X[i, j];
                }
            }
            return X;
        }
        #endregion

        #region Matrisin elemanlarının toplamı
        /// <summary>
        /// Bir matristeki elemanların toplamını bulur
        /// </summary>
        /// <param name="X">Matris</param>
        /// <returns>Elemanların toplamı</returns>
        internal int ElemanlarinToplami(int[,] X)
        {
            int toplam = 0;
            for (int i = 0; i < X.GetLength(0); i++)
            {
                for (int j = 0; j < X.GetLength(1); j++)
                {
                    toplam += X[i, j];
                }
            }
            return toplam;
        }
        #endregion


        #region Simetrik Matris
        internal int[,] SimetrikMatrisOlustur(int boyut = 3, int min = 1, int max = 9)
        {
            int[,] X = DiyagonalMatris(boyut, min, max);
            for (int i = 1; i < X.GetLength(0); i++)
            {
                for (int j = 0; j <= i - 1; j++)
                {
                    X[i, j] = new Random().Next(min, max);
                    X[i, j] = X[i, j];
                }
            }

            return X;
        }

        //Gelen matris Simetrik mi
        internal bool SimetrikMi(int[,] X)
        {
            int[,] Y = Transpoz(X);


            return MatrisKarsilastir(X, Y);//Eşitmi
        }

        #endregion

        #region Köşegen matris mi?

        internal bool KosegenMatrisMi(int[,] X)
        {
            bool s = true;
            if (KareMatrisMi(X))
            {
                for (int i = 0; i < X.GetLength(0); i++)
                {
                    for (int j = 0; j < X.GetLength(1); j++)
                    {
                        if (!(X[i, j] == 0))
                        {
                            if (i != j)
                            {
                                s = false;
                                break;
                            }

                        }
                    }
                }
            }
            else
            {
                HataYazdır("Kare Matris Değildir");
                s = false;
            }
            return s;
        }

        #endregion
    }
}