using System;

namespace OpenClosedPrincipleSample.Solution
{
    public class BankSlip : Payment
    {
        public override string Pay(decimal value, string paymentCode)
        {
            // Realiza o pagamento

            return TransactionNumber = Guid.NewGuid().ToString();
        }
    }
}
