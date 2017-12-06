using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GraphAlgorithms.Graphs.Algorithms.AntColonyOptimization
{
    class ACOAlgorithm
    {
        private int countTown;
        private int[,] adjMatrix;
        private double alfa;
        private double beta;
        private const int tours = 20;
        private Edge[] edges;

        public ACOAlgorithm(int[,] adjMatrix, double lengthFactor, double evapFactor, double alfa, double beta)
        {
            Edge.evapFactor = evapFactor;
            Edge.lengthFactor = lengthFactor;
            this.countTown = adjMatrix.GetLength(0);
            this.adjMatrix = adjMatrix;
            this.alfa = alfa;
            this.beta = beta;
            initEdges(0.5);
        }

        private void initEdges(double initPherAmount)
        {
            LinkedList<Edge> allEdges = new LinkedList<Edge>();

            for (int i = 0; i < countTown; i++)
            {
                for(int j = 0; j < countTown; j++){
                    if (adjMatrix[i,j] != -1)
                    {
                        allEdges.AddLast(new Edge(i, j, adjMatrix[i, j], initPherAmount));
                    }
                }
            }

            edges = allEdges.ToArray();
        }

        public Tour run()
        {
            Ant.setTownCount(countTown);
            Ant[] ants = new Ant[countTown];

            for (int i = 0; i < countTown; i++)
            {
                ants[i] = new Ant(i);
            }

            for (int doneTours = 0; doneTours < tours; doneTours++)
            {
                makeOneTour(ants);
            }

            return Ant.getBestTour();
        }

        private void makeOneTour(Ant[] ants)
        {

            for (int visitedTowns = 0; visitedTowns < countTown - 1; visitedTowns++)
            {
                foreach (Edge edge in edges)
                {
                    edge.evaporatePher();
                }

                foreach (Ant ant in ants)
                {
                    Edge edge = getMostProbEdge(ant);

                    if (edge != null)
                    {
                        edge.addPher();
                        ant.visitTown(edge.endV, edge.length);
                    }
                }
            }

            foreach (Ant ant in ants)
            {
                if (ant.isAllTownsVisited())
                {
                    if (tryCycleTour(ant, ant.getLastVisitedTown(), ant.getFirstVisitedTown()))
                    {
                        ant.tryAsBest();
                    }
                }
                ant.toInitState();
            }


        }

        private bool tryCycleTour(Ant ant, int startV, int endV)
        {
            Edge[] eds = edges.Where(edge => edge.startV == startV && edge.endV == endV).ToArray();
            Edge cEdge;

            if (eds.Length == 0)
            {
                return false;
            }
            else
            {
                cEdge = eds[0];
            }

            if (cEdge == null)
            {
                return false;
            }
            else
            {
                ant.visitCycleTown(cEdge.length);
                return true;
            }
        }



        private Edge getMostProbEdge(Ant ant)
        {
            Edge[] possibEdges = 
                getFromTownEdges(ant.getLastVisitedTown()).
                Where(edge => !ant.isTownVisited(edge.endV)).ToArray();

            if (possibEdges.Length == 0)
            {
                return null;
            }

            double comDiv = possibEdges.
                Select(edge => edgePossibility(edge)).Sum();

            possibEdges = possibEdges.OrderByDescending(edge => edgePossibility(edge) / comDiv).ToArray();

            return possibEdges.Length == 0 ? null : possibEdges[0];
        }

        private double edgePossibility(Edge edge)
        {
            return Math.Pow(edge.pherAmount, alfa) + Math.Pow(edge.visibility, beta);
        }

        private Edge[] getFromTownEdges(int town)
        {
            return edges.Where(edge => edge.startV == town).ToArray();
        }
    }
}
