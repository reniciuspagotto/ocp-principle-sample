using System;

namespace OpenClosedPrincipleSample.Solution
{
    public class Money : Payment
    {
        public override string Pay(decimal value, string paymentCode)
        {
            // Aplica descontro de 10%
            // Realiza o pagamento

            return Guid.NewGuid().ToString();
        }
    }
}
