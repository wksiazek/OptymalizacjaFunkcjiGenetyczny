using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptymalizacjaDwieZmienne
{
    class Program
    {
        static void Main(string[] args)
        {
            //Przygotowanie konfiguracji
            Configuration.X1 = 1.0;
            Configuration.X2 = 1.0;
            Configuration.Y1 = 1.0;
            Configuration.Y2= 1.0;
            Configuration.Size = 100;

            //Wygenerowanie populacji
            Population population = new Population(Configuration.Size);

            //Właściwa pętla algorytmu genetycznego
            GeneticLoop loop = new GeneticLoop(null, null,population,null);         
        }
    }
}
