using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {

        Calculator.Add(10, 20);

        Calculator.Add(10, 20, 30);

        Calculator.Add(new List<int>() {20,40,60});
        
    }
}


public class Calculator
{
    [Obsolete]                //pre-defined attribute  (more -- WebMethod,Serializable)
    public static int Add(int FN, int SN)
    {
        return FN + SN;
    }

    [Obsolete]
    public static int Add(int FN, int SN, int TN)
    {
        return FN + SN + TN ;
    }




    public static int Add(List<int> Numbers)
    {
        int Sum = 0;
        foreach (int n in Numbers)
        {
            Sum = Sum + n;
        }
        return Sum;
    }
}