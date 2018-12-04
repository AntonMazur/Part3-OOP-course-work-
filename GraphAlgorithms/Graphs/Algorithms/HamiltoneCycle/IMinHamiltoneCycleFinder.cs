using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GraphAlgorithms.Graphs.Algorithms.HamiltoneCycle
{
    interface IMinHamiltoneCycleFinder
    {

        (int[], int) findHamiltoneCycle();

    }
}
