using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GraphAlgorithms.Graphs.Algorithms.AntColonyOptimization
{
    struct Tour
    {
        private int[] visitSeq;
        private bool[] visitedTowns;
        private int tourLength;
        private int countOfVisitedTowns;

        public Tour(int townCount, int startTown)
        {
            visitSeq = new int[townCount];
            visitedTowns = new bool[townCount];
            visitSeq[0] = startTown;
            visitedTowns[startTown] = true;
            countOfVisitedTowns = 1;
            tourLength = 0;
        }

        public int getLastVisitedTown()
        {
            return visitSeq[countOfVisitedTowns - 1];
        }

        public bool isTownVisited(int town)
        {
            return visitedTowns[town];
        }

        public bool isAllTownsVisited()
        {
            return countOfVisitedTowns == visitedTowns.Length;
        }

        public void visitTown(int town, int length)
        {
            visitSeq[countOfVisitedTowns++] = town;
            visitedTowns[town] = true;
            tourLength += length;
        }

        public void visitCycleTown(int length)
        {
            tourLength += length;
        }

        public int[] getVisitedSeq()
        {
            return (int[])visitSeq.Clone();
        }

        public int getTourLength()
        {
            return tourLength;
        }
    }


    class Ant
    {
        private Tour tour;
        private static Tour bestTour;

        public Ant(int countOfTowns, int startTown)
        {
            this.tour = new Tour(countOfTowns, startTown);
        }

        public void tryAsBest()
        {
            if (bestTour.getTourLength() > tour.getTourLength())
            {
                bestTour = tour;
            }
        }

        public int getLastVisitedTown()
        {
            return tour.getLastVisitedTown();
        }

        public bool isAllTownsVisited()
        {
            return tour.isAllTownsVisited();
        }

        public static int[] getBestTourVisSeq()
        {
            return bestTour.getVisitedSeq();
        }





    }
}
