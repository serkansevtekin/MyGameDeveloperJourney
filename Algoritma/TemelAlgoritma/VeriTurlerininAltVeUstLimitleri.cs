using System;
namespace Programlama.VeriTurlerininAltVeUstLimitleriNameSpace
{
    class VeriTurlerininAltVeUstLimitleriClass
    {
        public static void VeriTurleriVeLimitleriMain()
        {
            // 8 - bit integer
            System.Console.WriteLine(nameof(SByte));//nameof ilgili veri sınıfının ismini verecek
            System.Console.WriteLine($"Alt Limit     : {SByte.MinValue,20}");//sByte.MinValue -> sByte nin alabildiği en az değeri gösterir. "20" karakter boşlık bırak

            System.Console.WriteLine($"Üst Limit     : {SByte.MaxValue,20}");//sByte.MaxValue -> sByte nin alabildiği en fazla değeri gösterir. "20" karakter boşlık bırak

            System.Console.WriteLine($"Boyut    :{sizeof(SByte),20}");//sizeof(SByte) -> değişken tipi hafızada nekadar byte alan kaplıyor. "20" karakter boşlık bırak

            System.Console.WriteLine();
            Console.ReadKey();

            //Unsigned 8 - bit integer
            System.Console.WriteLine(nameof(Byte));//nameof ilgili veri sınıfının ismini verecek
            System.Console.WriteLine($"Alt Limit     : {Byte.MinValue,20}");//Byte.MinValue -> Byte nin alabildiği en az değeri gösterir. "20" karakter boşlık bırak
            System.Console.WriteLine($"Üst Limit     : {Byte.MaxValue,20}");//Byte.MaxValue -> Byte nin alabildiği en fazla değeri gösterir. "20" karakter boşlık bırak
            System.Console.WriteLine($"Boyut    :{sizeof(Byte),20}");//sizeof(Byte) -> değişken tipi hafızada nekadar byte alan kaplıyor. "20" karakter boşlık bırak
            System.Console.WriteLine();
            Console.ReadKey();


            //Signed 16 - bit integer
            System.Console.WriteLine(nameof(Int16));//nameof ilgili veri sınıfının ismini verecek
            System.Console.WriteLine($"Alt Limit     : {Int16.MinValue,20}");//Int16.MinValue -> Int16 nin alabildiği en az değeri gösterir. "20" karakter boşlık bırak
            System.Console.WriteLine($"Üst Limit     : {Int16.MaxValue,20}");//Int16.MaxValue -> Int16 nin alabildiği en fazla değeri gösterir. "20" karakter boşlık bırak
            System.Console.WriteLine($"Boyut    :{sizeof(Int16),20}");//sizeof(Int16) -> değişken tipi hafızada nekadar byte alan kaplıyor. "20" karakter boşlık bırak
            System.Console.WriteLine();
            Console.ReadKey();

            //Unsigned 16 - bit integer
            System.Console.WriteLine(nameof(UInt16));//nameof ilgili veri sınıfının ismini verecek
            System.Console.WriteLine($"Alt Limit     : {UInt16.MinValue,20}");//UInt16.MinValue -> UInt16 nin alabildiği en az değeri gösterir. "20" karakter boşlık bırak
            System.Console.WriteLine($"Üst Limit     : {UInt16.MaxValue,20}");//UInt16.MaxValue -> UInt16 nin alabildiği en fazla değeri gösterir. "20" karakter boşlık bırak
            System.Console.WriteLine($"Boyut    :{sizeof(UInt16),20}");//sizeof(UInt16) -> değişken tipi hafızada nekadar byte alan kaplıyor. "20" karakter boşlık bırak
            System.Console.WriteLine();
            Console.ReadKey();

            //Signed 32 - bit integer
            System.Console.WriteLine(nameof(Int32));//nameof ilgili veri sınıfının ismini verecek
            System.Console.WriteLine($"Alt Limit     : {Int32.MinValue,20}");//Int32.MinValue -> Int32 nin alabildiği en az değeri gösterir. "20" karakter boşlık bırak
            System.Console.WriteLine($"Üst Limit     : {Int32.MaxValue,20}");//Int32.MaxValue -> Int32 nin alabildiği en fazla değeri gösterir. "20" karakter boşlık bırak
            System.Console.WriteLine($"Boyut    :{sizeof(Int32),20}");//sizeof(Int32) -> değişken tipi hafızada nekadar byte alan kaplıyor. "20" karakter boşlık bırak
            System.Console.WriteLine();
            Console.ReadKey();

            //Unsigned 32 - bit integer
            System.Console.WriteLine(nameof(UInt32));//nameof ilgili veri sınıfının ismini verecek
            System.Console.WriteLine($"Alt Limit     : {UInt32.MinValue,20}");//UInt32.MinValue -> UInt32 nin alabildiği en az değeri gösterir. "20" karakter boşlık bırak
            System.Console.WriteLine($"Üst Limit     : {UInt32.MaxValue,20}");//UInt32.MaxValue -> UInt32 nin alabildiği en fazla değeri gösterir. "20" karakter boşlık bırak
            System.Console.WriteLine($"Boyut    :{sizeof(UInt32),20}");//sizeof(UInt32) -> değişken tipi hafızada nekadar byte alan kaplıyor. "20" karakter boşlık bırak
            System.Console.WriteLine();
            Console.ReadKey();


            /* DOUBLE */
            System.Console.WriteLine(nameof(Double));//nameof ilgili veri sınıfının ismini verir
            System.Console.WriteLine($"Alt Limit     :{Double.MinValue,20}");//Double.MinValue -> Double nin alabileceği en az değeri gösterir. "20" karakter boşluk bırak
            System.Console.WriteLine($"Üst Limit     :{Double.MaxValue,20}");//Double.MaxValue -> Double nin alabileceği en fazla değeri gösterir. "20" karakter boşluk bırak            
            System.Console.WriteLine($"Boyut     :{sizeof(Double),20}");//sizeof(Double) -> değişken tipi hafızada kaç byte alan kaplıyor. "20" karakter boşluk bırak.
            System.Console.WriteLine();
            Console.ReadKey();



        }












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