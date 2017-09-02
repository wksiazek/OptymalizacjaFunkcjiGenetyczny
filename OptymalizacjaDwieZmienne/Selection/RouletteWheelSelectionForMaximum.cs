using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptymalizacjaDwieZmienne.Selection
{
    class RouletteWheelSelectionForMaximum : ISelection
    {
        public List<Individual> Select(Population population)
        {
            List<Individual> listForCrossover = new List<Individual>();
            List<Individual> rouletteWheel = new List<Individual>();

            double sumOfFitnessFunction = population.ListOfIndividual.Sum(a => a.Fitness);


            //Przygotowanie koła ruletki
            int countIndividual;
            foreach(Individual x in population.ListOfIndividual)
            {
                countIndividual = Convert.ToInt32(x.Fitness / sumOfFitnessFunction* Configuration.Size);
                for(int i=0;i< countIndividual;i++)
                {
                    rouletteWheel.Add(x);
                }
            }

            //Przygotowanie listy osobników do krzyżowania
            Random random = new Random();
            int randomNumer;
            for(int i=0;i<Configuration.Size;i++)
            {
                randomNumer = random.Next(0, rouletteWheel.Count);
                listForCrossover.Add(rouletteWheel.ElementAt(randomNumer));
            }

            return listForCrossover;
        }
    }
}
