using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.FactoryMethod
{
    public class Elevator
    {

        private Dictionary<string, IElevatorOperation> _operations = new Dictionary<string, IElevatorOperation>();

        public Elevator()
        {
            var type = typeof(IElevatorOperation);

            _operations = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(x => x.GetTypes())
                .Where(x => !x.IsInterface)
                .Where(x => type.IsAssignableFrom(x))
                .Select(x => (IElevatorOperation)Activator.CreateInstance(x))
                .ToDictionary(x => x.GetType().Name.Substring(nameof(Elevator).Length));

        }

        public void Execute(IElevatorOperation operation, int floor)
        {
            operation.Operate(floor);
        }

        public void Execute(string operation, int floor)
        {
            Execute(GetOperation(operation), floor);
        }

        public IElevatorOperation GetOperation(string operationName)
        {
            if(_operations.TryGetValue(operationName, out var operation)) {
                return operation;
            }

            switch (operationName)
            {
                case "Up":
                    operation = new ElevatorUp();
                    break;
                case "Down":
                    operation = new ElevatorDown();
                    break;
                case "GoTo":
                    operation = new ElevatorGoTo();
                    break;
                default:
                    operation = null;
                    break;
            }

            _operations[operationName] = operation;

            return operation;
        }
    }
}
