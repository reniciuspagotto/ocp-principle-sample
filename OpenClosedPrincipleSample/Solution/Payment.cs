namespace OpenClosedPrincipleSample.Solution
{
    public abstract class Payment
    {
        public decimal TransactionNumber { get; set; }
        public abstract string Pay(decimal value, string paymentCode);
    }
}
