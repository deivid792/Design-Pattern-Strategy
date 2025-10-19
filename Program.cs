// Exemplo de uso
public class Program
{
    public static void Main(string[] args)
    {
        Checkout checkoutPix = new Checkout(new PixPayment());
        checkoutPix.ProcessOrder(150);

        Console.WriteLine();

        Checkout checkoutCreditCard = new Checkout(new CreditCardPayment());
        checkoutCreditCard.ProcessOrder(250);
    }
}