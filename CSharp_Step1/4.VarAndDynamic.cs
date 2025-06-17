using System;
class VarAndDynamic
{
    static void Main()
    {


        //

        //
        //var and dynamic keywords

        //int age = 20;
        //age = 30;
        //Console.WriteLine(age.GetType()); // System.Int32

        //string compnayName = "Misard";
        //compnayName = "TCS";
        //Console.WriteLine(compnayName.GetType()); // System.String

        //double price = 13.78d;
        //price = 50.78d;

        //Console.WriteLine(price.GetType());


        //var first = "Hello , world";

        //var v_number = 10;         // compliler int
        //Console.WriteLine(v_number.GetType()); // System.Int32

        //var v_name = "Misard";     // compliler string
        //Console.WriteLine($"v_name Before TCS {v_name.Length}");    //  5
        ////    v_name = 10;

        //v_name = "TCS";
        //Console.WriteLine(v_name.GetType()); // System.Int32 
        //Console.WriteLine($"v_name {v_name.Length}");

        //var v_price = 12.5d;        // compliler double
        //Console.WriteLine(v_price.GetType()); // System.Int32


        //Dynamic 


        dynamic second;


        dynamic d_number = 10;         // compliler int
        Console.WriteLine(d_number.GetType()); // System.Int32

        dynamic d_name = "Misard";     // compliler string
        //d_name = 10;
        Console.WriteLine($"v_name Before TCS {d_name.Length}");    //  5
        //    v_name = 10;

        d_name = "TCS";
        Console.WriteLine(d_name.GetType()); // System.Int32 
        //d_name = 56555;

        Console.WriteLine($"v_name {d_name.Length}");

        dynamic d_price = 12.5d;        // compliler double
        d_price = "Misard";
        Console.WriteLine(d_price.GetType()); // System.Int32

    }
}
