﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPC.DesignPatterns.Builder;

namespace WPC.DesignPatterns.Builder
{
    public abstract class BaseBuilder
    {
        protected Vehicle Vehicle { get; }

        protected BaseBuilder() : this(new Vehicle())
        {
        }

        protected BaseBuilder(Vehicle vehicle)
        {
            Vehicle = vehicle;
        }

        public Vehicle Build()
        {
            return (Vehicle)Vehicle.Clone();
        }
    }
}
