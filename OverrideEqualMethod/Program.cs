using System;
using System.Security.Cryptography;

public class Program
{
    static void Main(string[] args)
    {
        Employee employee1 = new Employee();
        employee1.FirstName = "Lu";
        employee1.LastName = "Liu";

        //如果这样的话两个都是TRUE，因为指的是同一个object reference
        //Employee employee2 = employee1;

        Employee employee2 = new Employee()
        {
            FirstName = "Lu",
            LastName = "Liu"
        };

        // ==
        Console.WriteLine($"employee1 = employee2: {employee1 == employee2}");

        // .Equals()
        Console.WriteLine($"employee1 = employee2: {employee1.Equals(employee2)}");
    }
}

public class Employee
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    // Override后你compare的就不是object本身，而是object里的变量
    public override bool Equals(object? obj)
    {
        if (obj == null || !(obj is Employee))
        {
            return false;
        }
        
        // this指的是employee1
        return (this.FirstName == ((Employee)obj).FirstName
                    && this.LastName == ((Employee)obj).LastName);
    }
}