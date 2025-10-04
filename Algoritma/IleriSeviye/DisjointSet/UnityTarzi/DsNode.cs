using System;

namespace Programlama.IleriAlgoritma.DisjoinSet
{
    public class DsNode<T>
    {
        public T Value { get; set; } // Elemanın değeri
        public int Rank { get; set; } // Kümenin rank değeri

        public DsNode<T> Parent { get; set; } // Parent node referansı

        public DsNode(T value)
        {
            this.Value = value;
            this.Rank = 0;
            this.Parent = this; // Başlangıçta kendi parent'ı kendisi
        }
    }
}