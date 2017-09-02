using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptymalizacjaDwieZmienne
{
    interface IDatabaseConfiguration
    {
        void connect();
        void safe(string nameFunction, double x, double y, double fitness);
        void read();
    }
}
