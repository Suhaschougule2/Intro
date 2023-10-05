using System;
using System.Linq.Expressions;

namespace DelegateCalculator
{
    class Program
    {

        
        public delegate void Calculator(double a, double b, string operation);



        public  static void Result (double a, double b, string operation)
        {
            switch (operation)
            {

                case "+":
                    Console.WriteLine("Addition is:" + a + b);
                    break;


                case "-":
                    Console.WriteLine("Subtraction is:" + (a - b));
                    break;

                case "*":
                    Console.WriteLine("Multiplication is:" + a * b);
                    break;

                case "/":
                    Console.WriteLine("Division is:" + a / b);
                    break;


                default:
                    break;
            }

        }



        public  static void Main(string[] args)
        {
            double a;
            double b;
            string choice;

            Console.WriteLine("Enter First & Second Numbers");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            


            Console.WriteLine("Select the operation u want to perform on numbers \n" +
                 "Add = + \n" +
                 "Sub = - \n" +
                 "Multiply = * \n" +
                 "Divide = / \n"
                                    );


            choice = Console.ReadLine();

            Calculator cal = new Calculator(Result);
            cal(a,b,choice);


        }



    }
}