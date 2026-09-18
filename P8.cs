using System;

abstract class Payment
{
    // Abstract method
    public abstract double CalculatePayment();
}

class CashPayment : Payment
{
    private double amount;

    public CashPayment(double amount)
    {
        this.amount = amount;
    }

    public override double CalculatePayment()
    {
        return amount;
    }
}

class CardPayment : Payment
{
    private double amount;

    public CardPayment(double amount)
    {
        this.amount = amount;
    }

    public override double CalculatePayment()
    {
        return amount + (amount * 0.02);
    }
}

class P8
{
    static void Main()
    {
        Payment cash = new CashPayment(1000);
        Payment card = new CardPayment(1000);

        Console.WriteLine("Cash Payment: " + cash.CalculatePayment());
        Console.WriteLine("Card Payment: " + card.CalculatePayment());

        Console.WriteLine("=========================");
        Console.WriteLine("Name: Aesh Domadiya");
        Console.WriteLine("Enrollment no.: 24SOECE11008");
    }
}