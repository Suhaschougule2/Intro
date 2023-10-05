//Reflection is the ability of inspecting an assemblie's metadata at runtime.
//It is used to find all types in an assembly and/or dynamically invoke methods in an assembly.
//This includes information about the type, properties, methods, and events of an object. 

using System;
using System.Reflection;

namespace Reflection
{
    public class Program
    {
        public static void Main()
        {
            //Type T = Type.GetType("Reflection.Customer");

            Type T = typeof(Customer1);
                 
            //Customer c1 = new Customer();   
            //Type TT = c1.GetType();

            Console.WriteLine("Full Name = {0}", T.FullName);
            Console.WriteLine("Just the Name = {0}", T.Name);
            Console.WriteLine("Just the Namespace = {0}", T.Namespace);
            Console.WriteLine();






            Console.WriteLine("Properties in Customer");
            PropertyInfo[] properties = T.GetProperties();
            foreach (PropertyInfo property in properties)
            {
                Console.WriteLine(property.PropertyType.Name + " " + property.Name);
            }






            Console.WriteLine();
            Console.WriteLine("Methods in Customer");
            MethodInfo[] methods = T.GetMethods();
            foreach (MethodInfo method in methods) 
            {
                Console.WriteLine(method.ReturnType.Name + " " + method.Name);
            }






            Console.WriteLine();
            Console.WriteLine("Constructors in Customer");
            ConstructorInfo[] constructors = T.GetConstructors();
            foreach (ConstructorInfo constructor in constructors)
            {
                Console.WriteLine(constructor.ToString());
            }

            Console.WriteLine();










            //new class method (early binding)
            Customer C1 = new Customer();
            string fullName = C1.GetFullName("AAA", "BBB");
            Console.WriteLine();
            Console.WriteLine("Full Name = {0}", fullName);







            //late binding
            Assembly executingAssembly = Assembly.GetExecutingAssembly();                       //load executing assembly

            Type customerType = executingAssembly.GetType("Reflection.Customer");              //load customer class for creating instance

            object customerInstannce = Activator.CreateInstance(customerType);                //object instance of customerType

            MethodInfo getFullNameMethod = customerType.GetMethod("GetFullName");            //method information

            string[] parameters = new string[2];
            parameters[0] = "Leo";
            parameters[1] = "Messi";

            string fullName2 = (string)getFullNameMethod.Invoke(customerInstannce, parameters);         //invoking method 
            Console.WriteLine("FullName = {0}" , fullName2);

        }

    }

    public class Customer1
    {
        public int Id { get; set; }                                        
        public string Name { get; set; }


        public Customer1(int ID, string Name)
        {
            this.Id = ID;
            this.Name = Name;
        }


        public Customer1()
        {
            this.Id = -1;
            this.Name = string.Empty;
        }


        public void PrintID()
        {
            Console.WriteLine("ID = {0}", this.Id);
        }
        public void PrintName()
        {
            Console.WriteLine("Name = {0}", this.Name);
        }
    }






     //new class early binding
     public class Customer
     {
        public string GetFullName(string FirstName, string LastName)
        {
            return FirstName + " " + LastName;
        }
     }
}