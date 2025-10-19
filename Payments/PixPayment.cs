public class PixPayment : IPaymentStrategy
{
    public void Pay(decimal amount)
    {
        Console.WriteLine($"Pagamento de {amount:C} realizado via PIX.");
    }
}