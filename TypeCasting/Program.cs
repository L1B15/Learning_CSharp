namespace CSharpTutorials.NETTutorial;

public class Program
{
    public static void Main(string[] args)
    {
        // Explicit type casting

        double numDouble = 1.23;
        int numInt = (int)numDouble;

        Console.WriteLine(numInt.GetType());





        // Convert class helper methods

        string name = "a";
        char ch = Convert.ToChar(numInt);

        string result = "True";
        bool finalResult = Convert.ToBoolean(result);
        int intResult = 0;
        bool intFinalResult = Convert.ToBoolean(intResult);

        /*
         * ToByte
         * ToDecimal
         * ToDouble
         * ToInt16
         * ToInt32
         * ToInt64
         * ToString
         * ToUInt16
         * ToUInt32
         * ToUInt64
         * 
         * 注意，这上面所有如果出错都是runtime error来着
         */




        /* 用Parse来convert
         * 出错了就是runtime error
         */

        string str = "100";
        int num = int.Parse(str);

        string str2 = "TRUE";
        bool b = bool.Parse(str2);

        // TryParse可以避免runtime error，成功就保存number，不成功返回false

        string str1 = "100";
        bool IsConverted1 = int.TryParse(str1, out int number);


        // Parse和Convert处理null的区别

        string randomNum = null;
        int result1 = int.Parse(randomNum); // ArgumentNullException
        int result2 = Convert.ToInt32(randomNum); // 给的是0而不是报错

    }
}

