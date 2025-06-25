using System;
class MethodsWithReturntypes
{

    // void * non-void 
    static void Main()
    {
       string name =  Method1();   // "John" 
       Console.WriteLine(name);

       int age = Method2();
        Console.WriteLine(age);

        Method3();


    }
    static string Method1()
    {
        string employeeName = "John";
        return employeeName;
    }

    static int Method2()
    {
        int employeeAge = 25;
        return employeeAge;
    }

    static void Method3()  //Print Emp Details
    {
        Console.WriteLine("John is working in Microsoft and his Age is 25.");
    }
}

