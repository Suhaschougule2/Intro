//Contain only declaration no implementation
//members are public by default (dont allow access modifiers)
//cannot contain feilds
//class struct inherit from more than 1 interface but class cannot inherit more than 1 class
//cannot create instance of interface (interface reference varialbe point to derived class object)

using System;
using System.Reflection.Metadata;

interface ICustomer1
{
    void Print1();
}

interface ICustomer2 : ICustomer1
{
    void Print2();
}











interface I1
{
    void InterfaceMethod();
}


interface I2
{
    void InterfaceMethod();
}





public class Customer : ICustomer2                //instance method is  called compulsory within the the inherited class
{
    public void Print2()                  //IC2 method
    {
        Console.WriteLine("Print 2");
    }

    public void Print1()                    //IC1 method
    {
        Console.WriteLine("Print 1");
    }
}




public class Program : I1, I2
{


     void I1.InterfaceMethod()                    // by default public (dont allow acces modifiers)
    {
        Console.WriteLine("I1 Interface Method");
    }


     void I2.InterfaceMethod()
    {
        Console.WriteLine("I2 Interface Method");
    }










    public static void Main()
    {
        //Customer c1 = new Customer();
        //c1.Print1();
        //c1.Print2();

        ICustomer1 cc = new Customer();        //Interface ref variable point to derived class 
        cc.Print1();












        Program p = new Program();

        ((I1)p).InterfaceMethod();                //type casting
        ((I2)p).InterfaceMethod();









        I1 i1 = new Program();             //(interface reference varialbe point to derived class object)              
        I2 i2 = new Program();

        i1.InterfaceMethod();
        i2.InterfaceMethod();

    }










   
}