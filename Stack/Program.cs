using System;
using System.Globalization;

public class Program
{
    public static void Main()
    {
        Customer C1 = new Customer()
        {
            ID = 01,
            Name = "ABC",
            Gender = "Male"
        };


        Customer C2 = new Customer()
        {
            ID = 02,
            Name = "DEF",
            Gender = "Female"
        };


        Customer C3 = new Customer()
        {
            ID = 03,
            Name = "GHI",
            Gender = "Male"
        };


        Customer C4 = new Customer()
        {
            ID = 04,
            Name = "JKL",
            Gender = "Female"
        };


        Customer C5 = new Customer()
        {
            ID = 05,
            Name = "MNQ",
            Gender = "Male"
        };




        //Adding Customers in Stack using Push
        Stack<Customer> SC = new Stack<Customer>();
        SC.Push(C1);
        SC.Push(C2);
        SC.Push(C3);
        SC.Push(C4);
        SC.Push(C5);




        //Remove Customers from Stack using Pop
        Customer customer = SC.Pop();                                                //gives first item and remove from stack
        Console.WriteLine("ID = {0} & Name = {1}", customer.ID, customer.Name);
        Console.WriteLine("Total Items contain in Stack = " + SC.Count);                  //Count gives remaining present items after pop



        Customer customer2 = SC.Pop();
        Console.WriteLine("ID = {0} & Name = {1}", customer2.ID, customer2.Name);
        Console.WriteLine("Total Items contain in Stack = " + SC.Count);



        Customer customer3 = SC.Pop();
        Console.WriteLine("ID = {0} & Name = {1}", customer3.ID, customer3.Name);
        Console.WriteLine("Total Items contain in Stack = " + SC.Count);




        Customer customer4 = SC.Pop();
        Console.WriteLine("ID = {0} & Name = {1}", customer4.ID, customer4.Name);
        Console.WriteLine("Total Items contain in Stack = " + SC.Count);




        Customer customer5 = SC.Pop();
        Console.WriteLine("ID = {0} & Name = {1}", customer5.ID, customer5.Name);
        Console.WriteLine("Total Items contain in Stack = " + SC.Count);                        //Queue is Empty


        Console.WriteLine("----------------------------------------------------------------------------------");

        /*
                //Gives Exception
                Customer customer6 = SC.Pop();                              
                Console.WriteLine("ID = {0} & Name = {1}", customer6.ID, customer6.Name);
                Console.WriteLine("Total Items contain in Stack = " + QC.Count);
        */









        //using loop 

        foreach (Customer c in SC)
        {
            Console.WriteLine(c.ID + " - " + c.Name);
            Console.WriteLine("Total Items contain in Stack = " + SC.Count);    //Only prints the items ,not removing
        }









        //pop vs peek

        //peek function
        Customer peekC = SC.Peek();

        Console.WriteLine(peekC.ID + " - " + peekC.Name);                                 //Only gives first item without removing
        Console.WriteLine("Total Items contain in Stack = " + SC.Count);
















        // To check if an item, exists in the Stack, use Contains() method.
        if (SC.Contains(C1))
        {
            Console.WriteLine("customer1 is in Stack");
        }
        else
        {
            Console.WriteLine("customer1 is not in Stack");
        }



    }









    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
    }
}