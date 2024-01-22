using System;

public abstract class PaymentSystem
{
    public abstract void ProcessPayment(decimal amount);
}

public class CardPayment : PaymentSystem
{
    public override void ProcessPayment(decimal amount)
    {
        Console.WriteLine("Plata online cu cardul");
    }
}

public class PayPalPayment : PaymentSystem
{
    public override void ProcessPayment(decimal amount)
    {
        Console.WriteLine("Plata prin PayPal");
    }
}

public class CryptoPayment : PaymentSystem
{
    public override void ProcessPayment(decimal amount)
    {
        Console.WriteLine("Plata cu wallet crypto");
    }
}
