using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Prototype
{
    public class Address : ICloneable
    {

        public string City { get; set; }
        public string Street { get; set; }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
