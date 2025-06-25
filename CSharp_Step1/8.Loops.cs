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

        //int oput = 50 + currencyNotesBox1[7];
        //Console.WriteLine(oput);

       //  
        while (countingStage < currencyNotesBox.Length)
        {
            //Console.WriteLine($"Counting stage {countingStage}");
            //Console.WriteLine($"Counting stage {currencyNotesBox[countingStage]}");
            //Console.WriteLine($"Before Counting Total Amount {TotalAmount}");
            TotalAmount = TotalAmount + currencyNotesBox[countingStage];
            countingStage = countingStage + 1;
            Console.WriteLine(TotalAmount);
        }
        //Console.WriteLine(TotalAmount);

        /*
         * 
         *   do-while loop
         *  The do -while loop is similar to the while loop but guarantees that the block of code is executed 
         *  at least once, 
            even if the condition is false initially.It checks the condition at the end of each iteration.
         * 
         * 
         */


        int dw_countingStage = 0;
        int dw_TotalAmount = 0;
        int dw_myIndianCurrentcy = 0;
        int[] dw_currencyNotesBox = { 50, 100, 100 , 200 , 500};

        //do
        //{
        //    dw_TotalAmount = dw_TotalAmount + dw_currencyNotesBox[dw_myIndianCurrentcy];
        //    dw_myIndianCurrentcy = dw_myIndianCurrentcy + 1; //update
        //    Console.WriteLine($"My Indian Currency is Now {dw_TotalAmount}");
        //} while (dw_countingStage < 5);


        do
        {
            if (dw_currencyNotesBox[dw_myIndianCurrentcy] == 100)
            {
                dw_TotalAmount = dw_TotalAmount + dw_currencyNotesBox[dw_myIndianCurrentcy];
                Console.WriteLine($"My Indian Currency is Now {dw_TotalAmount}");
            }
            dw_countingStage = dw_countingStage + 1; //update
        } while (dw_countingStage < 5);


        Console.WriteLine("----------------------------------------------------------------------");


        /*
        * foreach Loop
        *  The foreach loop is used to iterate over elements in a collection (e.g., arrays, lists). 
        *  It automatically iterates through all the elements without needing an index or condition or assignment
        *  Real time enviornment we will follow this syntax..
        */

        int[] numbers = { 1, 2, 3, 4, 5 };       //foreach is each and every value
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }

        string[] CurrencyNames = { "US Dollar", "Indian Rupee", "Kuwaiti Dinar" };
        foreach (string currencyName in CurrencyNames)
        {
            Console.WriteLine(currencyName + "Printed");
        }

        Console.WriteLine("-----------------------------------------------------------------------");



        //int dw_countingStage = 0;
        //int dw_TotalAmount = 0;
        //int dw_myIndianCurrentcy = 0;
        //int[] dw_currencyNotesBox = { 50, 100, 100, 200, 500 };
        
        //        initlization      condition          // Update
        for ( int myCurrency = 1 ;  myCurrency < 10  ;  myCurrency = myCurrency * 3)
        {
            Console.WriteLine(myCurrency + " Note");

            //if(myCurrency == 3)
            //{

            //}
        }




    }

}




//Example :

// SubjectsContainer --> "Csharp" , "Angular" , ".netcore" 


//if is their ---> yes availbale.



//string[] str  = {''SE , SSE , Fresher , Manager , 


//if(str == "SE"){

//    }