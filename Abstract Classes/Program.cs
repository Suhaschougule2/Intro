using System;   
    
public abstract class Customer                    //abstract keyword    (used as base class)
{ 
    public abstract void Print();                //abstract member(method,properties,event)


    public void Print1()
    {
        Console.WriteLine("print");                   //not mandotary abstract keyword
    }

}






public class Program : Customer
{
    public override void Print()
    { 
        Console.WriteLine("Print Method");
    } 


    public static void Main() 
    { 
        
        Program p = new Program();
        p.Print();
        
        
        
        Customer c = new Program();                 //abstrct class variable points to derived class 
        
        c.Print(); 
    }
}






//abstract vs interface

//abstract contain some implementation(methods)  -----  interface cant have
//abstract have fields  ------- interface cant have
//abstract inherits by another abstract or interface -----  interface inhertits by another interface
//abstract have modifiers ----- interface cannot have