using System;
namespace Programlama.IleriAlgoritma.Graph
{
    public class BreadthFirst<T>
    {
        public bool Find(IGraph<T> graph, T vertexKey)
        {
            return bfs(graph.ReferanceVertex,new HashSet<T>(), vertexKey);
        }

        private bool bfs(IGraphVertex<T> referanceVertex, HashSet<T> visited, T searchVertexKey)
        {
            var q = new Queue<IGraphVertex<T>>();
            q.Enqueue(referanceVertex);

            visited.Add(referanceVertex.Key);
            
            while (q.Count > 0)
            {
                var current = q.Dequeue();
                System.Console.WriteLine(current.Key);
                if (current.Key!.Equals(searchVertexKey))
                {
                    return true;
                }
                foreach (var edge in current.Edges)
                {
                    if (visited.Contains(edge.TargetVertexKey))
                    {
                        continue;
                    }
                    visited.Add(edge.TargetVertexKey);
                   ;
                    q.Enqueue(edge.TargetVertex);
                }
            }

            return false;
        }
    }
    /*
    Breadth-First Search (BFS)
        - Graph katman katman (level by level ) dolaşır
        - Başladığınız düğümden başlayarak önce tüm komşularını ziyaret eder, sonra onların komşularını vs. 
        - Özellikle ağırlıksız graflarda, bir kaynaktan diğer düğüme en kısa yol (kenar sayısı bazında) bulmada kullanılır.
        - En kısa yolu garanti eder
        - Tüm düğümleri dolaşır
    */
}