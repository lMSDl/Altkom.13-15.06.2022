using System.Threading.Tasks;

namespace WPC.DesignPatterns.Behavioral.State
{
    public class HeatingUpState : State
    {
        public HeatingUpState(CoffeeMachine cofeeMachine) : base(cofeeMachine)
        {
            Task.Delay(5000).ContinueWith(x => CoffeeMachine.State = new IdleState(CoffeeMachine));
        }

        public override void Large()
        {
            System.Console.WriteLine("Nie teraz.. Rozgrzewam się..");
        }

        public override void Small()
        {
            Large();
        }
    }
}