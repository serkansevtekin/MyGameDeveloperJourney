using System;

namespace CSharpProgramlama.IleriCSharpEgitimi
{
    public class VeriTipleri
    {
        public static void VeriTipleriRunMethod()
        {
            //Integer -> 32 bit 
            int number1 = 2147483647; // min: -2,147,483,648 , max: 2,147,483,647

            System.Console.WriteLine("Integer Number is {0}", number1);

            //Long -> 64 bit
            long number2 = 1111111111111111111; // min: -9,223,372,036,854,775,808 , max: 9,223,372,036,854,775,807
            System.Console.WriteLine("Long Number is {0}", number2);

            //Short -> 16 bit
            short number3 = 32767; // min: -32,768 , max: 32,767
            System.Console.WriteLine("Short Number is {0}", number3);

            //Byte -> 8 bit (0-255)
            byte number4 = 200;
            System.Console.WriteLine("Btye Number is {0}", number4);

            //Bool -> 1 bit (true / false)
            bool condition = true;
            System.Console.WriteLine("Boolean Value: {0}", condition);

            //Char -> 16 bit (Unicode karakter, ASCI code)
            char letter = 'A';
            System.Console.WriteLine("Char Value: {0}", letter);
            System.Console.WriteLine("Char ASCI Value: {0}", (int)letter);//Tür dönüşümü

            //Float -> 32 bit (ondalıklı sayı, yaklaşık 7 basamak doğruluk)
            float temperature = 36.6f;
            System.Console.WriteLine("Float Value: {0}", temperature);

            //Double -> 64 bit (ondalıklı sayı, yaklaşık 15 - 16 basamak doğruluk)
            double pi = 3.141592653589793;
            System.Console.WriteLine("Double Value: {0}", pi);

            //Decimal -> 128 bit (finansak işlemler için, 28 - 29 basamak doğruluk)
            decimal price = 199.9m;
            System.Console.WriteLine("Decimal Value: {0}", price);


            //Enum -> sabitler kümesi -> Magic String
            Days day = Days.Tuesday;
            System.Console.WriteLine("Enum Value: {0}", day);


            //Var -> tür çıkarımı ( derleyici türü otomatik belirler )
            var number7 = 10; //int
            number7 = 'A';//int değişkene char atıyoruz ve asci koda çeviriyor
            System.Console.WriteLine("Var number is Velue: {0}",number7);


        }
        //Enum -> sabitler kümesi -> Magic String
        enum Days { Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday }
    }
}