using System;

class StringExample
{
    static void Main()
    {
        string strCourseName = "Csharp";   // Csharp

        string strCourseName1 = "\"Csharp\"";  // "Csharp"
        Console.WriteLine(strCourseName1);

        string numberStrings = "One.\nTwo.\nThree";  // "Csharp"
        Console.WriteLine(numberStrings);

        //string myProjectPath = @"D:\Csharp - Training\CSharp\CSharp_Step1";
        string myProjectPath = @"D:\Csharp - Training\\CSharp\\CSharp_Step1\";
        Console.WriteLine(myProjectPath);

        //Interpolation
        string name = "Alice";
        int age = 30;
        string message = $"My name is {name} and i am {age} yeals old";

        Console.WriteLine(message);
        //$""
    }

}

