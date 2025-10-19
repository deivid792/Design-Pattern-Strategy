public class PayPalPayment : IPaymentStrategy
{
    public void Pay(decimal amount)
    {
        Console.WriteLine($"Pagamento de {amount:C} realizado com PayPal.");
    }
}
