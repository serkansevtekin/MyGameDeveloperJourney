using System;

namespace Programlama.IleriAlgoritma
{
    //Generic tipinde (T), ikili ağaç düğümünü temsil eden sınıf
    public class NodeBinaryTree<T>
    {
        //Düğümün tutulduğu yer
        public T? Value { get; set; }

        //Sol alt ağacı (Left child)
        public NodeBinaryTree<T>? Left { get; set; }

        //Sağ alt ağacı (Right child)
        public NodeBinaryTree<T>? Right { get; set; }

        //Parametresiz kurucu metot (Boş düğüm oluşturur)
        public NodeBinaryTree() { }

        //Parametreli kurucu metot (İlk değer atanarak düğüm oluşur)
        public NodeBinaryTree(T? value)
        {
            Value = value;
        }

        //Nesneyi stringe çevirmek için (debu veya ekrana yazırmada kolaylık sağlar)
        public override string ToString() => $"{Value}";
    }
}