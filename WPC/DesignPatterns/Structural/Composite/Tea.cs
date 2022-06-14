﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Structural.Composite
{
    public class Tea : Leaf
    {
        public Tea(float price) : base(price)
        {
        }

        public override string Name => "Herbata";

    }
}
