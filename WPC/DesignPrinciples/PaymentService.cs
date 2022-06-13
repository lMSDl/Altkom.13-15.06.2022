using System.Collections.Generic;
using System.Linq;

namespace WPC.DesignPrinciples
{
    public class PaymentService
    {
        public bool Charge(PaymentAccount paymentAccount, float amount)
        {
            return paymentAccount?.Charge(amount) ?? false;
        }

        public void Fund(PaymentAccount paymentAccount, float amount)
        {
            paymentAccount?.Fund(amount);
        }
    }
}
