using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptymalizacjaDwieZmienne.Mutation
{
    //gen zmienia wartość na jedną z przedziału- równomierna
    class UniformMutation : IMutation
    {
        int numberGen;
        public void Mutate(Population population)
        {
            int randomNumber;
            for(int i=0;i<Configuration.Size;i++)
            {
                randomNumber = RandomGenerator.random.Next(0, 100);
                if (randomNumber<Configuration.ProbabilityMutation)
                {
                    //losujemy gen który zostanie zmutowany
                    numberGen = RandomGenerator.random.Next(0, 2);
                    if(numberGen==0)
                    {
                        population.ListOfIndividual.ElementAt(i).X = RandomGenerator.RandomDouble(Configuration.X1, Configuration.X2);
                    }
                    else
                    {
                        population.ListOfIndividual.ElementAt(i).Y = RandomGenerator.RandomDouble(Configuration.Y1, Configuration.Y2);
                    }
                   
                }
            }
        }
    }
}
