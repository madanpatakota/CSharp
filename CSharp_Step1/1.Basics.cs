using System;
class FirstProgram
{
    static void Main()
    {
        Console.WriteLine("-----------------------------------------------------");

        Console.WriteLine("*********Main method *********");

        Console.WriteLine("My First Message i.e. Hello World");

        Console.WriteLine("For read the Message Please enter any name");
        

        string value = Console.ReadLine();  //Stop   -- Its waitingng for your word

        Console.WriteLine("Name is: " + value);

        Console.WriteLine("-----------------------------------------------------");

        DisplayMessages();

        Console.WriteLine("-----------------------------------------------------");

        ReadMessages(); //calling method
    }


    static void DisplayMessages()
    {
        Console.WriteLine("*********DisplayMessages method *********");

        Console.WriteLine("Please enter the first name ? ");
        string firstName =  Console.ReadLine();

        Console.WriteLine("Please enter the last name ? ");
        string lastName = Console.ReadLine();

        string FullName = firstName + lastName;
        Console.WriteLine("Your Full Name is: " + FullName);

    }
        



    //Defination
    static void ReadMessages()
    {
        Console.WriteLine("Read Message");
    }



}

