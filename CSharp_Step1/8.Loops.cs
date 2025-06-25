using System;

class Loops
{

    //Collections
    static void Main()
    {

        //While

        int myIndianCurrentcy = 0;
        Console.WriteLine($"My Indian Currency is Before While Loop :  {myIndianCurrentcy}"); //

        while (myIndianCurrentcy < 5)
        {
            myIndianCurrentcy = myIndianCurrentcy + 1; // Adding 1 rupee coin to the Current currency
        }

        Console.WriteLine($"My Indian Currency is After While Loop :  {myIndianCurrentcy}");


        // i want to Calculate the sum of the value in the container. // 550

        int[] currencyNotesBox = { 50, 100, 100, 100, 200 }; // Assume 100 notes are 3 in the box

        int countingStage = 0;
        int TotalAmount = 0;


        int[] currencyNotesBox1 = { 50, 100, 100 };

        int oput = 50 + currencyNotesBox1[7];
        Console.WriteLine(oput);

       //  
        while (countingStage < currencyNotesBox.Length)
        {
            //Console.WriteLine($"Counting stage {countingStage}");
            //Console.WriteLine($"Counting stage {currencyNotesBox[countingStage]}");
            //Console.WriteLine($"Before Counting Total Amount {TotalAmount}");
            TotalAmount = TotalAmount + currencyNotesBox[countingStage];
            countingStage = countingStage + 1;

        }
        //Console.WriteLine(TotalAmount);

    }
}

