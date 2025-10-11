using System;

class BankAccount
{
  private double _balance;

  public void Deposit(double amount)
  {
    
      if (amount > 0)
            _balance += amount;
    }

    public void Withdraw(double amount)
    {
        if (amount > 0 && amount <= _balance)
            _balance -= amount;
        else
            Console.WriteLine("❌ Invalid or insufficient funds!");
    }

    public double GetBalance()
    {
        return _balance;
    }
}

class Program
{
    static void Main()
    {
        BankAccount acc = new BankAccount();
        acc.Deposit(1000);
        acc.Withdraw(200);
        Console.WriteLine($"Current Balance: {acc.GetBalance()}");
    }
}

