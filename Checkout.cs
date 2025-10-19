public class Checkout
{
    private readonly IPaymentStrategy _paymentStrategy;

    public Checkout(IPaymentStrategy paymentStrategy)
    {
        _paymentStrategy = paymentStrategy;
    }

    public void ProcessOrder(decimal amount)
    {
        Console.WriteLine("Iniciando processamento do pedido...");
        _paymentStrategy.Pay(amount);
        Console.WriteLine("Pedido finalizado!");
    }
}
