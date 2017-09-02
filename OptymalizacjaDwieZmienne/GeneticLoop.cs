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

        public GeneticLoop()
        {
            mutation = null;
            selection = null;
            population = null;
            crossover = null;
        }

        public GeneticLoop(IMutation mutation, ISelection selection, Population population, ICrossover crossover)
        {
            this.mutation = mutation;
            this.selection = selection;
            this.population = population;
            this.crossover = crossover;
        }

        void loop()
        {
            for (int i = 0; i < Configuration.Size; i++)
            {

            }
        }
    }
}
