using System;
using System.Collections.Generic;
using DSAndAlgorithms.Stacks;

namespace DSAndAlgorithms.DataStructures.Graphs
{
    class Graph
    {
        //private members
        private readonly HashSet<Vertex> vertexes; 

        // Graph representation using Adjacency List
        private readonly Dictionary<Vertex, LinkedList<Edge>> vertexEdgeMapping;

        public Graph(bool isDirect)
        {
            IsDirectGraph = isDirect;
            vertexes = new HashSet<Vertex>();
            vertexEdgeMapping = new Dictionary<Vertex, LinkedList<Edge>>();
        }

        public bool IsDirectGraph { get; set; }

        public bool AddVertex(Vertex vertex)
        {
            try
            {
                vertexes.Add(vertex);
                vertexEdgeMapping.Add(vertex, new LinkedList<Edge>());
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Add vertex failed! {0}", e.Message);
                return false;
            }
        }

        public bool AddEdge(Vertex from, Vertex to, int weight)
        {
            try
            {
                var newEdge = new Edge(from, to, weight);
                vertexEdgeMapping[from].AddLast(newEdge);
                if (IsDirectGraph == true)
                {
                    var backEdge = new Edge(to, from, weight);
                    vertexEdgeMapping[to].AddLast(backEdge);
                }
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Add edge failed! {0}", e.Message);
                return false;
            }
        }

        public bool BreadthFirstSearch(Vertex rootVertex)
        {
            try
            {
                Console.WriteLine("******* Breadth First Search  ********");
                const string white = "white";
                const string gray = "gray";
                const string black = "black";
                var colorMap = new Dictionary<Vertex, string>();
                
                foreach (var vertex in vertexes)
                {
                    colorMap.Add(vertex, white);
                }

                colorMap[rootVertex] = gray;

                var queue = new Queue<Vertex>();
                queue.Enqueue(rootVertex);

                while (queue.Count != 0)
                {
                    Vertex temp = queue.Dequeue();
                    foreach (Edge edge in vertexEdgeMapping[temp])
                    {
                        if (colorMap[edge.ToVertex] == white)
                        {
                            colorMap[edge.ToVertex] = gray;
                            queue.Enqueue(edge.ToVertex);
                        }
                    }
                    colorMap[temp] = black;
                    Console.WriteLine("Vertex {0} has been found!", temp.VertexLabel);
                }

                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Breadth First Search failed! {0}", e.Message);
                return false;
            }
        }

        public bool DepthSearchFirst()
        {
            try
            {
                Console.WriteLine("******* Depth First Search  ********");
                const string white = "white";

                // Space complexity O(V)
                var color = new Dictionary<Vertex, string>();
                //var parent = new Dictionary<Vertex, Vertex>();

                // Time complexity O(V)
                foreach (Vertex vertex in vertexes)
                {
                    color.Add(vertex, white);
                   // parent.Add(vertex, null);
                }

                foreach (Vertex vertex in vertexes)
                {
                    if (color[vertex] == white)
                    {
                        DFS_Visit(vertex, color);
                    }
                }
              
                return true;
            }
            catch (Exception e)
            {

                Console.WriteLine("Depth search first failed! {0}", e.Message);
                return false;
            }

        }

        private bool DFS_Visit(Vertex vertex, Dictionary<Vertex, string> color)
        {
            try
            {
                const string white = "white";
                const string gray = "gray";
                const string black = "black";

                color[vertex] = gray;
                foreach (Edge edge in vertexEdgeMapping[vertex])
                {
                    if (color[edge.ToVertex] == white)
                    {
                        DFS_Visit(edge.ToVertex, color);
                    }
                }

                color[vertex] = black;
                Console.WriteLine("Vertex {0} has been found!", vertex.VertexLabel);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("DFS_Visit failed! {0}", e.Message);
                return false;
            }

        }

        public void MinimumSpanningTree()
        {
            // Note: Done Kruskal's algorithm as part of other solution $/CodeScratchPad/KruskalAlgorithm
        }
    }
}
