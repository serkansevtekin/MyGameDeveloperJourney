using System;
using System.Reflection;

namespace CSharpProgramlama.IleriCSharpEgitimi.Reflection
{
    class ReflectionClass
    {
        public static void ReflectionRun()
        {
            /*   DortIslem dortIslem = new DortIslem(2, 3);
              System.Console.WriteLine(dortIslem.Tolpla2());
              System.Console.WriteLine(dortIslem.Tolpla(2, 3)); */

            var tip = typeof(DortIslem);

            /* DortIslem dortIslem = (DortIslem)Activator.CreateInstance(tip,10,7)!;
            System.Console.WriteLine(dortIslem.Tolpla(3, 5));
           System.Console.WriteLine(dortIslem.Tolpla2()); */

            var instance = Activator.CreateInstance(tip, 6, 7);
            System.Console.WriteLine(instance!.GetType().GetMethod("Tolpla2")!.Invoke(instance,null));
            var metodlar = tip.GetMethods();
            foreach (var info in metodlar)
            {
                System.Console.WriteLine("Metod adı: {0}", info.Name);
                foreach (var item in info.GetParameters())
                {
                    System.Console.WriteLine("Parametre: {0}", item.Name);
                }
                foreach (var attribue in info.GetCustomAttributes())
                {
                    System.Console.WriteLine(attribue.GetType());
                }
            }
        }
    }

    public class DortIslem
    {

        private int _sayi1;
        private int _sayi2;
        public DortIslem(int sayi1, int sayi2)
        {
            _sayi1 = sayi1;
            _sayi2 = sayi2;
        }

        public int Tolpla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }

        public int Carp(int sayi1, int sayi2)
        {
            return sayi1 * sayi2;
        }

        public int Tolpla2()
        {
            return _sayi1 + _sayi2;
        }

        [MethodName("Carpma")]
        public int Carp2()
        {
            return _sayi1 * _sayi2;



        }
    }

    public class MethodNameAttribute : Attribute
    {


        public MethodNameAttribute(string name)
        {
          
        }
    }
}