using System;

namespace CSharpProgramlama.TemelCsharpNameSpace
{
    public class DosyaYonetimiCLass
    {
        public static void DosyaYonetimiRunMet()
        {
            /*  string path = Directory.GetCurrentDirectory();
             string source = $"{path}/TemelCsharp/deneme.txt";
             DosyadanVeriOkuma(source); */

            // DosyayaYazmaEkleme();

            //KlasorlerleCalisma();

            DosyaKolasorlerCalisma();

        }

        private static void DosyaKolasorlerCalisma()
        {
            string rootPath = Directory.GetCurrentDirectory();
            /* string[] dirs = Directory.GetDirectories(rootPath, "*", SearchOption.TopDirectoryOnly);

            foreach (var dir in dirs)
            {
                System.Console.WriteLine(dir);
            } */

            string[] files = Directory.GetFiles(rootPath, "*.cs", SearchOption.AllDirectories);
            foreach (var item in files)
            {

                //  System.Console.WriteLine(item);
                // System.Console.WriteLine(Path.GetFileNameWithoutExtension(item));

                var info = new FileInfo(item);
                System.Console.WriteLine($"{info.Name}: {info.Length}");
            }
        }

        private static void KlasorlerleCalisma()
        {

            string path = Directory.GetCurrentDirectory();
            System.Console.WriteLine(path);
        }

        private static void DosyayaYazmaEkleme()
        {
            /*   using (StreamWriter sw = File.CreateText("TemelCsharp/deneme.txt"))
              {
                  sw.WriteLine("merhaba");
                  sw.WriteLine("Kleeeee");
                  sw.WriteLine("Akademi");
              } */
            using (StreamWriter sw = File.AppendText("TemelCsharp/deneme.txt"))
            {
                sw.WriteLine("Hellow");

            }
        }

        private static void DosyadanVeriOkuma(string source)
        {
            /*          
                          StreamReader sr = File.OpenText(source);
                                    var s = "";
                                    while ((s = sr.ReadLine()) != null)
                                    {
                                        System.Console.WriteLine(s);
                                    } */

            /*    string sonuc = File.ReadAllText(source);
               System.Console.WriteLine(sonuc); */

            /*     string[] sonuc = File.ReadAllLines(source);
                System.Console.WriteLine(sonuc[0]);
                System.Console.WriteLine(sonuc[2]); */

            string[] sonuc = File.ReadAllLines(source);
            foreach (var item in sonuc)
            {
                System.Console.WriteLine(item);
            }
        }
    }
}