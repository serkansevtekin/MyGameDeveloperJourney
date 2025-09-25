using System;

namespace Programlama.IleriAlgoritma
{
    public class SinglyLinkedListClass
    {
        //Tek Yönlü Bağlı Liste
        public static void SinglyLinkedListRunMain()
        {

        }
     }


    #region Node Design (Düğüm Tasarımı)
    partial class NodeDesign<T>
    {
        public NodeDesign<T>? Next { get; set; } // Sonraki Düğüme Referans
        public T Value { get; set; } // Veriyi Tutar

        public NodeDesign(T value)
        {
            Value = value;
       
        }
        public override string ToString() => $"{Value}";
    }
    #endregion



    #region SinglyLinkedList Tanımı



    /*  Singly Linked Lists

    - Temel İşlevler

        * Listeye ekleme
            *-* Liste başına ekleme yapma
            *-* Kuyruğa ekleme (liste sonuuna) ekleme yapma
            *-* Araya ekleme yapma

        * Listede dolaşma
        
        * Listede silme

    
    */
    #endregion
}