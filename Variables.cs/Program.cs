using System;
using System.Numerics;

public class Program
{
    int normalVal = 100;
    static int staticVal = 100;
    const int constVal = 200;   // const是static by default的
    readonly int readOnlyVal;   // 不一定要initialize, default是0。
                                // Created only once for each instance

    // 用Constructor给ReadOnly设值
    public Program(int readOnlyVal)
    { 
        this.readOnlyVal = readOnlyVal;
    }

    static void Main(string[] args)
    {
        Program program = new Program(22);

        /* Difference between STATIC and CONSTANT：
            Static可以被更改，Constant不行
         */

        staticVal = 20;
        Console.WriteLine(staticVal);



        // ReadOnly 必须用instance来access

        Console.WriteLine(program.readOnlyVal);

        /* CONSTANT和ReadOnly的区别：
         *  Constant是class level的，ReadOnly是instance level的，
         *  级别不一样。
         */
    }

}