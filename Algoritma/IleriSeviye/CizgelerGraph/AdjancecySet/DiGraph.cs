using System;
using System.Collections;

namespace Programlama.IleriAlgoritma.Graph
{
    public class DiGraph<T> : IDiGraph<T> where T : notnull
    {
        private Dictionary<T, DiGraphVertex<T>> vertices;

        public DiGraph()
        {
            vertices = new Dictionary<T, DiGraphVertex<T>>();
        }
        public DiGraph(IEnumerable<T> collection) : this()
        {
            foreach (var item in collection)
            {
                AddVertex(item);
            }
        }
        public IDiGraphVertex<T> ReferanceVertex => vertices[this.First()];

        public IEnumerable<IDiGraphVertex<T>> VertecesAsEnumberable => vertices.Select(x => x.Value);



        public bool isWeightedGraph => false;

        public int Count => vertices.Count;

        IGraphVertex<T> IGraph<T>.ReferanceVertex => vertices[this.First()] as IGraphVertex<T>;

        IEnumerable<IGraphVertex<T>> IGraph<T>.VertecesAsEnumberable => vertices.Select(x => x.Value);

        public void AddVertex(T key)
        {
            if (key == null) throw new ArgumentNullException();

            var newVertex = new DiGraphVertex<T>(key);
            vertices.Add(key, newVertex);
        }

        public DiGraph<T> Clone()
        {
            var grap = new DiGraph<T>();
            foreach (var vertex in vertices)
            {
                grap.AddVertex(vertex.Key);
            }
            foreach (var vertex in vertices)
            {
                foreach (var node in vertex.Value.OutEdges)
                {
                    grap.AddEdge(vertex.Value.Key, node.Key);
                }
            }
            return grap;

        }
        IGraph<T> IGraph<T>.Clone()
        {
            return Clone();

        }
        public void AddEdge(T source, T dest)
        {
            if (source == null || dest == null) throw new ArgumentNullException();
            if (!vertices.ContainsKey(source) || !vertices.ContainsKey(dest)) throw new ArgumentException("Source or destination vertex is not in this graph");
            if (vertices[source].OutEdges.Contains(vertices[dest]) || vertices[dest].InEdges.Contains(vertices[source])) throw new Exception("The edge has been already defined!");

            vertices[source].OutEdges.Add(vertices[dest]);
            vertices[dest].InEdges.Add(vertices[source]);
        }

        public bool ContainsVertex(T key)
        {
            return vertices.ContainsKey(key);
        }

        public IEnumerable<T> Edges(T key)
        {
            if (key == null) throw new ArgumentNullException();
            return vertices[key].OutEdges.Select(x => x.Key);
        }

        public IEnumerator<T> GetEnumerator()
        {
            return vertices.Select(x => x.Key).GetEnumerator();
        }

        public bool HasEdge(T source, T dest)
        {
            if (source == null || dest == null) throw new ArgumentNullException();
            if (!vertices.ContainsKey(source) || !vertices.ContainsKey(dest)) throw new ArgumentException("Source or destination vertex is not in this graph");
            return vertices[source].OutEdges.Contains(vertices[dest]) && vertices[dest].InEdges.Contains(vertices[source]);
        }

        public void RemoveEdge(T source, T dest)
        {
            if (source == null || dest == null) throw new ArgumentNullException();
            if (!vertices.ContainsKey(source) || !vertices.ContainsKey(dest)) throw new ArgumentException("Source or destination vertex is not in this graph");
            if (!vertices[source].OutEdges.Contains(vertices[dest]) || !vertices[dest].InEdges.Contains(vertices[source])) throw new Exception("The edge has been already defined!");

            vertices[source].OutEdges.Remove(vertices[dest]);
            vertices[dest].InEdges.Remove(vertices[source]);
        }

        public void RemoveVertex(T key)
        {
            if (key == null) throw new ArgumentNullException();
            if (!vertices.ContainsKey(key)) throw new ArgumentException("The vertex is not in this graph");

            foreach (var item in vertices[key].OutEdges)
            {
                item.OutEdges.Remove(vertices[key]);
            }
            foreach (var item in vertices[key].InEdges)
            {
                item.InEdges.Remove(vertices[key]);
            }


            vertices.Remove(key);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public IGraphVertex<T> GetVertex(T key)
        {
            return vertices[key];
        }


        // Nested Types
        private class DiGraphVertex<Q> : IDiGraphVertex<T>
        {


            public HashSet<DiGraphVertex<T>> OutEdges { get; }
            public HashSet<DiGraphVertex<T>> InEdges { get; }

            public DiGraphVertex(T key)
            {
                this.OutEdges = new HashSet<DiGraphVertex<T>>();
                this.InEdges = new HashSet<DiGraphVertex<T>>();
                this.Key = key;
            }

            IEnumerable<IDiEdge<T>> IDiGraphVertex<T>.OutEdges => OutEdges.Select(x => new DiEdge<T, int>(x, 1));

            IEnumerable<IDiEdge<T>> IDiGraphVertex<T>.InEdges => InEdges.Select(x => new DiEdge<T, int>(x, 1));

            public int OutEdgesCount => OutEdges.Count;

            public int InEdgesCount => InEdges.Count;

            public T Key { get; set; }


            public IEnumerable<IEdge<T>> Edges => OutEdges.Select(x => new Edge<T, int>(x, 1));

            public IEdge<T> GetEdge(IGraphVertex<T> targetVertex)
            {
                return new Edge<T, int>(targetVertex, 1);
            }

            public IEnumerator<T> GetEnumerator()
            {
                return OutEdges.Select(x => x.Key).GetEnumerator();
            }

            public IDiEdge<T> GetOutEdge(IDiGraphVertex<T> targetVertex)
            {
                return new DiEdge<T, int>(targetVertex, 1);
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }
        }
    }


}
