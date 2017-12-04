using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GraphAlgorithms.Graphs
{
    class MinHamilCycleFinder
    {
        private Vertex[] graph;

        public MinHamilCycleFinder(int[,] adjacMatrix)
        {
            initGraph(adjacMatrix);
        }

        public Vertex[] testMethod()
        {
            return graph;
        }

        private void initGraph(int[,] adjacMatrix)
        {
            graph = new Vertex[adjacMatrix.GetLength(0)];
            Dictionary<Vertex, int> fromVertEdges;
            int i;

            for (i = 0; i < 6; i++)
            {
                graph[i] = new Vertex(i);
            }

            for (i = 0; i < 6; i++)
            {
                fromVertEdges = new Dictionary<Vertex, int>();

                for (int j = 0; j < 6; j++)
                {
                    if (adjacMatrix[i,j] != -1)
                    {
                        fromVertEdges.Add(graph[j], adjacMatrix[i, j]);
                    }
                }

                graph[i].setAdjcVertexes(fromVertEdges);
            }
        }
    }
}
