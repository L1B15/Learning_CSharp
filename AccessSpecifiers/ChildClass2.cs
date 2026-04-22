using AssemblyOne;

namespace AssemblyTwo;

// Program.cs instantiated this class
// Child but in different assembly
public class ChildClass2 : FatherClass
{
    Type fatherType = typeof(FatherClass);
   
    // private protected Id: 不能access Id!
    public void Display2()
    {
        Console.WriteLine(fatherType.IsNested);
        Console.WriteLine(Id);
    }
}