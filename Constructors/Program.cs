using System;

/// <summary>
/// Construtcor
/// </summary>
public class Program()
{
    /* 如果class没constructors下面三个会被内置constructor设置为default value,
     * 这个就是implicit constructor, compiler自己干事不管它。
     */
    int i;
    static string s;
    static bool b;


    /* 1. STATIC CONSTRUCTOR不能parameterized
       即使有static, compiler还是会创建一个implicit constructor。
       2. 不需要呼叫，只要class一跑它第一个就会跑。
       3. Will be invoked only once
    */
    static Program()
    {
        Program program = new Program();
        program.i = 29;
        s = "Hi";
    }

    static void Main(string[] args)
    {
        // 0, null, false
        //Console.WriteLine($"{i}, {s}, {b}");

        Program program = new Program();
        Console.WriteLine($"{program.i}, {s}");


        // 下面copy consturctor的例子
        CopyConstructorExample original = new CopyConstructorExample("Lu",29);
        CopyConstructorExample copy = new CopyConstructorExample(original);

        Console.WriteLine(copy.Name + copy.Age);  // Lu29

        // 不能access因为这个class有个private constructor
        PrivateConstructorExample pv = new PrivateConstructorExample();
    }
}

// COPY CONSTRUCTOR
public class CopyConstructorExample
{
    public string Name;
    public int Age;

    public CopyConstructorExample(string name, int age)
    {
        this.Name = name;
        this.Age = age;
    }

    public CopyConstructorExample(CopyConstructorExample copy)
    {
        this.Name = copy.Name;
        this.Age = copy.Age;
    }
}

/*  
 *  Class如果改成sealed里面child class也不能inherit它了
 */
public class PrivateConstructorExample
{
    private PrivateConstructorExample()
    {
        
    }

    /* 这个class是PrivateConstructor的inner class,
       所以就算是private constructor也可以inherit,  */
    class PrivateConstructorChild : PrivateConstructorExample
    {

    }
}
