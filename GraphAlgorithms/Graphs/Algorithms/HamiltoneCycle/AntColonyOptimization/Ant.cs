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
        private static int townCount;

        public Tour(int startTown)
        {
            visitSeq = new int[townCount];
            visitedTowns = new bool[townCount];
            visitSeq[0] = startTown;
            visitedTowns[startTown] = true;
            countOfVisitedTowns = 1;
            tourLength = 0;
        }

        public static void setCountTown(int townCount)
        {
            Tour.townCount = townCount;
        }

        public int getFirstVisitedTown()
        {
            return visitSeq[0];
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

        public int[] getHamiltoneCycle()
        {
            return visitSeq.Concat(new int[] { visitSeq[0] }).ToArray();
        }

        public int getTourLength()
        {
            return tourLength;
        }

        public void toInitState()
        {
            countOfVisitedTowns = 1;
            tourLength = 0;
            visitedTowns = new bool[townCount];
            visitedTowns[visitSeq[0]] = true;
        }
    }


    class Ant
    {
        private Tour tour;
        private static Nullable<Tour> bestTour;

        public Ant(int startTown)
        {
            this.tour = new Tour(startTown);
        }

        public static void setTownCount(int countTown)
        {
            bestTour = null;
            Tour.setCountTown(countTown);
        }

        public void tryAsBest()
        {
            if (bestTour == null || bestTour.Value.getTourLength() > tour.getTourLength() )
            {
                bestTour = tour;
            }
        }

        public void visitTown(int town, int length)
        {
            tour.visitTown(town, length);
        }

        public void visitCycleTown(int length)
        {
            tour.visitCycleTown(length);
        }

        public int getFirstVisitedTown()
        {
            return tour.getFirstVisitedTown();
        }

        public int getLastVisitedTown()
        {
            return tour.getLastVisitedTown();
        }

        public bool isTownVisited(int town)
        {
            return tour.isTownVisited(town);
        }

        public bool isAllTownsVisited()
        {
            return tour.isAllTownsVisited();
        }

        public static Tour getBestTour()
        {
            return bestTour.Value;
        }

        public void toInitState()
        {
            tour.toInitState();
        }
    }
}
