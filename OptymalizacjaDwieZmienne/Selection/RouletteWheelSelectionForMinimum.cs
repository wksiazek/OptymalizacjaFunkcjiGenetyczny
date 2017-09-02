using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptymalizacjaDwieZmienne.Selection
{
    class RouletteWheelSelectionForMinimum
    {
        public List<Individual> Select(Population population)
        {
            List<Individual> listForCrossover = new List<Individual>();
            List<Individual> rouletteWheel = new List<Individual>();

            double sumOfFitnessFunction = population.ListOfIndividual.Sum(a => a.Fitness);

            double theWorstIndividual = population.getTheWorst().Fitness;
            int countIndividual;
            foreach (Individual x in population.ListOfIndividual)
            {
                countIndividual = Convert.ToInt32(theWorstIndividual - (x.Fitness + 1) / (sumOfFitnessFunction + 1) * Configuration.Size);
                for (int i = 0; i < countIndividual; i++)
                {
                    rouletteWheel.Add(x);
                }
            }

            //Przygotowanie listy osobników do krzyżowania
            Random random = new Random();
            int randomNumer;
            for (int i = 0; i < Configuration.Size; i++)
            {
                randomNumer = random.Next(0, rouletteWheel.Count);
                listForCrossover.Add(rouletteWheel.ElementAt(randomNumer));
            }

            return listForCrossover;
        }
    }
}
