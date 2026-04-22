using System;


/// <summary>
/// Abstraction
/// 
/// Two ways to implement abstractiono: 1. User Interface   2.Abstract Class and Methods
/// </summary>
class Program
{
    public static void Main(string[] args) 
    {

        #region Example of no abstraction

        Console.WriteLine("[Bank example with no abstraction]:");

        Bank1 bank1 = new Bank1();
        bank1.WithdrawMoney();

        Bank2 bank2 = new Bank2();
        bank2.WithdrawMoney();

        Console.WriteLine("\n");

        #endregion

        #region Example of abstraction with INTERFACE

        Console.WriteLine("[Bank example with abstraction using interface]:");

        IBank abstractionBank1 = BankFactory.GetBankObject("AbstractionBank1");

        IBank abstractionBank2 = BankFactory.GetBankObject("AbstractionBank2");

        Console.WriteLine("Type of this instance is: " + abstractionBank1.GetType());
        Console.WriteLine("Type of this instance is: " + abstractionBank2.GetType());

        #endregion

        #region Example of abstraction with Abstract Class



        #endregion


    }
}

public class Bank1
{ 
    public void WithdrawMoney()
    {
        Console.WriteLine("Bank1 Withdraw");
    }
}

public class Bank2
{
    public void WithdrawMoney()
    {
        Console.WriteLine("Bank2 Withdraw");
    }
}

public interface IBank
{
    void WithdrawMoney();
}

public class AbstractionBank1: IBank
{
    public void WithdrawMoney()
    {
        Console.WriteLine("AbstractionBank1 withdraw");
    }
}

public class AbstractionBank2: IBank
{
    public void WithdrawMoney()
    {
        Console.WriteLine("AbstractionBank2 withdraw");
    }
}

public static class BankFactory
{
    public static IBank GetBankObject(string BankType)
    {
        IBank BankObject = null;

        if (BankType == "AbstractionBank1")
        {
            BankObject = new AbstractionBank1();
        }
        else if (BankType == "AbstractionBank2")
        {
            BankObject = new AbstractionBank2(); 
        }

        return BankObject;
    }
}