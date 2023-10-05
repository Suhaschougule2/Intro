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




        //Adding Customers in Queue using Queue
        Queue<Customer> QC = new Queue<Customer>();                       
        QC.Enqueue(C1); 
        QC.Enqueue(C2);
        QC.Enqueue(C3);
        QC.Enqueue(C4);
        QC.Enqueue(C5);




        //Remove Customers from Queue using Dequeue
        Customer customer = QC.Dequeue();                                                //gives first item and remove from queue
        Console.WriteLine("ID = {0} & Name = {1}", customer.ID , customer.Name);
        Console.WriteLine("Total Items contain in Queue = " + QC.Count);                  //Count gives remaining present items after deque



        Customer customer2 = QC.Dequeue();
        Console.WriteLine("ID = {0} & Name = {1}", customer2.ID, customer2.Name);
        Console.WriteLine("Total Items contain in Queue = " + QC.Count);



        Customer customer3 = QC.Dequeue();
        Console.WriteLine("ID = {0} & Name = {1}", customer3.ID, customer3.Name);
        Console.WriteLine("Total Items contain in Queue = " + QC.Count);




        Customer customer4 = QC.Dequeue();
        Console.WriteLine("ID = {0} & Name = {1}", customer4.ID, customer4.Name);
        Console.WriteLine("Total Items contain in Queue = " + QC.Count);




        Customer customer5 = QC.Dequeue();
        Console.WriteLine("ID = {0} & Name = {1}", customer5.ID, customer5.Name);
        Console.WriteLine("Total Items contain in Queue = " + QC.Count);                        //Queue is Empty


        Console.WriteLine("----------------------------------------------------------------------------------");

/*
        //Gives Exception
        Customer customer6 = QC.Dequeue();                              
        Console.WriteLine("ID = {0} & Name = {1}", customer6.ID, customer6.Name);
        Console.WriteLine("Total Items contain in Queue = " + QC.Count);
*/









        //using loop 

        foreach(Customer c in QC)
        {
            Console.WriteLine(c.ID + " - " + c.Name);
            Console.WriteLine("Total Items contain in Queue = " + QC.Count);    //Only prints the items not removing
        }









        //dequeue vs peek

        //peek function
        Customer peekC = QC.Peek();

        Console.WriteLine(peekC.ID + " - " + peekC.Name);                                 //Only gives first item without removing
        Console.WriteLine("Total Items contain in Queue = " + QC.Count);
















        // To check if an item, exists in the queue, use Contains() method.
        if (QC.Contains(C1))
        {
            Console.WriteLine("customer1 is in Queue");
        }
        else
        {
            Console.WriteLine("customer1 is not in Queue");
        }



    }









    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
    }
}