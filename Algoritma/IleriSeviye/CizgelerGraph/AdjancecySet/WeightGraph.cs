using System;
using System.Collections;

namespace Programlama.IleriAlgoritma.Graph
{
    public class WeightedGraph<T, TW> : IGraph<T> where TW : IComparable<TW> where T : notnull
    {
        private Dictionary<T, WeightedGraphVertex> vertices;

        public WeightedGraph()
        {
            vertices = new Dictionary<T, WeightedGraphVertex>();
        }

        public WeightedGraph(IEnumerable<T> collection) : this()
        {
            foreach (var item in collection)
            {
                AddVertex(item);
            }
        }

        public bool isWeightedGraph => true;

        public int Count => vertices.Count;

        public IGraphVertex<T> ReferanceVertex => vertices[this.First()];

        public IEnumerable<IGraphVertex<T>> VertecesAsEnumberable => vertices.Select(x => x.Value);

        public void AddEdge(T source, T dest, TW weight)
        {


            if (source == null || dest == null) throw new ArgumentNullException();
            if (!vertices.ContainsKey(source) || !vertices.ContainsKey(dest)) throw new ArgumentException("source or destination vertex is not in this graph");


            vertices[source].Edges.Add(vertices[dest], weight);
            vertices[dest].Edges.Add(vertices[source], weight);

        }

        public void AddVertex(T key)
        {
            if (key == null) throw new ArgumentNullException();

            var newVertex = new WeightedGraphVertex(key);
            vertices.Add(key, newVertex);
        }

        IGraph<T> IGraph<T>.Clone()
        {
            return Clone();
        }

        public WeightedGraph<T, TW> Clone()
        {
            var graph = new WeightedGraph<T, TW>();
            foreach (var vertex in vertices)
            {
                graph.AddVertex(vertex.Key);
            }
            foreach (var vertex in vertices)
            {
                foreach (var edge in vertex.Value.Edges)
                {
                    graph.AddEdge(vertex.Value.Key, edge.Key.Key, edge.Value);
                }
            }
            return graph;
        }

        public bool ContainsVertex(T key)
        {
            return vertices.ContainsKey(key);
        }

        public IEnumerable<T> Edges(T key)
        {
            if (key == null) throw new ArgumentNullException();
            return vertices[key].Edges.Select(x => x.Key.Key);
        }

        public IEnumerator<T> GetEnumerator()
        {
            return vertices.Select(x => x.Key).GetEnumerator();
        }

        public IGraphVertex<T> GetVertex(T key)
        {
            return vertices[key];
        }

        public bool HasEdge(T source, T dest)
        {
            if (source == null || dest == null) throw new ArgumentNullException();
            if (!vertices.ContainsKey(source) || !vertices.ContainsKey(dest)) throw new ArgumentException("source or destination vertex is not in this graph");


            return vertices[source].Edges.ContainsKey(vertices[dest]) && vertices[dest].Edges.ContainsKey(vertices[source]);
        }

        public void RemoveEdge(T source, T dest)
        {
               if (source == null || dest == null) throw new ArgumentNullException();
            if (!vertices.ContainsKey(source) || !vertices.ContainsKey(dest)) throw new ArgumentException("source or destination vertex is not in this graph");

            if (!vertices[source].Edges.ContainsKey(vertices[dest]) || vertices[dest].Edges.ContainsKey(vertices[source]))
                throw new Exception("The edge does not exists.");

            vertices[source].Edges.Remove(vertices[dest]);
            vertices[dest].Edges.Remove(vertices[source]);
        }

        public void RemoveVertex(T key)
        {
          if (key == null) throw new ArgumentNullException();

            if (!vertices.ContainsKey(key)) throw new ArgumentException("The vertex is not in this graph");
            
            foreach (var item in vertices[key].Edges)
            {
                item.Key.Edges.Remove(vertices[key]);
            }

            vertices.Remove(key);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        private class WeightedGraphVertex : IGraphVertex<T>
        {
            public Dictionary<WeightedGraphVertex, TW> Edges;

            public WeightedGraphVertex(T key)
            {
                this.Key = key;
                this.Edges = new Dictionary<WeightedGraphVertex, TW>();
            }
            public T Key { get; set; }

            IEnumerable<IEdge<T>> IGraphVertex<T>.Edges => Edges.Select(x => new Edge<T, TW>(x.Key, x.Value));

            public IEdge<T> GetEdge(IGraphVertex<T> targetVertex)
            {
                //is -> nesne belirli bir tipe ait olup olamadığnı kontrol eder
                //Hep tip kontrolü hem değişken tanımlaması aynı anda yapılıyo
                if (targetVertex is WeightedGraphVertex vertex)
                {
                    //TryGetValue(key, out var valu) -> anahtar varsa değeri döndür, yoksa hata ver
                    if (Edges.TryGetValue(vertex, out var weight))
                    {
                        return new Edge<T, TW>(vertex, weight);
                    }
                    else
                    {
                        //KeyNotFoundException()-> Dictionary içinde olmayan bir anahtara doğrudan erişmeye çalışıldığında fırlatılan hata
                        throw new KeyNotFoundException("Edge not found in this vertex");
                    }
                }
                throw new ArgumentException("Invalid vertex type", nameof(targetVertex));
            }

            public IEnumerator<T> GetEnumerator()
            {
                return Edges.Select(x => x.Key.Key).GetEnumerator();
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }
        }
    }
}