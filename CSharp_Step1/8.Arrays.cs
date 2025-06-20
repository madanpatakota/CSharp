using System;

class Arrays
{
    static void Main()
    {
        //numbers  // 2 numbers
        // 1. Creating set of integer values is int array with fixed size.
        int[] numbersGroup = new int[2];
        numbersGroup[0] = 2000;
        numbersGroup[1] = 3000;

        Console.WriteLine($"0th index of the numbersGroup {numbersGroup[0]} ");
        Console.WriteLine($"1st index of the numbersGroup {numbersGroup[1]} ");

        //numbersGroup[2]  = 3000;
        //numbersGroup[3]  = 4000;


        //


        // 1. Creating set of integer values is int array without fixed size.

        int[] numbersContainers_2 = new int[] { 2000, 3000 , 4000, 1, 2 ,3 };
        Console.WriteLine($"0th index of the numbersContainers_2 {numbersContainers_2[0]} ");
        Console.WriteLine($"1st index of the numbersContainers_2 {numbersContainers_2[1]} ");


        //Console.WriteLine($"50th index of the numbersContainers_2 {numbersContainers_2[50]} ");
        int value = numbersContainers_2[1];
        Console.WriteLine(value);  // 3000


        int[] CurrrencyNotes = { 20, 100, 500 };

        //CurrrencyNotes.

        foreach (int CurrrencyNote in CurrrencyNotes)
        {
            Console.WriteLine($"Prining Every Currency Note i.e. : {CurrrencyNote}");
        }


        foreach (int CurrrencyNote in CurrrencyNotes)
        {
            int addCoin = 5;
            int updatdCurrency = CurrrencyNote + addCoin;
            Console.WriteLine($"Prining Every Updated Currency Note i.e. : {updatdCurrency}");
        }


        string[] books = { "MathMatics", "Physics", "Chemistry" };
        int booksLength = books.Length;  //3



        //Console.WriteLine(booksLength);
        //books.Length


        //Delegates ---> Real time work
        //string data = "apple,banana,cherry";
        //string[] fruitsList = data.Split(',');
        //fruitsList.
        //Console.WriteLine(fruitsList);

        //foreach(string fruit in fruitsList)
        //{
        //    Console.WriteLine(fruit);
        //}


        //string[] items  =  data.Split(',');   // "__________________________________";
        ////Console.WriteLine(fruitsList1);
        //foreach (string item in items)
        //{
        //    Console.WriteLine(item);
        //}




        //string abc =  "apple,banana,cherry";
        





    }
}




// Father

// MOther



// Efforts


// 2+ 3+ 4+  

// Real time work   --> Subject & Practice

//1. i want to get the books which is match to the "Maths"              

//2. I want to get the students List whose first name starts with "s"

//2. I want to get the students List whose any charctet cotains with "s"

//3. I want to get the employees List who are from Bengolore


//4. employess List --> List

//5. Managers List  --> List



// 100 Requiremneints


// Data 


// Project    -> Testers


// Technical relted   ->  Videos , Dcouments  - 10 days


// you have to start the work  -> TL









// 1. Data 
// 2. Requirement  --> Very clear
// 3. BA Requirement  --> Very clear
// Last






























// 3. Code 