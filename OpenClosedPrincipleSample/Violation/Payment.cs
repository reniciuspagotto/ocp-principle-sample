namespace OpenClosedPrincipleSample.Violation
{
    public class Pagamento
    {
        public void Pay(decimal value, string paymentCode, EPaymentType ePaymentType)
        {
            if (ePaymentType == EPaymentType.Dinheiro)
            {
                // Aplicar 10% desconto
                // Efetivar o pagamento
            }
            else if (ePaymentType == EPaymentType.Boleto)
            {
                // Efetivar o pagamento
            }
        }
    }
}
