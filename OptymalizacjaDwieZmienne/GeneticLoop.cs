using OptymalizacjaDwieZmienne.Mutation;
using OptymalizacjaDwieZmienne.Selection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptymalizacjaDwieZmienne
{
    class GeneticLoop
    {
        IMutation mutation;
        ISelection selection;
        Population population;
        ICrossover crossover;

        void loop()
        {
            for (int i = 0; i < Configuration.Size; i++)
            {

            }
        }
    }
}
