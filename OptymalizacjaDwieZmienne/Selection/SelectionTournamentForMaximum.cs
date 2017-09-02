using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptymalizacjaDwieZmienne.Selection
{
    //dzielimy populację na grupy składające się z kilku osobników, zazwyczaj 2 lub 3
    class SelectionTournamentForMaximum : ISelection
    {
        public List<Individual> Select(Population population)
        {
            List<Individual> forCrossover = new List<Individual>();

            while(population.ListOfIndividual.Count!=0)
            {
                List<Individual> group = new List<Individual>();
                for (int i=0;i<Configuration.sizeOfTournament;i++)
                {
                    int numerOfIndividual = RandomGenerator.random.Next(0, population.ListOfIndividual.Count);//losujemy osobnika
                    Individual ind = population.ListOfIndividual.ElementAt(numerOfIndividual);
                    group.Add(ind); //dodajemy go do naszej małej grupy
                    population.ListOfIndividual.Remove(ind);//usuwamy go z populacji
                }
                forCrossover.Add(group.OrderByDescending(a => a.Fitness).FirstOrDefault()); //wybieramy najlepszego osobnika z turnieju
            }
            return forCrossover;
        }
    }
}
