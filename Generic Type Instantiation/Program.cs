using System;

//ref link:https://www.youtube.com/watch?v=wMRcCGgGWn4&list=PLRwVmtr-pp05ETzLYQ8kv1cI5v9ddT8er&index=6
//

class MyClass<T>
{
    public static int Value;
    static  MyClass()
    {
        Console.WriteLine(typeof(MyClass<T>));
    }
}

class MainClass
{
    static void Main()
    {    
        MyClass<string>.Value = 10;
        MyClass<char>.Value = 20;
        MyClass<MainClass>.Value = 53;
        Console.WriteLine(MyClass<string>.Value);
        Console.WriteLine(MyClass<char>.Value);
        Console.WriteLine(MyClass<MainClass>.Value);
    }
}