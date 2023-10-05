using System;
class Program
{
    public static void Main()
    {
        Program.EvenNumbers();                   //method calling with static

        Program p = new Program();
        p.Numbers1();                            //without static


        int Sum = p.Add(20, 20);
        Console.WriteLine("Sum = {0}", Sum);




        int i = 0;                               //method parameter
        simplemethod(ref i);
        Console.WriteLine(i);
        
        

        int Total = 0;                          //out parameter
        int Product = 0;
        Calculate(10, 20, out Total, out Product);

        Console.WriteLine("Sum = {0} & Product = {1}", Total, Product);




        int[] Numbers = new int[3];                   // Param method

        Numbers[0] = 101;
        Numbers[0] = 102;
        Numbers[0] = 103;

        ParamMethod();                      //prints there is 0 element
        ParamMethod(Numbers);
    }

    public static void EvenNumbers()
    {
        int Start = 0;

        while (Start <= 10)
        {
            Console.WriteLine(Start);
            Start = Start + 2;
        }
    }

    public void Numbers1()                     //no static (instance method)
    {
        int Start = 0;

        while (Start <= 5)
        { 
        Console.WriteLine(Start);
        Start = Start + 1;
        }
    }


    public int Add (int FN, int SN)
    {
        return FN + SN;
    }





    //method parameters
    //value
    //reference
    //out
    //parameter array


    public static void simplemethod(ref int j)                                //reference 
    {
        j = 101;
    }

    public static void Calculate(int fn, int sn, out int sum, out int product)    //output parameter
    {
        sum =  fn + sn;
        product = fn * sn;
    }



    public static void ParamMethod(params int[] Numbers)                // Param method
    {
        Console.WriteLine("There are 0 Elements", Numbers.Length);

        foreach (int i in Numbers)
        {
            Console.WriteLine(i);
        } 
    }
}
