using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptymalizacjaDwieZmienne.Crossover
{
    //ch3=r(ch2-ch1)+ch2 , r[0,1] potomek jeden, tylko wtedy gdy f(ch2)<f(ch1)
    class HeuristicCrossover : ICrossover
    {
        private double r;
        public HeuristicCrossover(double r)
        {
            this.r = r;
        }
        public Population Crossover(List<Individual> listOfIndividual)
        {
            Population newPopulation = new Population();
            List<Individual> newIndividuals = new List<Individual>();
            double x1, y1;
            int randomNumber;

            while(newIndividuals.Count!=Configuration.Size)
            {
                Individual ind1 = listOfIndividual.ElementAt(RandomGenerator.random.Next(0, listOfIndividual.Count));
                Individual ind2 = listOfIndividual.ElementAt(RandomGenerator.random.Next(0, listOfIndividual.Count));
                randomNumber = RandomGenerator.random.Next(0, 100);
                if (randomNumber > Configuration.ProbabilityCrossover)
                {
                    if (ind1.Fitness >= ind2.Fitness)
                    {
                        x1 = r * (ind2.X - ind1.X) + ind2.X;
                        y1 = r * (ind2.Y - ind1.Y) + ind2.Y;
                        if (x1 > Configuration.X1 && x1 < Configuration.X2 && y1 > Configuration.Y1 && y1 < Configuration.Y2)
                        {
                            Individual newIndividual = new Individual(x1, y1);
                            newIndividuals.Add(newIndividual);
                        }
                    }
                }
            }
            newPopulation.ListOfIndividual = newIndividuals;
            return newPopulation;
        }
    }
}
