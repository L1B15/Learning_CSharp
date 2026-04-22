using System;

public class Program
{
    static void Main(string[] args)
    {
        Employee employee = new Employee();
        employee.FirstName = "Lu";
        employee.LastName = "Liu";

        // 删除ToString打出来的就是instance的type
        Console.WriteLine(employee.ToString());
    }
}

public class Employee
{
    public string FirstName { get; set; }
    public string LastName { get; set; }


    // 若不override的话打出来的是type不是我的名字
    public override string ToString()
    {
        return FirstName + " " + LastName;
    }
}