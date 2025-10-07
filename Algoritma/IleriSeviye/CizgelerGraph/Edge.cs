using System;

namespace Programlama.IleriAlgoritma.Graph
{
    /// <summary>
    /// Graph içindeki bir kenarı temsil eder
    /// </summary>
    /// <typeparam name="T">Vertex anahtar tipi (örneğin int, string..)</typeparam>
    /// <typeparam name="TW">Kenarın ağırlık tipi (ICımparable implement eden tip)</typeparam>
    public class Edge<T, TW> : IEdge<T> where TW : IComparable<TW>
    {
        private object weight; //Kenarın ağırlığı, eneric tip C olarak tutuluyor

        /// <summary>
        /// Kenarın hedef vertex'inin anahtarı
        /// </summary>
        public T TargetVertexKey => TargetVertex.Key;

        /// <summary>
        /// Kenarın hedef vertex'i ve ağırlığını belirten constructor
        /// </summary>
        /// <param name="target">Hedef vertex</param>
        /// <param name="Weight">Kenrın ağırlığı</param>
        /// <exception cref="AbandonedMutexException"></exception>
        public Edge(IGraphVertex<T> target, TW Weight)
        {
            this.TargetVertex = target; // hedef vertex atanıyor
            this.weight = Weight;       // Kenar ağırlığı atanıyor
        }
        /// <summary>
        /// Kenarın hedef vertex nesnesi
        /// </summary>
        public IGraphVertex<T> TargetVertex { get; private set; }

        /// <summary>
        /// Kenarın ağırlığını döndürür
        /// </summary>
        /// <typeparam name="W">Dönül tipi, IComparable implement eden tip</typeparam>
        /// <returns>Kenar ağırlığı</returns>
        public W Weight<W>() where W : IComparable
        {
            return (W)weight;
        }

        public override string ToString() => TargetVertexKey?.ToString()!;

    }


    public class DiEdge<T, TW> : IDiEdge<T> where TW : IComparable<TW>
    {
        private object weight;
        public IDiGraphVertex<T> TargetVertex { get; private set; }

        public DiEdge(IDiGraphVertex<T> target, TW Weight)
        {

            this.TargetVertex = target;
            this.weight = Weight;
        }

        public T TargetVertexKey => TargetVertex.Key;

        IGraphVertex<T> IEdge<T>.TargetVertex => TargetVertex as IGraphVertex<T>;

        public W Weight<W>() where W : IComparable
        {
            return (W)weight;
        }

        public override string ToString() => TargetVertexKey?.ToString()!;
    }
}