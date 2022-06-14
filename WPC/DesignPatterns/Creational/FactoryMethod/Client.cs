using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.FactoryMethod
{
    public class Client
    {
        public static void Execute()
        {
            var elevator = new Elevator();


            string op = ReadOperation();
            int floor = ReadFloor();

            //IElevatorOperation operation;
            //switch (op)
            //{
            //    case "Up":
            //        operation = new ElevatorUp();
            //        break;
            //    case "Down":
            //        operation = new ElevatorDown();
            //        break;
            //    default:
            //        operation = null;
            //        break;
            //}

            //if(operation != null)
            //    elevator.Execute(operation, floor);

            if (op != null)
                elevator.Execute(op, floor);


            elevator.Execute("Down", 3);

            elevator.Execute("Up", 2);

            elevator.Execute("Down", 12);
        }

        private static int ReadFloor()
        {
            return 14;
        }

        private static string ReadOperation()
        {
            return "GoTo";
        }
    }
}
