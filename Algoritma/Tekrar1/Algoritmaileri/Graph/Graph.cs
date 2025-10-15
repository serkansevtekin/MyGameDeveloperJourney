using System;
using Programlama.IleriAlgoritma.Graph;

namespace Programlama.Tekrars1.Graph
{
    public class GraphClass
    {
        public static void GraphRun()
        {
            AdjacencyListGraphRunMet();
        }

        public static void AdjacencyListGraphRunMet()
        {
            AdjacencyListGraph<string> graph = new AdjacencyListGraph<string>();


            graph.AddEdge("A", "B");
            graph.AddEdge("A", "C");
            graph.AddEdge("B", "C");
            graph.AddEdge("C", "D");
            graph.AddEdge("D", "E");
            graph.AddEdge("D", "F");
            graph.AddEdge("D", "G");
            graph.AddEdge("D", "H");

            graph.PrintGraph();






            System.Console.WriteLine("Node count: " + graph.NodeCount);
            System.Console.WriteLine("Edge count: " + graph.EdgeCount);

            System.Console.WriteLine()
            ;
            System.Console.WriteLine("D düğümü silindi");

            //D ve alttaki nodeları sil
            graph.RemoveEdgeRecursive("C", "D");

            graph.PrintGraph();


            System.Console.WriteLine($"Node varmı: {graph.HasNode("D")}");
            System.Console.WriteLine($"Edge varmı: {graph.HasEdge("B", "C")}");

            System.Console.WriteLine("Çocukları döndür");
            List<string>? list = graph.GetNode("A");
            foreach (var item in list!)
            {
                System.Console.WriteLine(item);
            }

            System.Console.WriteLine();

            foreach (var node in graph)
            {
                System.Console.WriteLine("Node: " + node);

            }


            graph.Clear();

        }


    }

    #region Graph Tanım
    /*
    *Graph, bir nesne koleksiyonunun ve bu nesneler arasındaki temsil eden bir veri yapısıdır
    * Temel Kavramlar
        - Node (Vertex/Düğüm): Grafın temel elemanı, üzerinde veri taşıyabilir
        - Edge (Kenar/Bağlantı): Nodlar arasındaki bağlantı veya  ilişki
        - Direction / Undirection:
            - Direction (Yönlü): A -> B gibi tek yönlü bağlantı
            - Undirection (Yönsüz): A <-> B gibi çift yönlü bağlantı
      
    * Graph Temsilleri
        Grafı programlamada genelde iki şekilde tutarız:
            a) Adjacency List (Komşuluk Listesi)
                - Her nodu'un bağlı olduğu diğer node'ları bir listede tutarız
                - Hafıza verimli (özellikle seyrek grafiklerde)
                - Arama işlemleri biraz daha uzun
                - Mobil oyun gibi hafıza kısıtlı durumlarda daha iyidir

            b) Adjacency Matrix (Komşuluk Matrisi)
                - Node sayısı N is N*N boyutunda bir matrsi oluştururuz
                - matris[i][j] = 1 -> i'den j'ye kenar var
                - Bellek kullanımı yüksek (özellikle seyrek grafiklerde)
                
    Amaç:
        - Nesneler arasındaki ilişkileri saklamak
        - ilişkileri sorgulamak veya gezmek 
        - Alt node'ları veya bağlantıları yönetmek (ekelem , silme , traversal)

    Örnek:
        Unity’de sahnedeki objeleri parent-child hiyerarşisi olarak tutmak.
        Oyun haritasındaki bölgeler ve yollar.
        Karakterler veya düşmanlar arasındaki etkileşim grafiği.
        
    Kısaca: Graph → nesneler + nesneler arasındaki bağlantılar + ilişkileri yönetme aracı.
            
    */
    #endregion
}