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

        //string Interpolation
        string name = "Alice";
        int age = 30;
        string message = $"My name is {name} and i am {age} yeals old";

        Console.WriteLine(message);


        string text = "This is a sample string";

        //int length = text.Length; 
        int result = text.Length;
        Console.WriteLine($"{result}");


        string input = "Hello World";

        Console.WriteLine($"{result}");

        string lowerCase =  input.ToLower();
        Console.WriteLine(lowerCase);

        string upperCase = input.ToUpper();
        Console.WriteLine(upperCase);


        string cName = "       Csharp        ";
        string updatedCname =  cName.Trim();
        Console.WriteLine(updatedCname);


        string cName1 = "*******Csharp*********";
        string updatedCname1 = cName1.Trim('*');
        Console.WriteLine(updatedCname1);

        //string cName2 = "*******Csharp*********";
        string updatedCname2 = cName1.TrimEnd('*');
        Console.WriteLine(updatedCname2);


        string updatedCname3 = cName1.TrimStart('*');
        Console.WriteLine(updatedCname3);


        string cName4 = "Csharp";
        string padLeft_CName = cName4.PadLeft(20);
        Console.WriteLine(padLeft_CName);


        string cName5 = "Csharp";
        string padLeft_AddStars_CName = cName5.PadLeft(20,'*');
        Console.WriteLine(padLeft_AddStars_CName);


        string cName6 = "Csharp";
        string padRight_AddStars_CName = cName5.PadRight(20, '*');
        Console.WriteLine(padRight_AddStars_CName);


        //String comparasion

        string password = "Hello1234";
        bool isEquals = password.Equals("Hello1234");
        Console.WriteLine(isEquals);


        string sentence = "The quick brown fox jumps over the lazy dog.";
        string substring = sentence.Substring(4, 5);
        Console.WriteLine(substring);

        //split
        string data = "apple,banana,cherry";
        string[] fruitsList = data.Split(',');
        Console.WriteLine(fruitsList);     //Array


        string original = "The quick brown fox";
        string replaced =  original.Replace("brown", "Red");
        Console.WriteLine(replaced);


        //Format  
        /* interpolation */

        int quantity = 5;
        double price = 9.99;

       string receipt = string.Format("You purcahsed {0} items for {1}" ,
           quantity, quantity*price);
       Console.WriteLine(receipt);




















    }

}

