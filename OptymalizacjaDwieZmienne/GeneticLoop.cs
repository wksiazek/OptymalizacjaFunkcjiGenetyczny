﻿using OptymalizacjaDwieZmienne.FitnessFunction;
using OptymalizacjaDwieZmienne.Mutation;
using OptymalizacjaDwieZmienne.Selection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptymalizacjaDwieZmienne
{
    class GeneticLoop
    {
        public IMutation mutation;
        ISelection selection;
        Population population;
        ICrossover crossover;
        IFitnessFunction function;
        ComputingTime computingTime;

        List<Individual> listForCrossover;
        public GeneticLoop()
        {
            computingTime = new ComputingTime();
            listForCrossover = new List<Individual>();
            mutation = null;
            selection = null;
            population = null;
            crossover = null;
        }

        public GeneticLoop(IMutation mutation, ISelection selection, Population population, ICrossover crossover,IFitnessFunction function)
        {
            computingTime = new ComputingTime();
            this.mutation = mutation;
            this.selection = selection;
            this.population = population;
            this.crossover = crossover;
            this.function = function;
        }

        public void loop()
        {
            Individual theBest;
            computingTime.StartTime = DateTime.Now;
            for (int i = 0; i < Configuration.NumberGeneration; i++)
            {
                listForCrossover = selection.Select(population);            
                population = crossover.Crossover(listForCrossover);
                mutation.Mutate(population);
                population.ComputeFitness(function,Configuration.Optimization);
                theBest = population.getTheBest();
            }
            computingTime.EndTime = DateTime.Now;
            Console.WriteLine(computingTime.Compute());
            Console.ReadKey();
        }
    }
}
