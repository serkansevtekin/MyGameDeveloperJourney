using System;

namespace Programlama.IleriAlgoritma
{
    class VeriOrganizasyonuClass
    {
        public static void VeriOrganizasyonuRunMethod()
        {
            
            //Unsigned -> işaretsiz --> sadece pozizitif değerler 
            System.Console.WriteLine("Unsigned {0} | {1}", UInt16.MinValue, UInt16.MaxValue);
           
           //signed -> işaretli -> pozitif ve negatif değerler
            System.Console.WriteLine("signed {0} | {1}", Int16.MinValue, Int16.MaxValue);

        }




        #region byte and sbye hakkında bilgi

        private static void ByteAndSbyte()
        {
            /*  byte num1 = 8;
           sbyte num2 = -8; */


            //btye
            // 0 0 0 0 0 0 0 0 ->  0  -> min
            // 1 1 1 1 1 1 1 1 -> 255 -> max
            System.Console.WriteLine("Byte Min: {0} | Max {1}", byte.MinValue, byte.MaxValue);

            //sByte
            // 1 0 0 0 0 0 0 0 -> - 128 -> min
            // 0 1 1 1 1 1 1 1 ->   127 -> max
            System.Console.WriteLine("Byte Min: {0} | Max {1}", sbyte.MinValue, sbyte.MaxValue);

            System.Console.WriteLine();
        }

        private static void ByteAndSbyteHowToConvert()
        {
            var numbers = new String[]{
                "00000000",         // 0
                "00000001",         // 1 => 2^0 ---->>> 1
                "00000010",         // 2 => dikkate alınmıyor "0" , 2^1 = 2 ----> 2
                "00000011",         // 3 => 2^0 = 1 , 2^1 = 2 --->>> 1 + 2 = 3
                "00001011",         // 11 => 2^0 = 1, 2^1 = 2, dikkate alınmıyor "0", 2^3 = 8  ---->>> 1 + 2 + 8 = 11
                "10000000",         // 128 | - 128
                "10000001",         // 129 | - 128 + 1  = -127
                "10000011",         // 131 | - 128 + 3  = -125
                "10001111"          // 143 | - 128 + 15 = -113


            };

            System.Console.WriteLine("btye cevrilmiş");
            foreach (var item in numbers)
            {
                //2 -> 2'lik taban
                byte number = Convert.ToByte(item, 2);
                System.Console.WriteLine(number);
            }


            System.Console.WriteLine("\nsbtye cevrilmiş");
            foreach (var item in numbers)
            {
                //2 -> 2'lik taban
                sbyte number = Convert.ToSByte(item, 2);
                System.Console.WriteLine(number);
            }
        }




        #endregion


   #region  AÇIKLAMA
        /*  
=============================
📌 C# VERİ TİPLERİ TABLOSU
=============================

🔹 TAM SAYILAR
----------------------------------------------------------------------
Veri Tipi | Boyut   | Bit | İşaret | Aralık                                | Açıklama
----------------------------------------------------------------------
sbyte    | 1 byte  |  8  | signed | -128 … +127                          | Küçük negatif/pozitif tamsayı
byte     | 1 byte  |  8  | unsigned | 0 … 255                            | Küçük pozitif tamsayı
short    | 2 byte  | 16  | signed | -32,768 … +32,767                    | Orta boy tamsayı
ushort   | 2 byte  | 16  | unsigned | 0 … 65,535                         | Orta boy pozitif tamsayı
int      | 4 byte  | 32  | signed | -2,147,483,648 … +2,147,483,647      | En çok kullanılan tamsayı
uint     | 4 byte  | 32  | unsigned | 0 … 4,294,967,295                  | Büyük pozitif tamsayı
long     | 8 byte  | 64  | signed | -9,223,372,036,854,775,808 … 
                                    +9,223,372,036,854,775,807         | Çok büyük tamsayı
ulong    | 8 byte  | 64  | unsigned | 0 … 18,446,744,073,709,551,615     | Çok büyük pozitif tamsayı

🔹 ONDALIKLI SAYILAR
----------------------------------------------------------------------
Veri Tipi | Boyut   | Bit | Hassasiyet           | Aralık (yaklaşık)         | Açıklama
----------------------------------------------------------------------
float    | 4 byte  | 32  | ~7 basamak           | ±1.5e−45 … ±3.4e38       | Tek duyarlıklı kayan nokta
double   | 8 byte  | 64  | ~15-16 basamak       | ±5.0e−324 … ±1.7e308     | Çift duyarlıklı kayan nokta
decimal  | 16 byte | 128 | ~28-29 basamak       | ±1.0e−28 … ±7.9e28       | Finans/mali hesaplar için

🔹 MANTIKSAL VE KARAKTER
----------------------------------------------------------------------
Veri Tipi | Boyut   | Bit | Aralık               | Açıklama
----------------------------------------------------------------------
bool     | 1 byte* |  8* | true / false         | Mantıksal değer (*CLR’de genelde 1 byte)
char     | 2 byte  | 16  | Unicode (U+0000 … U+FFFF) | Tek karakter

🔹 NESNE / REFERANS TİPLERİ
----------------------------------------------------------------------
string   | Değişken | -   | -                   | Karakter dizisi (Unicode)
object   | Değişken | -   | -                   | Tüm tiplerin atası
var      | -        | -   | -                   | Derleyici tarafından çıkarılan tip
dynamic  | -        | -   | -                   | Çalışma zamanında belirlenen tip

=============================
NOTLAR:
- signed = işaretli (negatif + pozitif)
- unsigned = işaretsiz (sadece pozitif)
- float/double/decimal -> ondalıklı sayılar
- string -> metin tutar
- object -> tüm tiplerin temelidir
=============================
*/
        #endregion

    }
}