using System;

public class OrderProcessor
{
    public void FulfillOrder(Order order, PaymentSystem paymentSystem)
    {
        paymentSystem.ProcessPayment(order.Total);
    }
}