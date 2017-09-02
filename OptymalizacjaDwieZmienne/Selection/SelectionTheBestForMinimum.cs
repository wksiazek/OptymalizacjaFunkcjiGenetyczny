using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptymalizacjaDwieZmienne.Selection
{
    class SelectionTheBestForMinimum : ISelection
    {
        public List<Individual> Select(Population population)
        {
            List<Individual> listForCrossover = new List<Individual>();
            population.ListOfIndividual = population.ListOfIndividual.OrderBy(a => a.Fitness).ToList();

            for(int i=0;i<Configuration.PercentTheBest; i++)
            {
                Individual ind = population.ListOfIndividual.ElementAt(i);
                listForCrossover.Add(ind);
            }
            return listForCrossover;
        }
    }
}
