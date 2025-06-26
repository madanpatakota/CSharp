using System;


//step4 methods completely we will be work on the methods

//Access Modifiers

//Classes

//step1

/// <summary>
/// 
/// </summary>
class MethodsWithParamsAndReturntypes
{
    static void Main()
    {
       //string employeeDetails =  getEmployeeDetails(10);
       
       //printEmpNamebyId(10);

       //string[] empNames =  getEmployeeNames();

       //string[] otheremployees = { "john", "ada" };

       //int length = getEmpNamesLengthByEmpNames(otheremployees);

       //Console.WriteLine($"Employees Length {length}");

        int[] numbers = { 10, 20 };
        int[] data = getUpdatedNumbers(numbers);

        foreach(int number in data)
        {
            Console.WriteLine(number);
        }

        string[] names = { "Ram" , "Ravi" };
        int[] namesLength = getEmployeesNamesLength(names);

        foreach (int number in namesLength)
        {
            Console.WriteLine(number);
        }
    }

    /// <summary>
    /// HEre i am updating each and every number by adding 2 lvalue
    /// </summary>
    /// <param name="numbers"></param>
    /// <returns></returns>
    static int[] getUpdatedNumbers(int[] numbers)
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = numbers[i] + 2;
        }
        return numbers;
    }


    //Half-hour to 1 hour
    static int[] getEmployeesNamesLength(string[] names)
    {
        int[] lengths = new int[names.Length];

        for(int i=0; i < names.Length; i++)
        {
            lengths[i] = names[i].Length;
        }
        return lengths;

    }


    /// <summary>
    ///   Get EmployeeDetails by empid and returning the employeenee
    /// </summary>
    /// <param name="id"></param>
    /// <returns>employee</returns>
    static string getEmployeeDetails(int id)
    {
        string employeeDetails = $"Employee Name is John And his Id is {id}";
        return employeeDetails;
    }
    //outlookStartDate = "11-12-2024";
    /// <summary>
    /// 
    /// </summary>
    /// <param name="name"></param>
    /// <returns></returns>
    static int getEmpAgeByName(string name)
    {
        return 10; // VVIMP
    }
    static void printEmpNamebyId(int id)
    {
        Console.WriteLine($"Emp Name is John");
    }

    static void PrintEmpDetailsByNameandAge(string Name ,int age)
    {
        Console.WriteLine($"Name is {Name} and Age is {age}");
    }

    static string[] getEmployeeNames()
    {
        string[] names = { "John", "Doe" };
        return names;
    }

    static int getEmpNamesLengthByEmpNames(string[] names)
    {
        int length = names.Length;
        return length;
    }


   

}

