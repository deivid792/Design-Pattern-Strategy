public class CreditCardPayment : IPaymentStrategy
{
    public void Pay(decimal amount)
    {
        Console.WriteLine($"Pagamento de {amount:C} realizado com Cartão de Crédito.");
    }
}