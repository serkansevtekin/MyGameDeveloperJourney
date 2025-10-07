using System;
using System.Collections;

namespace Programlama.IleriAlgoritma.Graph
{
    public class WeightedDiGraph<T, TW> : IDiGraph<T> where TW : IComparable<TW> where T : notnull
    {
        private Dictionary<T, WeightedDiGraphVertex> vertices;

        public WeightedDiGraph()
        {
            this.vertices = new Dictionary<T, WeightedDiGraphVertex>();
        }
        public WeightedDiGraph(IEnumerable<T> collection) : this()
        {
            foreach (var item in collection)
            {
                AddVertex(item);
            }
        }

        public IDiGraphVertex<T> ReferanceVertex => vertices[this.First()];

        public IEnumerable<IDiGraphVertex<T>> VertecesAsEnumberable => vertices.Select(x => x.Value);

        public bool isWeightedGraph => true;

        public int Count => vertices.Count;

        IGraphVertex<T> IGraph<T>.ReferanceVertex => vertices[this.First()] as IGraphVertex<T>;

        IEnumerable<IGraphVertex<T>> IGraph<T>.VertecesAsEnumberable => vertices.Select(x => x.Value);

        public void AddVertex(T key)
        {
            if (key == null) throw new ArgumentNullException();

            var newVertex = new WeightedDiGraphVertex(key);
            vertices.Add(key, newVertex);
        }

        public void AddEdge(T source, T dest, TW weight)
        {
            if (source == null || dest == null) throw new ArgumentNullException();
            if (!vertices.ContainsKey(source) || !vertices.ContainsKey(dest)) throw new ArgumentException("Source or destination vertex is not in this graph");
            if (vertices[source].OutEdges.ContainsKey(vertices[dest]) || vertices[dest].InEdges.ContainsKey(vertices[source])) throw new Exception("The edge has been already defined!");

            vertices[source].OutEdges.Add(vertices[dest], weight);
            vertices[dest].InEdges.Add(vertices[source], weight);
        }

        public WeightedDiGraph<T,TW> Clone() {
            var grap = new WeightedDiGraph<T,TW>();
            foreach (var vertex in vertices)
            {
                grap.AddVertex(vertex.Key);
            }
            foreach (var vertex in vertices)
            {
                foreach (var node in vertex.Value.OutEdges)
                {
                    grap.AddEdge(vertex.Value.Key, node.Key.Key,node.Value);
                }
            }
            return grap;
        }
         IGraph<T> IGraph<T>.Clone()
        {
            return Clone();
        }

        public bool ContainsVertex(T key)
        {
            return vertices.ContainsKey(key);
        }

        public IEnumerable<T> Edges(T key)
        {
            if (key == null) throw new ArgumentNullException();
            return vertices[key].OutEdges.Select(x => x.Key.Key);
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
            if (!vertices.ContainsKey(source) || !vertices.ContainsKey(dest)) throw new ArgumentException("Source or destination vertex is not in this graph");
            return vertices[source].OutEdges.ContainsKey(vertices[dest]) && vertices[dest].InEdges.ContainsKey(vertices[source]);
        }

        public void RemoveEdge(T source, T dest)
        {
            if (source == null || dest == null) throw new ArgumentNullException();
            if (!vertices.ContainsKey(source) || !vertices.ContainsKey(dest)) throw new ArgumentException("Source or destination vertex is not in this graph");
            if (!vertices[source].OutEdges.ContainsKey(vertices[dest]) || !vertices[dest].InEdges.ContainsKey(vertices[source])) throw new Exception("The edge has been already defined!");

            vertices[source].OutEdges.Remove(vertices[dest]);
            vertices[dest].InEdges.Remove(vertices[source]);
        }

        public void RemoveVertex(T key)
        {
           
            if (key == null) throw new ArgumentNullException();
            if (!vertices.ContainsKey(key)) throw new ArgumentException("The vertex is not in this graph");

            foreach (var item in vertices[key].OutEdges)
            {
                item.Key.OutEdges.Remove(vertices[key]);
            }
            foreach (var item in vertices[key].InEdges)
            {
                item.Key.InEdges.Remove(vertices[key]);
            }


            vertices.Remove(key);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        private class WeightedDiGraphVertex : IDiGraphVertex<T>
        {
            public Dictionary<WeightedDiGraphVertex, TW> OutEdges { get; }
            public Dictionary<WeightedDiGraphVertex, TW> InEdges { get; }

            public T Key { get; set; }
            public WeightedDiGraphVertex(T key)
            {
                this.OutEdges = new Dictionary<WeightedDiGraphVertex, TW>();
                this.InEdges = new Dictionary<WeightedDiGraphVertex, TW>();
                this.Key = key;
            }


            IEnumerable<IDiEdge<T>> IDiGraphVertex<T>.OutEdges => OutEdges.Select(x => new DiEdge<T, TW>(x.Key, x.Value));

            IEnumerable<IDiEdge<T>> IDiGraphVertex<T>.InEdges => InEdges.Select(x => new DiEdge<T, TW>(x.Key, x.Value));

            public int OutEdgesCount => OutEdges.Count;

            public int InEdgesCount => InEdges.Count;


            public IEnumerable<IEdge<T>> Edges => OutEdges.Select(x => new DiEdge<T, TW>(x.Key, x.Value));



            public IEnumerator<T> GetEnumerator()
            {
                return OutEdges.Select(x => x.Key.Key).GetEnumerator();
            }

            public IDiEdge<T> GetOutEdge(IDiGraphVertex<T> targetVertex)
            {
                if (targetVertex is not WeightedDiGraphVertex node)
                {
                    throw new ArgumentException("targetVertex must be a WeightedDiGraphVertex of correct type");
                }
                if (targetVertex is not IDiGraphVertex<T> target)
                {
                    throw new ArgumentException("targetVertex must be a WeightedDiGraphVertex of correct type");
                }
                return new DiEdge<T, TW>(target, OutEdges[node]);
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }

            public IEdge<T> GetEdge(IGraphVertex<T> targetVertex)
            {


                if (targetVertex is not WeightedDiGraphVertex node)
                {
                    throw new ArgumentException("targetVertex must be a WeightedDiGraphVertex of correct type");
                }

                return new Edge<T, TW>(targetVertex, OutEdges[node]);
            }
        }
    }
}