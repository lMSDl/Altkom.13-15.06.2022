using System.Collections.Generic;
using System.Linq;

namespace WPC.DesignPrinciples
{
    public class PaymentService
    {
        private ICollection<PaymentAccount> PaymentAccounts { get; } = new List<PaymentAccount> { new PaymentAccount(1), new PaymentAccount(2), new PaymentAccount(3), new PaymentAccount(4), new PaymentAccount(5) };

        public bool Charge(int id, float amount)
        {
            var paymentAccount = FindPaymentAccountById(id);
            if (paymentAccount == null)
                return false;

            if (GetBalance(id) + paymentAccount.AllowedDebit < amount)
                return false;

            paymentAccount.Outcome += amount;
            return true;
        }

        private PaymentAccount FindPaymentAccountById(int id)
        {
            return PaymentAccounts.SingleOrDefault(x => x.Id == id);
        }

        public void Fund(int id, float amount)
        {
            var paymentAccount = FindPaymentAccountById(id);
            if (paymentAccount == null)
                return;
            paymentAccount.Income += amount;
        }

        public float? GetBalance(int id)
        {
            var paymentAccount = FindPaymentAccountById(id);
            return paymentAccount?.Income - paymentAccount?.Outcome;
        }
    }
}
