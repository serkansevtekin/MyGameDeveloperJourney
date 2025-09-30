using System;

namespace Programlama.IleriAlgoritma.Tree
{
    //Generic tipinde (T), ikili ağaç düğümünü temsil eden sınıf
    public class NodeTree<T>
    {
        //Düğümün tutulduğu yer
        public T? Value { get; set; }

        //Sol alt düğüm
        public NodeTree<T>? Left { get; set; }

        //Sağ alt düğüm
        public NodeTree<T>? Right { get; set; }

        //Parametresiz kurucu metot (Boş düğüm oluşturur)
        public NodeTree() { }

        //Parametreli kurucu metot (İlk değer atanarak düğüm oluşur)
        public NodeTree(T? value)
        {
            Value = value;
        }

        //Nesneyi stringe çevirmek için (debu veya ekrana yazırmada kolaylık sağlar)
        public override string ToString() => $"{Value}";
    }
}