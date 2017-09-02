using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptymalizacjaDwieZmienne
{
    class Configuration
    {
        public static bool Optimization; //true maksimum, false minimum
        public static int Size;
        public static double X1;
        public static double X2;
        public static double Y1;
        public static double Y2;
        public static int NumberGeneration;
        public static int ProbabilityMutation;
        public static int ProbabilityCrossover;
        public static int PercentElite;
        public static int PercentTheBest;
        public static int sizeOfTournament;
    }
}
