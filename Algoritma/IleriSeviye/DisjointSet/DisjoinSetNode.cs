using System;

namespace Programlama.IleriAlgoritma.DisjoinSet
{
    /// <summary>
    /// Disjoint Set (Union-Find) yapısında bir düğüm temsil eder.
    /// Generic tip sayesinde herhangi bir tipi saklayabilir.
    /// </summary>
    /// <typeparam name="T">Düğümün saklanacağı veri tipi</typeparam>
    public class DisjoinSetNode<T>
    {
        /// <summary>
        /// Düğümün taşıdığı değer. Örneğin bir elemanın ID'si veya obje referansı.
        /// Nullable, yani başlangıçta boş olabilir
        /// </summary>
        public T? Value { get; set; }

        /// <summary>
        /// Ağacın yüksekliği. Union (birleştirme) sırasında dengeli ağaç oluşturmak için kullanılır
        /// </summary>
        public int Rank { get; set; }

        /// <summary>
        /// Düğümün bağlı olduğu kök düğümü. Başta kendisini işaret eder.
        /// Path compression uygulanırken güncellenir.
        /// </summary>
        public DisjoinSetNode<T>? Parent { get; set; }

        //Parametresiz ctor. Value null, Rank 0, Parent null olarak başlar
        public DisjoinSetNode()
        {

        }

        //Sadece değer verilen ctor. Value düğümün değeri, Rank 0 ve Parent null olarak başlar
        public DisjoinSetNode(T? value)
        {
            Value = value;
            Rank = 0;
        }

        /// <summary>
        /// Değer ve rank verilen ctor
        /// Rank, union sırasında kullanılacak ağacın yüksekliğini belirler
        /// </summary>
        /// <param name="value">Düğümün değeri</param>
        /// <param name="rank">Ağacın başlangıç yüksekliği</param>
        public DisjoinSetNode(T? value, int rank)
        {
            Value = value;
            Rank = rank;
        }


        /// <summary>
        /// Düğümün string olarak temsilini döndürür
        /// Örneğin, konsola yazdırmak için kullanılabilir
        /// </summary>
        /// <returns>Düğümün Value değerini string olarak döndürür</returns>
        public override string ToString() => $"{Value}";
    }

    /*

    Standart Node tabanlı Disjoint Set tasarımı.

 Özellikleri:

    Generic (<T>) → her tip veri ile kullanılabilir.

    Value → eleman verisi.

    Rank → dengeli Union için ağaç yüksekliği.

    Parent → kök node referansı.

    Constructor’lar → başlangıçta değer ve rank ayarlamak için esnek.

    ToString() → debug ve konsol çıktısı için.

Mobil oyunlarda genelde array tabanlı versiyon tercih edilir, ama eğitim ve OOP anlayışı için bu node     tabanlı standarttır.
      */
}