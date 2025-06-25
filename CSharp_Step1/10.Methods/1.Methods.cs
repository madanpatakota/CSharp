
using System;

class Methods
{
    /// <summary>
    ///  Method is a block which we are going to re-use that.
    ///  
    /// /// This is Main Entry
    /// </summary>
    static void Main()
    {
        // i have to decide which method call...
        xyz();
    }

    static void Method1()
    {
        Console.WriteLine("Method1 is called");
    }
    static void Method2()
    {
        Console.WriteLine("Method2 is called");
    }
    static void xyz()
    {
        Method1();
    }
    static void abc()
    {
        Method2();
    }
    static void CallMethodsOfProgram()
    {
        Method1();
        Method2();
    }




}

