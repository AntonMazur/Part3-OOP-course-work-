using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GraphAlgorithms.Graphs
{
    class Vertex
    {
        private readonly int id;
        private Dictionary<Vertex, int> fromVertEdge;

        public Vertex(int id)
        {
            this.id = id;
        }


        public void setAdjcVertexes(Dictionary<Vertex, int> fromVertEdge)
        {
            this.fromVertEdge = fromVertEdge;
        }

        public override string ToString()
        {
            string str = "Vertex ID: " + id + "\nEdges from the vertex\n";
            foreach (KeyValuePair<Vertex, int> edge in fromVertEdge)
            {
                str += "\nID - " + edge.Key.id + "  Length - " + edge.Value;
            }

            return str;
        }
    }
}
