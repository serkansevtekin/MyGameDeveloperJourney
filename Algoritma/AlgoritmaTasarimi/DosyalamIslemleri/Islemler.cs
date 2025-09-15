using System;
using System.IO;
using System.Text;

namespace Programlama.AlgoritmaTasarimi
{
    class FILE
    {
        public static void FILEMainMethod()
        {

            /* DosyaIslemler.StreamReader();
            DosyaIslemler.StreamWrite(); */
          //  string KaynakYol = DosyaIslemler.DinamikYol("Adlar.txt", ["AlgoritmaTasarimi", "DosyalamIslemleri"]);
            string HedefYol = DosyaIslemler.DinamikYol("Rakamlar.txt", ["AlgoritmaTasarimi", "DosyalamIslemleri"]);
         //   DosyaIslemler.DosyaKopyalama(KaynakYol, HedefYol);

            //  DosyaIslemler.VarOlanDosyayaEklemeYap(KaynakYol);

            DosyaIslemler.DosyaSil(HedefYol);
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

        #region Dinamik Yol
        internal static string DinamikYol(string dosyaAdi, params string[] dosyaEkYol)
        {
            string? dosyaYol = "", dosyaUstYol = "";
            try
            {



                string baseDir = Directory.GetCurrentDirectory();
                if (string.IsNullOrEmpty(dosyaAdi))
                {

                    return "Dosya yolu dizini  ve dosya adı boş";
                }
                if (dosyaEkYol.Length > 0 && dosyaEkYol != null)
                {
                    dosyaUstYol = Path.Combine(dosyaEkYol);
                    dosyaYol = Path.Combine(baseDir, dosyaUstYol, dosyaAdi);
                }
                else
                {
                    dosyaYol = Path.Combine(baseDir, dosyaAdi);
                }

            }
            catch (System.Exception ex)
            {

                System.Console.WriteLine("Hata: " + ex.Message);
            }
            return dosyaYol;
        }
        #endregion

        #region File Stram | Var olan bir dosyaya ekleme yapma
        internal static void VarOlanDosyayaEklemeYap(string SabitYol)
        {
            try
            {

                while (true)
                {
                    System.Console.WriteLine("\nDosyayı kaydetmek için bir isim girin");
                    string ad = Console.ReadLine() ?? "";
                    if (ad.Equals("cikis", StringComparison.OrdinalIgnoreCase))
                    {
                        break;
                    }
                    if (!string.IsNullOrWhiteSpace(ad))
                    {
                        File.AppendAllText(SabitYol, ad + Environment.NewLine);
                    }
                }

            }
            catch (System.Exception ex)
            {

                System.Console.WriteLine(ex.Message);
            }

        }
        #endregion

        #region File Info
        internal static void FInfo(string yol)
        {
            string dosyaYolu = yol;
            var fi = new FileInfo(dosyaYolu);

            System.Console.WriteLine(fi.FullName);
            System.Console.WriteLine(fi.Length);
            System.Console.WriteLine(fi.Extension);
            System.Console.WriteLine(fi.CreationTime);
            System.Console.WriteLine(fi.LastAccessTime);
            System.Console.WriteLine(fi.Name);
        }
        #endregion

        #region Dosya Kopyalama
        /// <summary>
        /// Dosya kopyalama işlemini gerçekleştirir
        /// </summary>
        /// <param name="kaynak">Kaynak dosya yolu</param>
        /// <param name="hedef">Hedef dosya yolu</param>
        internal static void DosyaKopyalama(string kaynak, string hedef)
        {
            try
            {
                /*  FileInfo fi = new FileInfo(kaynak);
                 fi.CopyTo(hedef);
                 Console.Write("{0} kayndaklı dosya {1} kopyalandi", kaynak, hedef); */

                string icerik = File.ReadAllText(kaynak);
                File.AppendAllText(hedef, icerik);
                Console.Write("{0} kayndaklı dosya {1} kopyalandi", kaynak, hedef);
            }
            catch (System.Exception ex)
            {

                System.Console.WriteLine("Hata: " + ex.Message);
            }
        }
        #endregion


        #region Dosya Silme
        internal static void DosyaSil(string kaynak)
        {
            try
            {
                FileInfo fi = new FileInfo(kaynak);
                if (fi.Exists)
                {
                    fi.Delete();
                    System.Console.WriteLine("Dosya silindi");
                }
                else System.Console.WriteLine("Dosya Menvcut değil");
            }
            catch (System.Exception ex)
            {

                System.Console.WriteLine($"{ex.Message}");
            }
        }
        #endregion
    }




}