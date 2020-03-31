namespace OpenClosedPrincipleSample.Solution
{
    public abstract class Payment
    {
        public string TransactionNumber { get; set; }
        public abstract string Pay(decimal value, string paymentCode);
    }
}
