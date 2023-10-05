//Built -in types in C#
//1. Boolean type – true or false 
//2. Integral Types - sbyte, byte, short, ushort, int, uint, long, ulong, char
//3. Floating Types – float and double
//4. Decimal Types 
//5. String Type 

using System;

class Program
{
    static void Main()
    {
        bool b = true;
        Console.WriteLine(b);

        sbyte s = 0;
        Console.WriteLine("\nMin={0}", sbyte.MinValue);
        Console.WriteLine("Max={0}", sbyte.MaxValue);



        ushort u = 0;

        Console.WriteLine("\nMin={0}", ushort.MinValue);
        Console.WriteLine("Max={0}", ushort.MaxValue);

        int i = 0;

        Console.WriteLine("\nMin={0}",int.MinValue);
        Console.WriteLine("Max={0}\n",int.MaxValue);


        double d = 10.123;
        Console.WriteLine(d);


        float f = 10.10f;
        Console.WriteLine(f);
    }
    
    
}