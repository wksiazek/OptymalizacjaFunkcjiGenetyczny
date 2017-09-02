using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptymalizacjaDwieZmienne.Selection
{
    class SelectionTheBestForMaximum : ISelection
    {
        //do krzyżowania idzie tylko % najlepszych osobników czyli o największej wartości funkcji dopasowania
        public List<Individual> Select(Population population)
        {
            List<Individual> listForCrossover = new List<Individual>();
            population.ListOfIndividual = population.ListOfIndividual.OrderByDescending(a => a.Fitness).ToList();

            for (int i = 0; i < Configuration.PercentTheBest; i++)
            {
                Individual ind = population.ListOfIndividual.ElementAt(i);
                listForCrossover.Add(ind);
            }
            return listForCrossover;
        }
    }
}
