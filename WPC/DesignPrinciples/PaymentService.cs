using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPrinciples
{
    public class PaymentService
    {
        private ICollection<PaymentAccount> PaymentAccounts { get; } = new List<PaymentAccount> { new PaymentAccount(1), new PaymentAccount(2), new PaymentAccount(3), new PaymentAccount(4), new PaymentAccount(5) };

        public bool DeletePaymentAccount(PaymentAccount paymentAccount)
        {
            return PaymentAccounts.Remove(paymentAccount);
        }

        public PaymentAccount FindByAllowedDebit(float allowedDebit)
        {
            return PaymentAccounts.SingleOrDefault(x => x.AllowedDebit == allowedDebit);
        }

        public bool Charge(int id, float amount)
        {
            var paymentAccount = PaymentAccounts.SingleOrDefault(x => x.Id == id);
            if (paymentAccount == null)
                return false;

            if (paymentAccount.Income - paymentAccount.Outcome + paymentAccount.AllowedDebit < amount)
                return false;

            paymentAccount.Outcome += amount;
            return true;
        }

        public void Fund(int id, float amount)
        {
            var paymentAccount = PaymentAccounts.Where(x => x.Id == id).SingleOrDefault();
            if (paymentAccount == null)
                return;
            paymentAccount.Income += amount;
        }

        public float? GetBalance(int id)
        {
            var paymentAccount = PaymentAccounts.Where(x => x.Id == id).SingleOrDefault();
            return paymentAccount?.Income - paymentAccount?.Outcome;
        }
    }
}
