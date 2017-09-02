using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptymalizacjaDwieZmienne.Selection
{
    class ModifiedSelectionTournament : ISelection
    {
        public List<Individual> Select(Population population)
        {
            List<Individual> listForCrossover = new List<Individual>();
            List<List<Individual>> listGroup = new List<List<Individual>>();

            List<Individual> fromPopulation = population.ListOfIndividual;
            for (int i=0,j= fromPopulation.Count-1;i< fromPopulation.Count/2;i++)
            {
                Individual ind1 = fromPopulation.ElementAt(i);
                Individual ind2 = fromPopulation.ElementAt(j);
                List<Individual> group = new List<Individual>();
                group.Add(ind1);
                group.Add(ind2);
                listGroup.Add(group); //1 osobnik łączymy z ostatnim 
            }

            //najlepszych osobników z pary dodajemy do listy krzyżowanych- uzyskujemy pół listy osobników
            foreach(var x in listGroup)
            {
                if (x.ElementAt(0).Fitness > x.ElementAt(1).Fitness)
                {
                    listForCrossover.Add(x.ElementAt(0));
                }
                else
                {
                    listForCrossover.Add(x.ElementAt(1));
                }                  
            }

            //drugie pół- losowo wybieramy z pary
            foreach (var x in listGroup)
            {
                if(RandomGenerator.random.Next(0,1)==0)
                {
                    listForCrossover.Add(x.ElementAt(0));
                }
                else
                {
                    listForCrossover.Add(x.ElementAt(1));
                }
            }
            return listForCrossover;
        }
    }
}
