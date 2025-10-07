using System;

namespace Programlama.IleriAlgoritma.Graph
{
    public class GraphRunClass
    {
        public static void GraphRunMethod()
        {
            // UnWeightedGraph();
            // WeightedGraph();

            //  UnWeightDiGraph();
            // WeightedDiGraph();
            DFSRun();

        }

        private static void DFSRun()
        {
            var graph = new Graph<int>();
            for (int i = 0; i <= 11; i++)
            {
                graph.AddVertex(i);
            }
            graph.AddEdge(0, 1);
            graph.AddEdge(1, 4);
            graph.AddEdge(0, 4);
            graph.AddEdge(0, 2);
            graph.AddEdge(2, 5);
            graph.AddEdge(2, 10);
            graph.AddEdge(2, 9);
            graph.AddEdge(10, 11);
            graph.AddEdge(9, 11);

            graph.AddEdge(5, 7);
            graph.AddEdge(5, 6);
            graph.AddEdge(5, 8);
            graph.AddEdge(7, 8);

            var algoritmaSearch = new DepthFirst<int>();
            System.Console.WriteLine("{0}", algoritmaSearch.Find(graph, 23) ? "Yes" : "No"); ;


        }


        private static void WeightedDiGraph()
        {
            var graph = new WeightedDiGraph<char, double>(new char[] { 'A', 'B', 'C', 'D', 'E' });
            graph.AddEdge('A', 'C', 12);
            graph.AddEdge('A', 'D', 60);
            graph.AddEdge('B', 'A', 10);
            graph.AddEdge('C', 'D', 32);
            graph.AddEdge('C', 'B', 20);
            graph.AddEdge('E', 'A', 7);


            System.Console.WriteLine("Is an edge between A and B? {0}", graph.HasEdge('A', 'B') ? "Yes" : "No!");
            System.Console.WriteLine("Is an edge between B and A? {0}", graph.HasEdge('B', 'A') ? "Yes" : "No!");



            foreach (var vertexKey in graph)
            {
                System.Console.WriteLine(vertexKey);
                foreach (var key in graph.GetVertex(vertexKey))
                {
                    var nodeU = graph.GetVertex(vertexKey);
                    var nodeV = graph.GetVertex(key);
                    var w = nodeU.GetEdge(nodeV).Weight<double>();

                    System.Console.WriteLine($"  {nodeU.Key} - ({w}) - {nodeV.Key}");
                }
            }
            System.Console.WriteLine($"Number of vertex im this graph: {graph.Count}");


        }

        private static void UnWeightDiGraph()
        {

            var graph = new DiGraph<char>(new List<char> { 'A', 'B', 'C', 'D', 'E' });

            graph.AddEdge('B', 'A');
            graph.AddEdge('A', 'D');
            graph.AddEdge('D', 'E');
            graph.AddEdge('C', 'D');
            graph.AddEdge('C', 'E');
            graph.AddEdge('C', 'A');
            graph.AddEdge('C', 'B');
            System.Console.WriteLine("Is there an edge between A and B? {0}", graph.HasEdge('A', 'B') ? "Yes" : "No!");


            System.Console.WriteLine("Is there an edge between B and A? {0}", graph.HasEdge('B', 'A') ? "Yes" : "No!");

            foreach (var key in graph)
            {
                System.Console.WriteLine(key);
                foreach (var item in graph.GetVertex(key))
                {
                    System.Console.WriteLine($"    {item}");
                }
            }
            System.Console.WriteLine($"Number of vertex in graph: {graph.Count}");

            System.Console.WriteLine("\nRemove c vertex");

            graph.RemoveVertex('C');
            foreach (var key in graph)
            {
                System.Console.WriteLine(key);
                foreach (var item in graph.GetVertex(key))
                {
                    System.Console.WriteLine($"    {item}");
                }
            }
            System.Console.WriteLine($"Number of vertex in graph: {graph.Count}");
        }

        private static void WeightedGraph()
        {
            var graph = new WeightedGraph<char, double>(new char[] { 'A', 'B', 'C', 'D' });
            graph.AddVertex('E');
            graph.AddVertex('F');
            graph.AddVertex('G');


            graph.AddEdge('A', 'B', 1.2);
            graph.AddEdge('A', 'D', 2.3);
            graph.AddEdge('D', 'C', 5.5);
            graph.AddEdge('E', 'F', 1.1);
            graph.AddEdge('F', 'G', 3.1);
            graph.AddEdge('C', 'E', 8.1);


            System.Console.WriteLine("Is there an edge between A and B? : {0} ", graph.HasEdge('A', 'B') ? "Yes" : "No!");
            System.Console.WriteLine("Is there an edge between B and A? : {0} ", graph.HasEdge('A', 'B') ? "Yes" : "No!");


            foreach (char vertex in graph)
            {
                System.Console.WriteLine(vertex);
                foreach (char key in graph.GetVertex(vertex))
                {
                    var node = graph.GetVertex(key);
                    System.Console.WriteLine($" {vertex} - {node.GetEdge(graph.GetVertex(vertex)).Weight<double>()} - {key}");
                }

            }

            System.Console.WriteLine("Number of vertex in graph: {0} ", graph.Count);


        }
        private static void UnWeightGraph()
        {
            var graph = new Graph<char>(new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G' });

            graph.AddEdge('A', 'B');
            graph.AddEdge('A', 'D');
            graph.AddEdge('C', 'D');
            graph.AddEdge('C', 'E');
            graph.AddEdge('E', 'E');
            graph.AddEdge('E', 'F');
            graph.AddEdge('F', 'G');

            System.Console.WriteLine("Is there an edge between A and B ? {0}", graph.HasEdge('A', 'B') ? "Yes" : "No!");
            System.Console.WriteLine("Is there an edge between B and A ? {0}", graph.HasEdge('A', 'B') ? "Yes" : "No!");
            System.Console.WriteLine("Is there an edge between B and D ? {0}", graph.HasEdge('B', 'D') ? "Yes" : "No!");
            System.Console.WriteLine("Is there an edge between D and B ? {0}", graph.HasEdge('D', 'B') ? "Yes" : "No!");




            foreach (var key in graph)
            {
                System.Console.WriteLine(key);
                foreach (var vertex in graph.GetVertex(key).Edges)
                {
                    System.Console.WriteLine("    {0}", vertex);
                }

            }

            System.Console.WriteLine($"Number of vertex in the graph {graph.Count}");
        }
    }
}