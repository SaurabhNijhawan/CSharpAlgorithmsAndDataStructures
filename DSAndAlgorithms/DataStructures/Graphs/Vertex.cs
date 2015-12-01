namespace DSAndAlgorithms.DataStructures.Graphs
{
    internal class Vertex
    {
        public Vertex(string label)
        {
            VertexLabel = label;
        }

        public string VertexLabel { get; private set; }

        public override bool Equals(object obj)
        {
            var vertex = obj as Vertex;

            if (vertex == null)
            {
                return false;
            }

            return vertex.VertexLabel == VertexLabel;
        }

        public override int GetHashCode()
        {
            int hashCode = 37;

            if (VertexLabel != null)
            {
                hashCode = hashCode*23 + VertexLabel.GetHashCode();
            }

            return hashCode;
        }
    }
}