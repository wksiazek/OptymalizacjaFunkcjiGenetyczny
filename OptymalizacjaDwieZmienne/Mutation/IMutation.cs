﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptymalizacjaDwieZmienne.Mutation
{
    interface IMutation
    {
        void Mutate(Individual individual);
    }
}
