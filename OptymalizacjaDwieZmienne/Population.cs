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
                ListOfIndividual.Add(new Individual(Configuration.X1,Configuration.X2,Configuration.Y1,Configuration.Y2));
            }
        }
    }
}
