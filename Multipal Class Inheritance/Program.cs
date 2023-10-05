//Multi class inheritance is not possible using classes override problem occur (ambiguty called diamond problem)
//to solve the problem use interface 

using System;
using System.Runtime.InteropServices;

interface IA                  //interface A
{
    void AMethod();
}

class A : IA                   //inherites interface A
{
    public void AMethod()                 //interface method compulsory
    {
        Console.WriteLine("A");
    }
}








interface IB                    //interface B
{
    void BMethod();
}

class B : IB               //inherites interface B
{
    public void BMethod()               //interface method compulsory
    {
        Console.WriteLine("B");
    }
}








class AB : IA, IB               //inherites both A and B
{
    A a = new A();
    B b = new B();

    public void AMethod()               //their methods compulsory
    {
        a.AMethod();
    }


    public void BMethod()
    {
        b.BMethod();
    }
}





public class Program
{
    public static void Main()
    {
        AB ab = new AB();                    //class object interface
        ab.AMethod();                        //method call
        ab.BMethod();
    }
}