namespace WPC.DesignPrinciples
{
    public class PaymentAccount
    {
        public float Income { get; private set; }
        public float Outcome { get; private set; }
        public float AllowedDebit { get; set; }
        private float Balace => Income - Outcome;

        public bool Charge(float amount)
        {
            if (Balace + AllowedDebit < amount)
                return false;

            Outcome += amount;
            return true;
        }

        public void Fund(float amount)
        {
            Income += amount;
        }
    }
}
