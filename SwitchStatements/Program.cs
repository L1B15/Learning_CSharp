using System;

public class Program
{
    static void Main(string[] args)
    {
        // 普通的SWITCH STATEMENTS
        while (false)
        {
            Console.WriteLine("Type yes, no or something else:");
            string cmd = Console.ReadLine();

            switch (cmd)
            {
                case "yes":
                    Console.WriteLine("command was yes\n");
                    break;  // break is mandatory
                case "no":
                    Console.WriteLine("command failed\n");
                    break;
                default:    // deafult is optional
                    Console.WriteLine("no special responses\n");
                    break;
            }
        }

        // 不太普通的SWITCH STATEMENTS
        while (true)
        {
            Console.WriteLine("Type yes, no or something else:");
            string cmd = Console.ReadLine();

            switch (cmd)
            {
                case "yes":
                case "YES":
                    Console.WriteLine("command was yes\n");
                    break;  // break is mandatory
                case "no":
                    Console.WriteLine("command failed\n");
                    break;
                default:
                    Console.WriteLine("no special responses\n");
                    break;
            }
        }
    }

}