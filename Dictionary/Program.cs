using System;
using System.Collections.Generic;

namespace Dictionary
{
    public class Program
    {
        public static void Main()
        {

            Customer customer1 = new Customer()
            {
                ID = 100,
                Name = "ABC",
                Salary = 1000
            };


            Customer customer2 = new Customer()
            {
                ID = 101,
                Name = "MNQ",
                Salary = 2000
            };


            Customer customer3 = new Customer()
            {
                ID = 102,
                Name = "XYZ",
                Salary = 3000
            };

            //dictionary  is a collection of Key Value pair
            //keys must be unique

            Dictionary<int, Customer> dictionaryCustomers = new Dictionary<int, Customer>();        //type -- int =key , value= customer
            dictionaryCustomers.Add(customer1.ID, customer1);           //passing id as key & value as customer1
            dictionaryCustomers.Add(customer2.ID, customer2);
            dictionaryCustomers.Add(customer3.ID, customer3);



            Customer customer102 = dictionaryCustomers[102];
            Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", customer102.ID, customer102.Name, customer102.Salary);
            Console.WriteLine("--------------------------------------------------");





            Console.WriteLine();
            Console.WriteLine("All customer keys and values in customer dictionary");
            foreach (KeyValuePair<int, Customer> customerKeyValuePair in dictionaryCustomers)           //keyValuepair<int, Customer> == var
            {
                Console.WriteLine("Key = " + customerKeyValuePair.Key);
                Customer cust = customerKeyValuePair.Value;
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", cust.ID, cust.Name, cust.Salary);
                Console.WriteLine();
            }
            Console.WriteLine("--------------------------------------------------");






            // To get all the keys in the dictionary
            Console.WriteLine("All Keys");
            foreach (int key in dictionaryCustomers.Keys)
            {
                Console.WriteLine(key);
            }
            Console.WriteLine("--------------------------------------------------");










            // To get all the values in the dictionary
            Console.WriteLine("All Customer");
            foreach (Customer cust in dictionaryCustomers.Values)
            {
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", cust.ID, cust.Name, cust.Salary);
            }





            //count the No. of items
            Console.WriteLine("Total items in Dictionary = {0}", dictionaryCustomers.Count());
            Console.WriteLine("-------------------------------------------------------------------");
        }
    }




    public class Customer
    {

        public int ID { get; set; }

        public string Name { get; set; }


        public int Salary { get; set; }


    }
}