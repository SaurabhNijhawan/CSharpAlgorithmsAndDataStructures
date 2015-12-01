namespace DSAndAlgorithms.DataStructures.Graphs
{
    internal class Edge
    {
        public Edge(Vertex from, Vertex to, int weight)
        {
            FromVertex = from;
            ToVertex = to;
            Weight = weight;
        }

        public Vertex FromVertex { get; private set; }
        public Vertex ToVertex { get; private set; }
        public int Weight { get; private set; }
    }
}