using OptymalizacjaDwieZmienne.FitnessFunction;
using OptymalizacjaDwieZmienne.Selection;
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
            Configuration.X1 = -3.0;
            Configuration.X2 = 3.0;
            Configuration.Y1 = -3.0;
            Configuration.Y2= 3.0;
            Configuration.Size = 100;
            Configuration.Optimization = true; //maksimum
            Configuration.PercentTheBest = 30;
            Configuration.sizeOfTournament = 2;
            Configuration.NumberGeneration = 100;//liczba iteracji

            //Przygotowanie generatora liczb pseudolosowych
            RandomGenerator random = new RandomGenerator();

            //Wybór funkcji do testowania
            IFitnessFunction function = new Function2();

            //Wygenerowanie populacji
            Population population = new Population(Configuration.Size);
            population.ComputeFitness(function, Configuration.Optimization);

            //Wybor algorytmu selekcji
            ISelection selection = new ModifiedSelectionTournament();

            //Wybor algorytmu krzyżowania
            double alfa = 0.5;
            ICrossover crossover = new WholeArithmeticCrossover(alfa);
            //Właściwa pętla algorytmu genetycznego
            GeneticLoop geneticLoop = new GeneticLoop(null, selection, population, crossover, function);

            geneticLoop.loop();
        }
    }
}
