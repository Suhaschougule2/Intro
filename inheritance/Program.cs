using System;

public class Employee                      //base class (parent class)
{
    public string FirstName;
    public string LastName;
    public string Email;

    public void PrintFullName()
    {
        Console.WriteLine(FirstName + " " + LastName);
    }
}

public class FUllTimeEmployee : Employee       //Inherated employee class in fulltimeemployee using (:)
{
    public float YearSalary;

   
    
    
    
    //method hiding
    public new void PrintFullName()         //new print method                         //new keyword   (to invoke hidden method of the base class)
    {
        // base.PrintFullName();                 //base keyword   (1st method to hide  (contractor) )
        Console.WriteLine(FirstName + " " + LastName + " - Contractor");
    }
}

public class PartTimeEmployee : Employee        //Inherated employee class in parttimeemployee using (:)
{
    public float HourlyRate;
}













public class ParentClass
{
    public ParentClass() 
    {
        Console.WriteLine("Parent Class Constructor Called");
    }



    public ParentClass(string Message)
    {
        Console.WriteLine(Message);
    }

}


public class ChildClass : ParentClass
{
    public ChildClass() : base ("Derived Class Control the Parent Class") 
    {
        Console.WriteLine("Child Class Constructor Called");
    }
}










public class Program
{
    public static void Main()
    {
        FUllTimeEmployee FTE = new FUllTimeEmployee();
        FTE.FirstName = "FullTime ";
        FTE.LastName = "Employee";
        FTE.YearSalary = 5000;
       //FTE.PrintFullName();
        ((Employee)FTE).PrintFullName();             //2nd method to hide (contractor)
        



        PartTimeEmployee PTE = new PartTimeEmployee();
        PTE.FirstName = "PartTime";
        PTE.LastName = "Employee";
        PTE.HourlyRate = 1000;
        PTE.PrintFullName();











        ChildClass CC = new ChildClass();
        
    }
}