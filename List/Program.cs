using System;

namespace List
{
    public class Program
    {
        public static void Main()
        {

            List<int> numbers = new List<int>() { 1,3,5,6,4};

            Console.WriteLine("Before");

            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }


            numbers.Sort();

            Console.WriteLine("After");

            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            numbers.Reverse();
            Console.WriteLine("Reverse");

            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }





            Customer customer1 = new Customer()
            {
                ID = 100,
                Name = "XYZ",
                Salary = 1000
            };


            Customer customer2 = new Customer()
            {
                ID = 101,
                Name = "MNQ",
                Salary = 3000
            };


            Customer customer3 = new Customer()
            {
                ID = 102,
                Name = "ABC",
                Salary = 2000
            };


            List <Customer> customers = new List<Customer>(2);
            customers.Add(customer1);           //index 0
            customers.Add(customer2);           //index 1
            customers.Add(customer3);           //index 2



            Customer c = customers[0];     //0 indicate customer 1 in list
            Console.WriteLine("ID = {0}, Name ={1}, Salary = {2}",c.ID, c.Name,c.Salary);
            Console.WriteLine("-----------------------------------------------------------------------------------");



            for (int i = 0; i < customers.Count; i++)
            {
                Customer C = customers[i];
                Console.WriteLine("ID = {0}, Name ={1}, Salary = {2}", C.ID, C.Name, C.Salary);
            }


/*

            //Insert() Function
            customers.Insert(0, customer3);          //insert customer3 at first
            Console.WriteLine(customers.IndexOf(customer3));                  //prints the new index of customer 3

*/


            //true for all function
            Console.WriteLine("All Salaries greter than 1000 =" + 
            customers.TrueForAll(x => x.Salary > 1000));












            //Sort the List using Salary


            Console.WriteLine("Before Sorting");
            foreach (Customer cc in customers)
            {
                Console.WriteLine(cc.Salary);
            }


            customers.Sort();

            Console.WriteLine("After Sorting");
            foreach (Customer cc in customers)
            {
                Console.WriteLine(cc.Salary);
            }


            customers.Reverse();

            Console.WriteLine("Decending Order");
            foreach (Customer cc in customers)
            {
                Console.WriteLine(cc.Salary);
            }











            



            //Sort by Name

            Console.WriteLine("Before");
            foreach (Customer cc in customers)
            {
                Console.WriteLine(cc.Name);
            }

            SortByName sortbyname = new SortByName();
            customers.Sort(sortbyname);

            Console.WriteLine("After");
            foreach (Customer cc in customers)
            {
                Console.WriteLine(cc.Name);
            }
        }
    }

    public class Customer : IComparable<Customer>                  //use for sort the items list
    {

        public int ID { get; set; }

        public string Name { get; set; }

        public int Salary { get; set; }




        //for sorting list 
        public int CompareTo(Customer other)
        {
            return this.Salary.CompareTo(other.Salary);
        }
    }







    //Sort by Name
    public class  SortByName : IComparer<Customer>
    {
        public int Compare (Customer x, Customer y)
        {
            return x.Name.CompareTo(y.Name);
        }
    }
}

//List Functions

//Contains() -- by passing object -- checks item exists in list
//Exists() -- based on condition -- checks item exists in list
//Find() -- Search item that matches to condition and return only first match item
//Findlast() -- Search item that matches to condition and return only Last match item
//FinalAll -- return all items
//FindIndex -- returns only first match item index
//FindLastIndex -- returns only last match item index 


//Ranges

//Addrange() -- Add() allows one item at end of list
// where as this method allows add another list of items 

//Getrange() -- //index gives only one 
//returns List of item index

//InsertRange() -- this method allows add another list of items in list at specified index (by passing index number)

//Remove() -- only one matching item remove
//RemoveAt() -- remove item at specified index
//RemoveAll() -- All remove
//RemoveRange() -- Specified index items removed


//sort() -- sorting the item   ascending order
//reverse() -- decending order

//TrueforAll() -- return bool value whether all items are match to condition
//AsReadOnly -- Only reads