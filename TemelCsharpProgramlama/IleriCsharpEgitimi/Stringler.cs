using System;

namespace CSharpProgramlama.IleriCSharpEgitimi
{
    public class Strings
    {
        public static void StringsRun()
        {
            //TemelString();
            StringMethods();
        }

        private static void StringMethods()
        {
            string sentence = "My name is Serkan Sevtekin";

            var result = sentence.Length; // cümle kaç karakterden oluşur
            var result2 = sentence.Clone(); // bir clonunu oluşturur
            sentence = "my name is Seko Kededasda  Peace ";
            bool result3 = sentence.EndsWith("n");
            bool result4 = sentence.StartsWith("My name");
            var result5 = sentence.IndexOf("i");
            var result6 = sentence.IndexOf(" ");
            var result7 = sentence.LastIndexOf(" ");
            var result8 = sentence.Insert(0, "Hello, ");
            var result9 = sentence.Substring(2,5);
            var result10 = sentence.ToLower();
            var result11 = sentence.ToUpper();
            var result12 = sentence.Trim();
            var result13 = sentence.TrimStart();
            var result14 = sentence.TrimEnd();
            var result15 = sentence.Replace(" ", "-");
            var result16 = sentence.Remove(2,5);


           System.Console.WriteLine(result16);
        }

        private static void TemelString()
        {
            string city = "Ankara";
            //System.Console.WriteLine(city[0]);
            foreach (var item in city)
            {
                System.Console.WriteLine(item);
            }

            string city2 = "İstanbul";
            //string result = city + " " + city2;
            System.Console.WriteLine("{0} {1}", city, city2);//  performanslı
            System.Console.WriteLine($"{city} {city2}"); // performanslı
        }
    }
}