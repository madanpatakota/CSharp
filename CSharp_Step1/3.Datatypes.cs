using System;

class DatatypesMinMax
{
    static void Main()
    {

        //Display the max and min values of numeric datatypes

        //Console.WriteLine("byte Max Value " + byte.MaxValue);
        //Console.WriteLine("byte Min Value " + byte.MinValue);



        //${________________________________________________}
        //String interpolation
        // Display the maximum and minimum values using string interpolation
        Console.WriteLine($"byte datatype MaxValue: {byte.MaxValue} and MinValue: {byte.MinValue}");
        Console.WriteLine($"short datatype MaxValue: {short.MaxValue} and MinValue: {short.MinValue}");
        Console.WriteLine($"ushort datatype MaxValue: {ushort.MaxValue} and MinValue: {ushort.MinValue}");
        Console.WriteLine($"uint datatype MaxValue: {uint.MaxValue} and MinValue: {uint.MinValue}");
        Console.WriteLine($"ulong datatype MaxValue: {ulong.MaxValue} and MinValue: {ulong.MinValue}");
        Console.WriteLine($"float datatype MaxValue: {float.MaxValue} and MinValue: {float.MinValue}"); // 3.402823E+38 means 3.402823*10^38 (10 to the power of 38)
        Console.WriteLine($"decimal datatype MaxValue: {decimal.MaxValue} and MinValue: {decimal.MinValue}");
        Console.WriteLine($"double datatype MaxValue: {double.MaxValue} and MinValue: {double.MinValue}"); // double has a greater range than int
        Console.WriteLine($"int datatype MaxValue: {int.MaxValue} and MinValue: {int.MinValue}");
        Console.WriteLine($"long datatype MaxValue: {long.MaxValue} and MinValue: {long.MinValue}");


        Console.WriteLine($"decimal datatype MaxValue: {decimal.MaxValue} and MinValue: {decimal.MinValue}");
        Console.WriteLine($"flaot datatype MaxValue: {float.MaxValue} and MinValue: {float.MinValue}");
        Console.WriteLine($"double datatype MaxValue: {double.MaxValue} and MinValue: {double.MinValue}");




        //string name = "Csharp";
        //Console.WriteLine($"Course name : {name}");  // Course Name : Csharp

        bool boolValue = true;
        bool anotherBoolValue = false;
        Console.WriteLine("Bool value " + boolValue);


        char charValue = 'A';
        Console.WriteLine("Charcter :" + charValue);
        char anotherCharValue = ' ';

        string stringVAlue = "Hello , World";
        string anotherStringVAlue = "123455fgffd%%%%  ))(";
        Console.WriteLine("String :" + stringVAlue);




        Console.ReadLine();






    }
}

