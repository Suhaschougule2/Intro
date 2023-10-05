//polymorphism enables invoke derived class method using base class reference variable at runtime
using System;



public class Employee                        
{
    public string FirstName = "FN";
    public string LastName = "SN";


    public  virtual void PrintFullName()              //virtual keyword indicate method can be overrideen in any derived class
    {
        Console.WriteLine(FirstName + " " + LastName);
    }
}

public class FullTimeEmployee : Employee         //derived class1
{

    //Method override(override) vs method hiding (new)  (Video-24)

    //method override
    public override void PrintFullName()              //overrides method  (base class  method is derived virtual)  
    {
        Console.WriteLine(FirstName + " " + LastName + " - Full Time");
    }


    //method hiding

    //insted of override if use new keyword then it will invoke base class method

   /* public new void PrintFullName()            
    {
        Console.WriteLine(FirstName + " " + LastName + " - Full Time");
    }
   */
}


public class PartTimeEmployee : Employee               //derived class2
{
    public override void PrintFullName()
    {
        Console.WriteLine(FirstName + " " + LastName + " - Part Time");
    }
}


public class TemporaryTimeEmployee : Employee           //derived class3
{
    public override void PrintFullName()
    {
        Console.WriteLine(FirstName + " " + LastName+ " - Temporary Time");
    }
}







public class Program
{
    public static void Main()
    {
        Employee[] employees = new Employee[4];            //using/through base class variable  (employees)

        employees[0] = new Employee();
        employees[1] = new FullTimeEmployee();             //derived class method (FullTimeEmployee)   //parent class derived child class
        employees[2] = new PartTimeEmployee();
        employees[3] = new TemporaryTimeEmployee();


        foreach (Employee e in employees) 
        {
            e.PrintFullName();
        }
    }
}