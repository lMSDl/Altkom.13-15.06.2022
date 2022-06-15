namespace WPC.DesignPatterns.Behavioral.State
{
    public class IdleState : State
    {
        public IdleState(CoffeeMachine cofeeMachine) : base(cofeeMachine)
        {
        }

        public override void Large()
        {
            System.Console.WriteLine("Duża kawa");
            CoffeeMachine.State = new WorkingState(CoffeeMachine, 7000);
        }

        public override void Small()
        {
            System.Console.WriteLine("Mała kawa");
            CoffeeMachine.State = new WorkingState(CoffeeMachine, 4000);
        }
    }
}