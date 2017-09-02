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
        public IMutation mutation;
        ISelection selection;
        Population population;
        ICrossover crossover;

        List<Individual> listForCrossover;
        public GeneticLoop()
        {
            listForCrossover = new List<Individual>();
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

        public void loop()
        {
            for (int i = 0; i < Configuration.Size; i++)
            {
                listForCrossover = selection.Select(population);
            }
            int a = 1;
        }
    }
}
