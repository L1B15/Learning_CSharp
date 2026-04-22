using System;

public class Program()
{
    static void Main(string[] args)
    {
        /* 什么时候用String或者string:
         *  String - 用来invoke method
         *  string - variable
         */

        /* string是immutable的，所以name变成Lu后
        *  第二个object就会被创建，第一个会进garbage
        *  collection. */
        string name = "Somebody";
        name = "Lu";



        // Convert.ToString和ToString的区别
        SomeClass cls = null;
        cls.ToString();     // 要报错 System.NullReferenceException

        Convert.ToString(cls);  // 不会报错，所以推荐用这个
    }
}

public class SomeClass
{
}