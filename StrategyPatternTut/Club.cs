﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternTut
{
    public class Club : IWeapon
    {
        public void Use()
        {
            Console.WriteLine("Using club");
        }
    }
}
