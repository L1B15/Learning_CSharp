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

        Console.WriteLine("\n");

        #endregion

        #region Example of abstraction with Abstract Class

        Console.WriteLine("[Bank example with abstraction using abstract class]:");

        IBanc banc1 = BancFactory.GetBancObject("Banc1");
        IBanc banc2 = BancFactory.GetBancObject("Banc2");


        Console.WriteLine("Type of this instance is: " + banc1.GetType());
        Console.WriteLine("Type of this instance is: " + banc2.GetType());

        Console.WriteLine("\n");

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

// interface例子的
public static class BankFactory
{
    public static IBank GetBankObject(string BankType)
    {
        IBank BankObject = null;

        if (BankType == "AbstractionBank1")
        {
            BankObject = new AbstractionBank1();
        }
        if (BankType == "AbstractionBank2")
        {
            BankObject = new AbstractionBank2(); 
        }

        return BankObject;
    }
}

// abstrac class例子
public static class BancFactory
{
    public static IBanc GetBancObject(string BancType)
    {
        IBanc BancObject = null;

        if (BancType == "Banc1")
        {
            BancObject = new Banc1();
        }
        else if (BancType == "Banc2")
        {
            BancObject = new Banc1();
        }

        return BancObject;
    }
}

public abstract class IBanc
{
    public abstract void WithdrawMoney();
}

public class Banc1: IBanc
{
    public override void WithdrawMoney()
    {
        Console.WriteLine("Banc1 withdraw");
    }
}

public class Banc2: IBanc
{
    public override void WithdrawMoney()
    {
        Console.WriteLine("Banc2 withdraw");
    }
}