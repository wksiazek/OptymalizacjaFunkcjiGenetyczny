using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptymalizacjaDwieZmienne.Mutation
{
    //mutacja brzegowa- losujemy 0- lewy kraniec przedzialu, 1- prawy kraniec i oczywiście losujemy który gen zmieniamy
    class ShorelineMutation : IMutation
    {
        public void Mutate(Population population)
        {
            int numberGen;
            int randomNumber;
            for (int i = 0; i < Configuration.Size; i++)
            {
                randomNumber = RandomGenerator.random.Next(0, 100);
                if (randomNumber < Configuration.ProbabilityMutation)
                {
                    //losujemy gen który zostanie zmutowany
                    numberGen = RandomGenerator.random.Next(0, 2);
                    if (numberGen == 0)
                    {
                        if (randomNumber == 0)
                        {
                            population.ListOfIndividual.ElementAt(i).X = Configuration.X1;
                        }
                        else
                        {
                            population.ListOfIndividual.ElementAt(i).X = Configuration.X2;
                        }
                    }
                    else
                    {
                        if (randomNumber == 0)
                        {
                            population.ListOfIndividual.ElementAt(i).Y = Configuration.Y1;
                        }
                        else
                        {
                            population.ListOfIndividual.ElementAt(i).Y = Configuration.Y2;
                        }
                    }
                }
            }
        }
    }
}
