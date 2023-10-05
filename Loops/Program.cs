//while loop checks the conditions first -- condition is true ,statements within loop are executed
//do while checks the conditions at end of loop. this loop guaranteed execute at once (while is not) 

using System;
class Program
{
    static void Main()
    {
        //do while loop
        String UserChoice = String.Empty;
        do
        {

            //while loop
            Console.WriteLine("Enter Target.....");
            int Target = int.Parse(Console.ReadLine());

            int Start = 0;

            while (Start <= Target)
            {
                 Console.WriteLine(Start);                      // Print on New Line
                //Console.Write(Start + "  ");                 //Print On Same Line
                Start = Start + 1;
            }

            

            //do while loop
            do
            {
                Console.WriteLine("Do You Want to Continue - Yes or No?");

                UserChoice = Console.ReadLine().ToUpper();
                if (UserChoice != "YES" && UserChoice != "NO")
                {
                    Console.WriteLine("Invalid Choice, Plz Say Yes or No");
                }
            } while (UserChoice != "YES" && UserChoice != "NO");
        } while (UserChoice == "YES");





        Console.WriteLine("");


        //for loop
        for (int i = 1; i<=10; i++)
        {
            Console.WriteLine(i);
            if (i == 6)
            break;
        }

        Console.WriteLine("");



        //for loop 2
        for (int j = 1; j<=20; j++)
        {
            if (j % 2 == 1)
                continue;
            Console.Write(j + " ");
        }

        Console.WriteLine("");
        Console.WriteLine("");


        //foreach loop
        int[] numbers = new int[4];

        numbers[0] = 1000;
        numbers[1] = 2000;
        numbers[2] = 3000;
        numbers[3] = 4000;

        foreach (int k in numbers)
        {
            
            Console.WriteLine(k);
        }

        Console.WriteLine("");


        //foreach loop 2

        Console.WriteLine("Enter Number:");
        int count = int.Parse(Console.ReadLine());

        int[] number = new int[count];
        int sum = 0;

        foreach (int i in number)
        {
            number[i] = (i + 1) * 10;
          
            sum += number[i];

            Console.WriteLine("Number: {0}", number[i]);

            Console.WriteLine("Sum: {0}", sum);

          //  Console.WriteLine("");
        }
    }
}