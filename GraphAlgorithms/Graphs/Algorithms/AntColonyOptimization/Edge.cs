using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GraphAlgorithms.Graphs.Algorithms.AntColonyOptimization
{
    class Edge
    {
        public int startV { get; private set; }
        public int endV { get; private set; }
        public int length { get; private set; }
        public double pherAmount { get; private set; }
        public static double evapFactor { private get; set; }

        public Edge(int startV, int endV, int length, double initPherAmount)
        {
            this.startV = startV;
            this.endV = endV;
            this.length = length;
            this.pherAmount = initPherAmount;
        }

        public void evaporatePher()
        {
            pherAmount *= (1 - evapFactor);
        }


    }
}
