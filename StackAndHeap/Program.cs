using System;

public class Program()
{
    static void Main(string[] args)
    {
        // Variable在stack上，首先x先下去，然后y碟盘子
        int x = 101;
        int y = 102;

        // Instance的pointer在stack上，真正的object在heap上
        // Pointer on the stack, object on the heap
        SomeClass cls = new SomeClass();    // new SomeClass(a) allocates memory on heap

        SomeClass cls1;
    }
}   /*这个括号终结时发生什么了？
     * 1. 先clear整个stack，用取盘子的方式来清空memory。
     * 2. Heap的清理会被Garbage Collector搞定。
     */

public class SomeClass
{
}