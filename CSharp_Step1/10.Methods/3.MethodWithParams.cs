using System;


class MethodsWithParams
{
    static void Main()
    {
        //string data = Method1(25);
        //Console.WriteLine(data);

        //Method2("John");
        Method3(123);
        Method3("Emp123");
        Method3(false);
    }

    /// <summary>
    ///   Method1 name
    /// </summary>
    /// <param name="number"></param>
    /// <returns>string type</returns>

    static string Method1(int age)
    {
        string employeeName = "John" ;
        string fullDetails =  string.Format("Employee Name {0} and age is {1}", employeeName, age);
        return fullDetails;
    }

    /// <summary>
    /// Method2 is called and name is passed as parameter
    /// </summary>
    /// <param name="name"></param>
    static void Method2(string name)
    {
        Console.WriteLine($"Method2 is called and Name is {name}");
    }


    //var vs dynamic
    //string or int or dynamic

    static void Method3(dynamic empID)
    {
        Console.WriteLine($"dynamic is called and Name is {empID}");
    }



}

