using System;

namespace CSharpProgramlama.IleriCSharpEgitimi
{
    public class ReferenceAndValueTypeClass
    {
        public static void ReferenceAndValueTypeRun()
        {
            //Value Type (Değer Tip) Örnek
            int a = 10;
            int b = a;
            b = 30;
            System.Console.WriteLine(a); // 10 -> değişmez
            System.Console.WriteLine(b);// 30


        
            //Reference Type (Referans Tip) Örnek
            //1. Array oluşturuluyor
            int[] numbers1 = { 1, 2, 3 };
            int[] numbers2 = { 10, 22, 33 };
            //2. Referans kopyalama
            numbers2 = numbers1;

            //3. numbers üzerinden değişiklik yapılıyor
            numbers2[0] = 99;

            //4. numbers1 de değişti, çünkü aynın nesneye işaret ediyor
            System.Console.WriteLine("numbers1[0] = {0}", numbers1[0]);
            System.Console.WriteLine("numbers2[0] = {0}",numbers2[0]);
            
        }
    }

    #region Tanım
    /*
    1. Value Type (Değer Tip)
        * Stack üzerinde saklanır (küçük veri için hızlı).
        * Değer kopyalanır, biri değişirse diğerleri etkilenmez.
        * Örnek tipler: int, float, double, bool, sturct, enum.

    2. Reference Type (Referans Tip)
        * Heap üzerinde saklanır, stack üzerinde referans (adres) tutulur.
        * Referans kopyalanırsa, iki değişken anı nesneye işaret eder -> biri değişirse diğeri etkilenir.
        * Örnek tipler: calss, string, object, array, delegate.


    | Özellik         | Value Type               | Reference Type          |
    | --------------- | ------------------------ | ----------------------- |
    | Bellek yeri     | Stack                    | Heap + Stack (referans) |
    | Kopyalandığında | Değer kopyalanır         | Referans kopyalanır     |
    | Null değeri     | Alamaz                   | Alabilir                |
    | Örnekler        | int, float, bool, struct | class, string, array    |

    */
    #endregion
}