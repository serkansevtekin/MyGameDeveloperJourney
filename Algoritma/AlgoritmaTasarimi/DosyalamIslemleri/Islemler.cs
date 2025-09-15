using System;
using System.IO;

namespace Programlama.AlgoritmaTasarimi
{
    class FILE
    {
        public static void FILEMainMethod()
        {
            DosyaIslemler.StreamReader();
            DosyaIslemler.StreamWrite();
            DosyaIslemler.DosyayiYazdir("Adlar.txt", ["AlgoritmaTasarimi", "DosyalamIslemleri"]);
        }



    }

    struct DosyaIslemler
    {
        #region StramReader | okuma ve ekrana yazdırma

        internal static void StreamReader()
        {

            //1.YOl en iyi yol

            try
            {
                //Çalışma dizini: VS Code terminalini açtığın klasör
                string baseDir = Directory.GetCurrentDirectory();

                //Dosyanın proje içindeki göreli yolu
                string dosyaYol = Path.Combine(
                    baseDir,
                    "AlgoritmaTasarimi",
                    "DosyalamIslemleri",
                    "Rakamlar.txt"
                    );

                //StreamReader kullanarak dosyayı açıyoruz
                using (StreamReader sr = new StreamReader(dosyaYol))
                {
                    string? line; //Dosyadan okunan her satırı tutacak değişken

                    //ReadLine() ile dosyayı satır satır okuyoruz
                    //Satır null döndüğünde dosyanın sonuna gelmiş oluruz
                    while ((line = sr.ReadLine()) != null)
                    {
                        //Okunan satırı consola yazdırıyoruz
                        System.Console.WriteLine(line);
                    }
                }// using blogu sonunda StreamReader otomatik olarak kapanır ve dosya serbest bırakılır
            }
            catch (System.Exception ex)
            {

                System.Console.WriteLine("Hata: " + ex.Message);
            }

            /*
            //2. YOl
              try
             {
                 //Dinamik konum kontrolü
                 string[] yol = Directory.GetCurrentDirectory().Split('\\');
                 string dosyaYol = "";
                 for (int i = 0; i < yol.Length - 3; i++)
                 {
                     dosyaYol += yol[i] + "\\";

                 }

                 dosyaYol += "AlgoritmaTasarimi/DosyalamIslemleri/Rakamlar.txt";

                 // dosya okuma ve ekrana yazma
                 using (StreamReader sr = new StreamReader(dosyaYol))
                 {
                     string? line;
                     while ((line = sr.ReadLine()) != null)
                     {
                         System.Console.WriteLine(line);
                     }
                 }
             }
             catch (Exception ex)
             {

                 System.Console.WriteLine(ex.Message);
             } */



        }
        #endregion

        #region StreamWriter | dosya üzerine yazma
        internal static void StreamWrite()
        {
            try
            {
                //Adların bulunduğu dizi
                string[] adlar = new string[] { "Zara", "Ayca", "Mehmet", "Selim" };

                //Çalışma dizini
                string? baseDir = Directory.GetCurrentDirectory();

                //Dosyanın proje içindeki göreli yolu
                string? dosyaYolu = Path.Combine(
                    baseDir,
                    "AlgoritmaTasarimi",
                    "DosyalamIslemleri",
                    "Adlar.txt"
                );

                //Dosyayı aç veya yoksa oluştur, yazma işlemini yap
                using (StreamWriter sw = new StreamWriter(dosyaYolu))
                {
                    //adlar dizisinin tüm elemanlarını gez ve satır satır dosyaya yaz
                    foreach (string item in adlar)
                    {
                        sw.WriteLine(item);
                    }
                }// using bloğu sonunda StreamWriter kapanır ve dosya kaydedilir
            }
            catch (System.Exception ex) // hata varsa mesaj ver
            {

                System.Console.WriteLine("Hata: " + ex.Message);
            }
        }
        #endregion


        #region Verilen dosya adına göre dosyayı ekrana yazan kod
        internal static void DosyayiYazdir(string dosyaAdi, params string[] dosus)// params kullanılarak ta yapıla bilir performans aynı. Method overloading 2 method olur performans kaybı
        {

            try
            {
                string? ustYollar = "", dosyaYolu = "", baseDir = Directory.GetCurrentDirectory();



                if (string.IsNullOrEmpty(dosyaAdi) && (dosus.Length == 0))
                {
                    System.Console.WriteLine("Dosya yolu dizini  ve dosya adı boş");
                    return;

                }
                if (dosus.Length > 0)
                {
                    ustYollar = Path.Combine(dosus);
                    dosyaYolu = Path.Combine(baseDir, ustYollar, dosyaAdi);
                }
                else
                {


                    dosyaYolu = Path.Combine(baseDir, dosyaAdi);
                }
                System.Console.WriteLine(dosyaYolu);

                using (StreamReader sr = new StreamReader(dosyaYolu))
                {
                    string? line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        System.Console.WriteLine(line);
                    }
                }

            }
            catch (System.Exception ex)
            {

                System.Console.WriteLine("Hata: " + ex.Message);
            }
        }
        #endregion
    }




}