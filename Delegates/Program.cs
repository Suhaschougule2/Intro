using System;

public delegate void HelloFunctionDelegate(string Message);           //Delegate is a function pointer (holds the reference pointer to function)
class Program
{
    public static void Main()
    {
        HelloFunctionDelegate del = new HelloFunctionDelegate(Hello);   //del points the function hello   //signature of del is void (then function have also void sign otherwise caught error))
        del("Hiii from Delegate");     //str message
            
    }


    public static void Hello(string strMessage)                 //Function method (full)   //sign of del should match the function sign
    {
        Console.WriteLine(strMessage);
    }
}




