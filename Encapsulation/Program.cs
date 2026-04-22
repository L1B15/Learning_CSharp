using System;

/// <summary>
/// Encapsulation
/// 
/// Encapsulation is all about data hiding.
/// </summary>

public class Program
{
    static void Main(string[] args)
    {
        #region Encapsulated class example

        try
        {
            Console.WriteLine("[Bank example of encapsulation]:");

            EncapsulatedBank encapsulatedBank = new EncapsulatedBank();

            encapsulatedBank.Balance = -322222;

            Console.WriteLine(encapsulatedBank.name);
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex.Message+ "\n");
        }

        #endregion

        #region Not encapsulated class example

        Console.WriteLine("[Bank example with no encapsulation]:");

        Bank bank = new Bank();
        bank.accountNumber = 111111;
        bank.name = "lakjd";

        Console.WriteLine(bank.accountNumber);
        Console.WriteLine(bank.name);

        #endregion
    }
}

class EncapsulatedBank
{
    /* Advantage of providing variable access via Setter and Getter?
        So that the user-given data can be validated before value
        is stored in variable.*/
    public long accountNumber { get; set; }
    public string name { get; set; }

    private double balance { get; set;}

    /* GetBalance() only returns value of balance,
        it does not give option to set balance.*/
    public double Balance
    {
        get 
        {
            return balance;
        }
        set
        {
            if (value < 0)
            {
                throw new Exception("Exception occurred: none-positive balance not accepted.");
            }
            else
            {
                balance = value;
            }
        }
    }
}

class Bank
{
    public int accountNumber;
    public string name;
}
