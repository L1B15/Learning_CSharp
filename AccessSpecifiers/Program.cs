using AssemblyTwo;

/// <summary>
/// ACCESS SPECIFIERS
/// Types - class, interface, structs, delegate, enum, etc (internal by default)
/// Members - variables, properties, constructors, methods
/// Public: members可以被任何人access.
/// Protected: 自家人才可以，自己和儿子
/// Internal: 配置一样就可以
/// Protected Internal: 儿子和配置一样的都可以
/// Private Protected: 儿子配置都要一样
/// </summary>

namespace AssemblyOne;
public class Program()
{
    // members
    private int Id; //variable
    public string Name { get; set; }    //property
    static void Main(string[] args)
    {
        // 可以display FatherClass的id因为和是儿子
        ChildClass cc = new ChildClass();
        cc.Display2();

        // 不可以display FatherClass的id因为不是儿子
        //AnotherClass ac = new AnotherClass();
        //ac.Display2();

        ChildClass2 cc2 = new ChildClass2();
        cc2.Display2();
    }
}

// TYPE只能有两个Levels: internal和public
// internal: 所有儿子必须一样level。
// public: 谁都可以access。
public class FatherClass
{
    private protected int Id = 2;
    public void Display1()
    {
        Console.WriteLine("FatherClass display");
    }
}

// Child in the same assembly as father
public class ChildClass: FatherClass
{
    public void Display2()
    {
        Console.WriteLine(Id);
    }
}

// Not child in the same assemly as father
public class AnotherClass
{
    // protect int id : this class is not allowed to call Id!
    // internal int id : this class is allowed to call Id!
    // protected internal id: 儿子或配置一样的都可以call Id!
    //FatherClass fc = new FatherClass();
    //public void Display2()
    //{
    //    Console.WriteLine(fc.Id);
    //}
}

