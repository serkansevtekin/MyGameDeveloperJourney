using System;

namespace Programlama.IleriAlgoritma.Graph
{
    /// <summary>
    /// Graph veri yapısını temsil eden temel interface
    /// T tipindeki vertex'leri barındırır
    /// IEnumerable<T> implementasyonu ile foreach ile graph içindeki tüm vertex'leri gezebiliriz
    /// </summary>
    public interface IGraph<T> : IEnumerable<T>
    {
        //Graph'in ağırlıklı olup olmadığını döndür
        bool isWeightedGraph { get; }

        //Graph içindeki vertex sayısı
        int Count { get; }

        //Referans olarak kullanılacak bir vertex
        IGraphVertex<T> ReferanceVertex { get; }

        //Tüm vertex'leri enumerate eder
        IEnumerable<IGraphVertex<T>> VertecesAsEnumberable { get; }

        //Belirli vertex'e bağlı kenarların hedef anahtarını döndür
        IEnumerable<T> Edges(T key);

        //Graph'in derin kopyasını oluşutr
        IGraph<T> Clone();

        //Belirli bri vertex'in graph'te olup olmadığını kontrol eder
        bool ContainsVertex(T key);

        //Belirli vertex'i dödürür
        IGraphVertex<T> GetVertex(T key);

        // Kaynak ve hedef vertex arasında kenar oluğ olmadığını kontrol eder
        bool HasEdge(T source, T dest);


        //Yeni vertex ekler
        void AddVertex(T key);




        // Belirli vertex'i siler
        void RemoveVertex(T key);

        //Kaynak ve hedef arasondaki kenarı siler
        void RemoveEdge(T source, T dest);
    }

    /// <summary>
    /// Tek bir vertex (düğüm)'ü temsil eden interface
    /// IEnumerable<T> implementasyonu ile bu vertex'in koçşu vertex'lerini gezebiliriz
    /// </summary>
    public interface IGraphVertex<T> : IEnumerable<T>
    {
        T Key { get; } // Vertex'in benzersiz anahtarı / ID'si
        IEnumerable<IEdge<T>> Edges { get; } // Bu vertex'e bağlı tüm kenarlar  

        //IEdge<T> -> vertex'ler arasındaki kenar nesenesini dönür
        //IGraphVertex<T> key -> hangi hedef bertex'e giden kenarı bulmak istediğini söylüyorsun
        //metodun Görevi: Benim vertex’imden, parametre olarak verdiğin vertex’e giden kenarı bul ve IEdge<T> tipinde döndür
        IEdge<T> GetEdge(IGraphVertex<T> targetVertex);
    }

    /// <summary>
    /// Vertex'ler arasındaki kenarı temsil eden interface
    /// Yönlü ve yönsüz graph'larda vertex'leri birbirine bağlamak için kullanılır
    public interface IEdge<T>
    {
        T TargetVertexKey { get; } // Hedef vertex'in anahtarı (ID)
        IGraphVertex<T> TargetVertex { get; } // Hedef vertex nesnesi

        /// <summary>
        /// Kenarın ağırlığı (weight) döndüren generic method
        /// Örn: mesafe, maliyet, süre gibi kıyaslanabilir bir değer.
        /// </summary>
        /// <typeparam name="W">Ağırlık tipi, IComparable impelement eden bir tip olmalı</typeparam>
        /// <returns>Edge'nin ağırlığı</returns>
        W Weight<W>() where W : IComparable;
    }


    /// Yönlü graph
    public interface IDiGraph<T> : IGraph<T> // kalıtım ile herşeyi devraldık
    {
        // "new" ifadesi: aynı isimli özelliği yeni bir bersiyonla gizliyoruz (hide ediyoruz)
        new IDiGraphVertex<T> ReferanceVertex { get; }

        // "new" ifadesi: aynı isimli özelliği yeni bir bersiyonla gizliyoruz (hide ediyoruz)
        new IEnumerable<IDiGraphVertex<T>> VertecesAsEnumberable { get; }

  
    }


    public interface IDiGraphVertex<T> : IGraphVertex<T> // kalıtım ile herşeyi devraldık
    {
        IDiEdge<T> GetOutEdge(IDiGraphVertex<T> targetVertex); // Çıkan düğümleri referans al
        IEnumerable<IDiEdge<T>> OutEdges { get; }   // Her defasında çıkan bir kenar ver
        IEnumerable<IDiEdge<T>> InEdges { get; }   // Her defasında girem bir kenar ver
        int OutEdgesCount { get; }
        int InEdgesCount { get; }
    }


    public interface IDiEdge<T> : IEdge<T> // kalıtım ile herşeyi devraldık
    {

        // "new" ifadesi: aynı isimli özelliği yeni bir bersiyonla gizliyoruz (hide ediyoruz)
        new IDiGraphVertex<T> TargetVertex { get; }
    }
    
    /*
        IGraph<T> → tüm vertex’leri tutan “graph”

        IGraphVertex<T> → tek bir vertex ve onun komşuları

        IEdge<T> → vertex’leri birbirine bağlayan kenar

        örnek:
            - IGraph<T> -> Harita
            - IGraphVertex<T> -> Şehirler
            - IEdge<T> -> yollar
    */
}