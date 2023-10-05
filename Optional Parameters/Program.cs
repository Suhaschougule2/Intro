using System;
using System.Runtime.InteropServices;

namespace Optionalparameters
{
    public class Program
    {
        public static void Main()
        {
          //AddNumbers(10, 20, 30,40,50);
            AddNumbers(1, 2, new object[] { 3, 4, 5, 6, 7, 8, 9, 10 });







            //method overloading 
            AddNumbers(100, 200, new int[] {300,400});                
        }








        //Optional parameters
        public static void AddNumbers(int firstNumber, int secondNumber, params object[] restOfTheNumbers)           //should be last parameter
        {
            int result = firstNumber + secondNumber;
            foreach (int i in restOfTheNumbers)
            {
                result += i;
            }

            Console.WriteLine("SUM = " + result);
        }











        //Method parameters optional parameters
        public static void AddNumbers(int firstNumber, int secondNumber)
        {
            AddNumbers(firstNumber, secondNumber);
        }

            

        public static void AddNumbers(int firstNumber, int secondNumber, [Optional] int[] restOfTheNumbers)          
        {
            int result = firstNumber + secondNumber;
            foreach (int i in restOfTheNumbers)
            {
                result += i;
            }

            Console.WriteLine("SUM = " + result);
        }
    }
}


