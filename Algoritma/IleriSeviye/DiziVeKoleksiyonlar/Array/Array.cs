using System;
using System.Collections;

namespace Programlama.IleriAlgoritma
{ // Bir diziyi baştan kendimiz yazma

    //IEnumerable<T> -> koleksiyona numaralandırma yeteneği
    //IClonable -> ilgili öğenin bir kopyasını oluşturup dönüş yapa bilirsiniz
    public class Array<T> : IEnumerable<T>, ICloneable
    {
        private T[] InnerList;

        //private set; -> dışardan sadece okunabilir. Sadece class içinden yazıla bilir
        public int Count { get; private set; }

        //Getter var, setter yok
        public int Capacity => InnerList.Length;

        public Array()
        {
            InnerList = new T[2];// eleman sayısı belli değilse başta 2 elemanlı dizi yap
            Count = 0;
        }

        //eleman ekleme

        public void Add(T item)
        {
            if (InnerList.Length == Count)  DoubleArray();

            InnerList[Count] = item;
            Count++;
        }
        //dizi sonundaki elemanı silen
        public T Remove()
        {
            if (Count == 0)
            {
                throw new Exception("There is no more item to be removed from the array");
            }
            var temp = InnerList[Count - 1];
            Count--;
            return temp;
        }

        //Bu metot dizinin kapasitesini iki katına çıkarmak için yazılmış.
        private void DoubleArray()
        {
            //Mevcut dizinin iki kat uzunlukta yeni bir dizi oluştur
            var temp = new T[InnerList.Length * 2];

            //Eski dizideki tüm elemanları yeni diziye kopyala
            Array.Copy(InnerList, temp, InnerList.Length);

            //InnerList artık yeni (daha büyük) diziye işaret etsin
            InnerList = temp;

        }

        public object Clone()
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}