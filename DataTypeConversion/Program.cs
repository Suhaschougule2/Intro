using System;

class Program
{
    static void Main()
    {
        //Implicit Conversion

        int i = 100;

        float f = i;
        Console.WriteLine(f);


        //Explicit Conversion

        float f1 = 123.456F;
        //First 
        int i1 = (int)f1;
        Console.WriteLine(i1);
        
        //Second (using convert class)
        int i2 = Convert.ToInt32(f1);
        Console.WriteLine(i2);


        //Parse

        string strnum = "1000";
        int num = int.Parse(strnum);
        Console.WriteLine(num);    //parse throws an expection if it cannot parse Ex.("1000PG") Therefore used TryParse


        //TryParse

        string strnum1 = "100";

        int result = 0;

        bool isconversible = int.TryParse(strnum1, out result);  // TryParse returns a bool indicating whether success or failed conversion
        if(isconversible)
        {
            Console.WriteLine(result);
        }
        else
        {
            Console.WriteLine("Enter Valid No");
        }
    }
}