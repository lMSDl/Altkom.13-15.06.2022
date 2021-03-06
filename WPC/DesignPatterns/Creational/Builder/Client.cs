using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Builder
{
    public class Client
    {
        public static void Execute()
        {
            var vehicle = new Vehicle(4, 5, 4, 500, 100);
            Console.WriteLine(vehicle);

            var builder = new VehicleBuilder();
            builder.SetDoors(4);
            builder.SetSeats(5);
            builder.SetWheels(4);
            builder.SetEnginePower(100);
            builder.SetTrunkCapacity(500);
            
            vehicle = builder.Build();
            Console.WriteLine(vehicle);

            vehicle.Doors = 0;
            vehicle = builder.Build();
            Console.WriteLine(vehicle);


            vehicle = new VehicleBuilderFacade()
                    .Parts
                        .SetDoors(4)
                        .SetWheels(4)
                        .SetEnginePower(100)
                        .SetTrunkCapacity(500)
                    .Metadata
                        .SetModel("XAA12")
                        .SetProductionDate(DateTime.Now)
                    .Parts
                        .SetSeats(5)
                    .Metadata
                        .SetManufacturer("Altkom")
                     .Build();
            
            Console.WriteLine(vehicle);

            vehicle = new Vehicle { Doors = 4, Seats = 4, TrunkCapacity = 500, EnginePower = 100, Wheels = 4 };
            Console.WriteLine(vehicle);
        }
    }
}
