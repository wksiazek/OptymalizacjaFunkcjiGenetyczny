using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptymalizacjaDwieZmienne
{
    class SingleArithmeticCrossover : ICrossover
    {
        //alfa*x1+(1-alfa)x2
        //alfa*x2+(1-alfa)x1
        //dla wybranego genu
        private double alfa;
        public SingleArithmeticCrossover(double alfa)
        {
            this.alfa = alfa;
        }
        public Population Crossover(List<Individual> listOfIndividual)
        {
            int randomNumer;
            double x1, y1;
            Population newPopulation = new Population();
            List<Individual> newIndividuals = new List<Individual>();

            while (newIndividuals.Count != Configuration.Size)
            {
                Individual ind1 = listOfIndividual.ElementAt(RandomGenerator.random.Next(0, listOfIndividual.Count));
                Individual ind2 = listOfIndividual.ElementAt(RandomGenerator.random.Next(0, listOfIndividual.Count));
                randomNumer = RandomGenerator.random.Next(0, 100);
                if (randomNumer > Configuration.ProbabilityCrossover)
                {
                    randomNumer = RandomGenerator.random.Next(0, 1);
                    if (randomNumer==0)
                    {
                        x1 = alfa * ind1.X + (1 - alfa) * ind2.X;
                        y1 = alfa * ind1.Y + (1 - alfa) * ind2.Y;
                        Individual newInd1 = new Individual(x1, y1);
                        newIndividuals.Add(newInd1);
                    }
                    else
                    {
                        x1 = alfa * ind2.X + (1 - alfa) * ind1.X;
                        y1 = alfa * ind2.Y + (1 - alfa) * ind1.X;
                        Individual newInd1 = new Individual(x1, y1);
                        newIndividuals.Add(newInd1);
                    }                 
                }
            }
            newPopulation.ListOfIndividual = newIndividuals;
            return newPopulation;
        }
    }
}
