using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptymalizacjaDwieZmienne
{
    class ComputingTime
    {
        public DateTime StartTime;
        public DateTime EndTime;

        public string Compute()
        {
            TimeSpan difference = EndTime - StartTime;
            return "Czas trwania " + difference.Milliseconds.ToString()+" milisekund";
        }
    }
}
