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
        void safe();
        void read();
    }
}
