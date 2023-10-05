//Assignment Operator =
//Arithmetic Operators like +,-,*,/,% 
//Comparison Operators like ==, !=,>, >=, <, <= 
//Conditional Operators like &&, ||
//Ternary Operator ?:
//Null Coalescing Operator ?? 

using System;
class Program
{
    static void Main()
    {
        int num1 = 10;
        int num2 = 2;

        int result = num1 + num2;
        Console.WriteLine("Result = {0}" , result);

        int result1 = num1 - num2;
        Console.WriteLine("Result = {0}", result1);

        int result2 = num1 * num2;
        Console.WriteLine("Result = {0}", result2);

        int result3 = num1 / num2;
        Console.WriteLine("Result = {0}", result3);

        int result4 = num1 % num2;
        Console.WriteLine("Result = {0}", result4);



        if (num1 == 10 && num2 == 2) //(num1 == 10 || num ==2)
        {
            Console.WriteLine("True");
        }


        if (num1 != 10 )
        {
            Console.WriteLine("num1 is 10");
        }




        bool isnumber10;

        if (num1 == 10)
        {
            isnumber10 = true;
        }
        else
        {
            isnumber10 = false;
        }
        Console.WriteLine("num1 is= {0}", isnumber10);


        bool isnumber11 = num2 == 20 ? true : false;  //Ternary operator
        Console.WriteLine("num2 is= {0}", isnumber11);


    }
}