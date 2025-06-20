using System;
using System.Runtime.InteropServices.ComTypes;

class DatatypeConversations
{
    static void Main()
    {
        /*
        Implicit Type Conversion (Type Promotion)
        It occurs when you convert a smaller data type into a larger data type without the risk of losing data.

        Datatype    Maximum value  
        Integral Types (Whole Numbers Only)
        byte        0 to 255
        int         ±2,147,483,648 or -2,147,483,648 to +2,147,483,647
        uint        0 to 4,294,967,295  
        long        -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807  
        ulong       0 to 18,446,744,073,709,551,615  

        Floating-Point Types (Fractional Values Allowed)
        decimal     ±79,228,162,514,264,337,593,543,950,335  
        float       ±3.40282347E+38F  
        double      ±1.7976931348623157E+308 
        */


        byte smallNumber = 5;
        int largeNumber = smallNumber;  //Implicitconversation from byto to Int
        Console.WriteLine(largeNumber);


        int NoOfEmployees = 400;
        byte ConvertingNoOfEmployees = (byte)NoOfEmployees;
        Console.WriteLine(ConvertingNoOfEmployees);  // correct result set ????


        double PetrolPrice = 80.45;
        int intVAlue = (int)PetrolPrice;
        Console.WriteLine(intVAlue);


        int number = 42;
        string strNumber = number.ToString();
        Console.WriteLine(strNumber.GetType());



        string strnumber1 = "42";
        int parsedNumber = int.Parse(strnumber1);
        //string strNumber = number.ToString();
        Console.WriteLine(parsedNumber);
        Console.WriteLine(parsedNumber.GetType());


        string strnumber2 = "42";
        int convertNumber = Convert.ToInt32(strnumber2);
        //string strNumber = number.ToString();
        Console.WriteLine(convertNumber);
        Console.WriteLine(convertNumber.GetType());


        //value type numeric types       //ref
        string nullbaleString = null;
        //int output1 = int.Parse(nullbaleString);
        int output1 = Convert.ToInt32(nullbaleString);  //0
        Console.WriteLine(output1);


        DateTime dateTime = DateTime.Now;
        Console.WriteLine(dateTime.ToString());

        string[] strings;

        // value -> ref     => boxing
        // ref   -> value   => unboxing


        /*
          Boxing and Unboxing:
          Boxing is the process of converting a value type to a reference type (e.g., object).
          Unboxing is the reverse process, converting a boxed value back to its original value type.

          Value type: Data stored directly in memory
          Reference type: Reference to data stored in memory
      */

        int a = 10;  // a directly contains the data - 10;
        string b = "Csharp"; // b holds a reference to this string("Csharp") in memory

        //boxing
        int num1 = 42;
        object obj = num1;   //boxing : Here object createt eh referece for stroing the num1 data.
        Console.WriteLine($"Object vaue is {obj}");  // 42


        int num2 = (int)obj;  //unboxing
        Console.WriteLine($"num2 is : {num2}");



        //value type -> ref    => boxing
        //ref        -> value  => unboxing







    }
}

