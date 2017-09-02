using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptymalizacjaDwieZmienne.Selection
{
    class SelectionRankForMinimum : ISelection
    {
        public List<Individual> Select(Population population)
        {
            List<Individual> listForCrossover = new List<Individual>();
            population.ListOfIndividual = population.ListOfIndividual.OrderBy(a => a.Fitness).ToList();

            for (int i = 0; i < Configuration.Size; i++)
            {
                Individual ind = population.ListOfIndividual.ElementAt(i);
                for (int j = 0; j < Configuration.Size - i; j++)
                {
                    listForCrossover.Add(ind);
                }
            }
            return listForCrossover;
        }
    }
}
