using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GraphAlgorithms.Graphs.Algorithms.SimulatedAnnealing
{
    class Algorithm
    {
        private static Random randomizer;
        int startTemperature;
        double tempDecreasingDelta;
        int[,] adjMatrix;
        int[] bestDecision;
        int iterationCount;
        int vertexCount;

        public Algorithm(int[,] adjMatrix, int[] someDecision, int iterationCount)
        {
            this.vertexCount = 0;
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

        private (int[], int) getHamiltoneCycle()
        {
            var hamiloneCycle = new int[vertexCount];
            var temp = startTemperature;

            for (int i = 0; i < iterationCount; i++)
            {
                var newCycle = (int[])bestDecision.Clone();
                temp -= (int) Math.Round(i * tempDecreasingDelta);
                int[] cycle;
                int oldLen;
                int newLen;
                int diff;
                double prob = 0;
                do
                {
                    cycle = newCycle;
                    oldLen = getPathLength(cycle);
                    newCycle = getNewCycle(cycle);
                    newLen = getPathLength(newCycle);

                    diff = newLen - oldLen;

                    if (diff > 0)
                    {
                        prob = 100 * Math.Pow(Math.E, -diff / temp);
                    }
                    else
                    {
                        bestDecision = newCycle;
                    }
                } while (diff < 0 || prob > randomizer.NextDouble() * startTemperature);
            }

            return (bestDecision, getPathLength(bestDecision));
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

        private int[] getNewCycle(int[] cycle)
        {
            var maxIdx = cycle.Length - 3;
            int[] newCycle;
            int rand1;
            int rand2;

            do
            {
                newCycle = (int[])cycle.Clone();
                rand1 = (int)Math.Round(randomizer.NextDouble() * maxIdx);
                rand2 = rand1;

                while (rand1 == rand2) rand2 = (int)Math.Round(randomizer.NextDouble() * maxIdx);

                newCycle[rand1 + 1] = cycle[rand2 + 1];
                newCycle[rand2 + 1] = cycle[rand1 + 1];

            } while (!checkIntegrityAt(newCycle, rand1) || checkIntegrityAt(newCycle, rand2));

            return newCycle;
        }

        private bool checkIntegrityAt(int[] path, int vertexIdx)
        {
            return 
                adjMatrix[path[vertexIdx - 1], path[vertexIdx]] != -1 &&
                adjMatrix[path[vertexIdx], path[vertexIdx + 1]] != -1;
        }

    }
}
