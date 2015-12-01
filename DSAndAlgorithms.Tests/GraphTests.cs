using DSAndAlgorithms.DataStructures.Graphs;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DSAndAlgorithms.Tests
{
    [TestClass]
    public class GraphTests
    {
        [TestMethod]
        public void Graph_Tests()
        {
            // Direct Graph
            var G = new Graph(true);
            var u = new Vertex("u");
            var v = new Vertex("v");
            var w = new Vertex("w");
            var x = new Vertex("x");
            var y = new Vertex("y");
            var z = new Vertex("z");
            // Add vertexes
            G.AddVertex(u);
            G.AddVertex(v);
            G.AddVertex(w);
            G.AddVertex(x);
            G.AddVertex(y);
            G.AddVertex(z);
            // Add edges
            G.AddEdge(u, v, 3);
            G.AddEdge(u, x, 3);
            G.AddEdge(v, y, 3);
            G.AddEdge(w, y, 3);
            G.AddEdge(w, z, 3);
            G.AddEdge(x, v, 3);
            G.AddEdge(y, x, 3);
            G.AddEdge(z, u, 3);
            //Depth Search First
            G.DepthSearchFirst();


            //Undirect Graph
            var UG = new Graph(false);
            var ur = new Vertex("r");
            var us = new Vertex("s");
            var ut = new Vertex("t");
            var uu = new Vertex("u");
            var uv = new Vertex("v");
            var uw = new Vertex("w");
            var ux = new Vertex("x");
            var uy = new Vertex("y");

            // Add vertexes
            UG.AddVertex(ur);
            UG.AddVertex(us);
            UG.AddVertex(ut);
            UG.AddVertex(uu);
            UG.AddVertex(uv);
            UG.AddVertex(uw);
            UG.AddVertex(ux);
            UG.AddVertex(uy);
            // Add Edge
            UG.AddEdge(ur, uv, 3);
            UG.AddEdge(ur, us, 3);
            UG.AddEdge(us, uw, 3);
            UG.AddEdge(ut, uu, 3);
            UG.AddEdge(ut, uw, 3);
            UG.AddEdge(ut, ux, 3);
            UG.AddEdge(uu, ux, 3);
            UG.AddEdge(uu, uy, 3);
            UG.AddEdge(uw, ux, 3);
            UG.AddEdge(ux, uy, 3);

            //Breadth First Search
            UG.BreadthFirstSearch(us);
        }
    }
}