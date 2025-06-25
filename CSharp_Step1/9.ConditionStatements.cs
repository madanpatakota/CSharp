
using System;
using System.Data.Common;
using System.Runtime.InteropServices;

/// <summary>
/// Conditional statements in C# allow you to control the flow of your program based on
/// certain condition and expression(s). 
/// They enable you to execute specific code blocks if certain conditions are met. 
/// 
/// Set of statements executes based on the condition.
/// 
/// Below method having the main Method which is hte entry point
/// </summary>
class ConditionalStatements
{
    static void Main()
    {

        //if(true)
        //{
        //    Console.WriteLine("10 is greater than 5.");
        //}

        //if (7>5)
        //{
        //    Console.WriteLine("10 is greater than 5.");
        //}

        if (10 > 5)
        {
            Console.WriteLine("10 is greater than 5.");
        }


        //int Age = 10;

        //Console.WriteLine(Age == 10);   // true
        //Console.WriteLine(Age > 10 );   // false
        //Console.WriteLine(Age < 10);    // false
        //Console.WriteLine(Age <= 10);   // true
        //Console.WriteLine(Age >= 10);   // true
        //Console.WriteLine(Age != 10);   // false






        // (4 + 5) > 3;

        // (Age > 5)
        int Age = 10;
        if (Age > 5)
        {
            Console.WriteLine("10 is greater than 5.");
        }

        // Task complete
        int Age1 = 9;
        if ((Age1 > 5) && (Age1 > 3))
        {
            Console.WriteLine("Age is Here greater than 5 and 3");
        }


        int Age2 = 8;
        if ((Age2 > 5) || (Age2 > 3))
        {
            Console.WriteLine("Age is Here greater than 5 or greater than 3");
        }


        //Console.WriteLine(Age == 10);   // true
        //string employeeName = "John";
        //if (employeeName == "John")
        //{
        //    // i would like to excute few statements..
        //    Console.WriteLine("John is working in Microsoft");
        //    Console.WriteLine("John is from UK");
        //    Console.WriteLine("John Age is 30");
        //}

        Console.WriteLine("------------------------------------------------------------------");

        string employeeName = "John";    
        //let it be or incase if employeen name ram i want to excute the some code incase empname is ram
        //Lakshmi
        
        if (employeeName == "John")
        {
            // i would like to excute few statements..
            Console.WriteLine("John is working in Microsoft");
            Console.WriteLine("John is from UK");
            Console.WriteLine("John Age is 30");
        }
        else if(employeeName == "Ram")
        {
            Console.WriteLine("Ram is working in Google");
            Console.WriteLine("Ram is from India");
            Console.WriteLine("Ram Age is 28");
        }
        else if(employeeName == "Lakshmi")
        {
            Console.WriteLine("Lakshmi is working in TCS");
            Console.WriteLine("Lakshmi is from India");
            Console.WriteLine("Lakshmi Age is 26");
        }
        else
        {
            Console.WriteLine("He/she is not John or Ram or Lakshmi");
        }



        Console.WriteLine("------------------------------------------------------------------");

        int num3 = 3;  
        if (num3 > 5)
        {
            Console.WriteLine("Number is greater than 5.");
        }
        else if (num3 == 5)
        {
            Console.WriteLine("Number is equal to 5.");
        }
        else
        {
            Console.WriteLine("Server is done!!!!!!!!");
        }

        //are you sure???


        string bankName = "HDFC";
        int Amount = 10000;


        if (bankName == "HDFC" && Amount == 10000)
        {
            //Console.WriteLine($"You are having {Amount}Rs in {bankName} ");
           string textMessage = string.Format("You are having {0}Rs in {1} " , Amount , bankName);
        }
        else
        {
            Console.WriteLine("Some thing is wrong. Please check after some time.");
        }

        Console.WriteLine("---------------------------------------------------------------");




        /*Switch......case*/

        int day = 9999999;
        
        string dayName;

        switch (day)
        {
            case 1:
                dayName = "Monday";
                break;
            case 2:
                dayName = "Tuesday";
                break;
            case 3:
                dayName = "Wednesday";
                break;
            case 4:
                dayName = "Monday";
                break;
            case 5:
                dayName = "Tuesday";
                break;
            case 6:
                dayName = "Wednesday";
                break;
            case 7:
                dayName = "Wednesday";
                break;
            default:
                dayName = "unknown number please try again between 1-7";
                break;
        }

        Console.WriteLine(dayName);


        //string role = "Fresher";
        string role = Console.ReadLine();
        
        string location = "US";

        string salary;

        switch (role)
        {
            case "Fresher":
                if (location  == "Ind")
                {
                    salary = "18k";
                }
                else if(location == "UK")
                {
                    salary = "800";
                }
                else
                {
                    salary = "Location is not availble.Please enter either Ind or UK";
                }
              break;
            case "Software Engineer":
                salary = "90k";
                break;
            case "Manager":
                salary = "1,50,000k";
                break;
            default:
                salary = "NO Salary";
                break;
        }

        Console.WriteLine(salary);

        //Ternary Operator. ? :


        int num4 = 7;

        //if (num4 > 5)
        //{

        //}
        //else
        //{

        //}

        string result =   num4 > 5 ? "Grethan 5" : "Not Greater than 5";
        Console.WriteLine(result);



    }

}





































