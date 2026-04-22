public class Program
{
    static void Main(string[] agrs)
    {
        // 呼叫现在正在跑的thread

        Thread t = Thread.CurrentThread;

        // 给thread命个名呗

        t.Name = "Main Thread";




        /* Single Thread的问题在于只能一个一个跑
          这样很慢的 */

        Method1();
        Method2();
        Method3();

        Console.Read();


        /* 上面那个Single Thread那么慢，看以下
         * 怎么三个一起跑 */

        Thread t1 = new Thread(Method1)     //呼叫constructor创建thread1的instance
        {
            Name = "Thread1"
        };

        Thread t2 = new Thread(Method2)
        {
            Name = "Thread1"
        };

        Thread t3 = new Thread(Method3)
        {
            Name = "Thread1"
        };

        t1.Start();
        t2.Start();
        t3.Start();

        // 在这里放个breakpoint可以打开Debug > Windows > Threads能看到三个Thread的名字
        Console.Read();

    }

    static void Method1()
    {
        int number = 1;
        while (number < 5)
        {
            Console.WriteLine(number);
            number++;
        }
    }

    static void Method2()
    {
        int number = 1;
        while (number < 5)
        {
            Thread.Sleep(1000); // 你给我睡10秒再跑
            Console.WriteLine(number);
            number++;
        }
    }

    static void Method3()
    {
        int number = 1;
        while (number < 5)
        {
            Console.WriteLine(number);
            number++;
        }
    }
}