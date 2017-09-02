﻿using OptymalizacjaDwieZmienne.Crossover;
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
            Configuration.Size = 60;
            Configuration.Optimization = true; //maksimum
            Configuration.PercentTheBest = 30;
            Configuration.sizeOfTournament = 2;
            Configuration.NumberGeneration = 600;//liczba iteracji
            Configuration.ProbabilityCrossover = 75;

            //Przygotowanie generatora liczb pseudolosowych
            RandomGenerator random = new RandomGenerator();

            //Wybór funkcji do testowania
            IFitnessFunction function = new Function2();

            //Wygenerowanie populacji
            Population population = new Population(Configuration.Size);
            population.ComputeFitness(function, Configuration.Optimization);

            //Wybor algorytmu selekcji
            ISelection selection = new SelectionTournament();

            //Wybor algorytmu krzyżowania
            double alfa = 0.3;
            ICrossover crossover = new HeuristicCrossover(alfa);
            //Właściwa pętla algorytmu genetycznego
            GeneticLoop geneticLoop = new GeneticLoop(null, selection, population, crossover, function);

            geneticLoop.loop();
        }
    }
}
