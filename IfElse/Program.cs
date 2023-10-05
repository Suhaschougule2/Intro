using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter Your Number");
        int Usernumber = int.Parse(Console.ReadLine());             //Parse string into int

        if (Usernumber == 1)
        {
            Console.WriteLine("Your Number is 1");
        }

        else if (Usernumber == 2)
        {
            Console.WriteLine("Your Number is 2");
        }
        
        else if (Usernumber == 3)
        {
            Console.WriteLine("Your Number is 3");
        }
        
        else if (Usernumber == 4)
        {
            Console.WriteLine("Your Number is 4");
        }
        
        else if (Usernumber == 5)
        {
            Console.WriteLine("Your Number is 5");
        }
        
        else
        {
            Console.WriteLine("Your Number is Not Between 1-5");
        }
        
        //if (Usernumber != 1 || Usernumber !=2 || Usernumber !=3 || Usernumber !=4 || Usernumber !=5) 
        //{
        //    Console.WriteLine("Your Number is Not Between 1-5");
        //}

        Console.ReadKey();




       /* Console.WriteLine("Enter Your Number");
        int Usernumber1 = int.Parse(Console.ReadLine());             //Parse string into int

        if (Usernumber1 == 10 && Usernumber1 == 20)         //(&& Checked both- & chechked single)    (|| -- |)
        {
            Console.WriteLine("Your Number is 10 or 20");
        }
        else
        {

        }
*/





        //Switch Statement

        
            Console.WriteLine("Enter No for switch");
            int No = int.Parse(Console.ReadLine());
        switch (No)
        {
            case 10:
                Console.WriteLine("Your No is 10");
                break;

            case 20:
                Console.WriteLine("Youe No is 20");
                break;

            case 30:
                Console.WriteLine("Your No is {0}", No);
                break;

            default:
                Console.WriteLine("No is not 10,20,30");
                break;

        }
    }
}
