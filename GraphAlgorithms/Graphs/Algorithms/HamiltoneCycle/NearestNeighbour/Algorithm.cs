using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GraphAlgorithms.Graphs.Algorithms.HamiltoneCycle.NearestNeighbour
{
    class Algorithm: IMinHamiltoneCycleFinder
    {
        int[,] adjMatrix;
        int[] bestDecision;
        int vertexCount;

        public Algorithm(int[,] adjMatrix)
        {
            this.adjMatrix = adjMatrix;
            this.vertexCount = adjMatrix.GetLength(0);
        }

        public (int[], int) findHamiltoneCycle()
        {
            var hamiloneCycle = new int[vertexCount];
            
            for (int i = 0; i < vertexCount; i++)
            {
                var visited = new LinkedList<int>();
                visited.AddLast(i);

                do
                {
                    var nearestNotVisited = getNearestNotVisited(visited);

                    if (nearestNotVisited != -1)
                    {
                        visited.AddLast(nearestNotVisited);
                    }
                    else
                    {
                        break;
                    }

                } while (visited.Count != vertexCount);

                if (visited.Count == vertexCount && adjMatrix[visited.Last(), visited.First()] != -1)
                {
                    visited.AddLast(visited.First());
                    bestDecision = bestDecision == null || getPathLength(bestDecision) > getPathLength(visited.ToArray()) ? visited.ToArray() : bestDecision;
                }
                else
                {
                    continue;
                }
            }

            return (bestDecision == null ? (null, 0) : (bestDecision, getPathLength(bestDecision)));

        }

        private int getPathLength(int[] path)
        {
            int length = 0;

            for (int i = 0; i < path.Length - 1; i++)
            {
                length += adjMatrix[path[i], path[i + 1]];
            }

            return length;
        }

        private int getNearestNotVisited(LinkedList<int> visited)
        {
            var adjVertexes = getAdjacentVertexes(visited.Last()).OrderBy(v => v);
            int res = -1;

            foreach (var adjVertex in adjVertexes)
            {
                if (!visited.Contains(adjVertex))
                {
                    res = adjVertex;
                    break;
                }
            }

            return res;
        }

        private int[] getAdjacentVertexes(int vertexIdx)
        {
            var adjVertexes = new LinkedList<int>();

            for (int i = 0; i < vertexCount; i++)
            {
                if (adjMatrix[vertexIdx, i] != -1)
                {
                    adjVertexes.AddLast(i);
                }
            }

            return adjVertexes.ToArray();
        }

    }
}
