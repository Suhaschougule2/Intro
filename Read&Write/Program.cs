using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter Your First Name");
        string FirstName = Console.ReadLine();

        Console.WriteLine("Enter Last Last Name");
        string LastName = Console.ReadLine();

        Console.WriteLine("Hello {0} {1}", FirstName, LastName);
        //Console.WriteLine("Hi" + FirstName, LastName);
    }

}