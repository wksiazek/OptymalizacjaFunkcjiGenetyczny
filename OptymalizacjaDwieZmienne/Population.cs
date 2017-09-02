using OptymalizacjaDwieZmienne.FitnessFunction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptymalizacjaDwieZmienne
{
    class Population
    {
        public List<Individual> ListOfIndividual=new List<Individual>();
        public Population(int size)
        {
            for(int i=0;i<size;i++)
            {
                Individual individual = new Individual(Configuration.X1, Configuration.X2, Configuration.Y1, Configuration.Y2);
                ListOfIndividual.Add(individual);
            }
        }

        public void ComputeFitness(IFitnessFunction function, bool optimization)
        {
            if (optimization)
            {
                for (int i = 0; i < ListOfIndividual.Count; i++)
                {
                    Individual individual = ListOfIndividual.ElementAt(i);
                    individual.Fitness = function.ComputeMaximum(individual.X, individual.Y);
                }
            }
            else
            {
                for (int i = 0; i < ListOfIndividual.Count; i++)
                {
                    Individual individual = ListOfIndividual.ElementAt(i);
                    individual.Fitness = function.ComputeMinimum(individual.X, individual.Y);
                }
            }
        }

        public Individual getTheBest()
        {
            return ListOfIndividual.OrderBy(a => a.Fitness).FirstOrDefault();
        }
        public Individual getTheWorst()
        {
            return ListOfIndividual.OrderByDescending(a => a.Fitness).FirstOrDefault();
        }
    }
}
