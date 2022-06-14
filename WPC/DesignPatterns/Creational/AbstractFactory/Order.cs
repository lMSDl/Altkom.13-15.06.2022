using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.AbstractFactory
{
    public class Order
    {
        public ICar Car { get; private set; }

        public void SelectCar(ICarFactory carFactory, string segment, string type)
        {
            switch(type)
            {
                case "Sedan":
                    Car = carFactory.ManufactureSedan(segment);
                    break;
                case "SUV":
                    Car = carFactory.ManufactureSuv(segment);
                    break;
            }
        }
    }
}
