using System;

public delegate void SampleDelegate();
class Program
{
        public static void Main()
        {

        // In this example del4 is a multicast delegate. You use +(plus) 
        // operator to chain delegates together and -(minus) operator to remove.
            SampleDelegate del1, del2, del3, del4;

            del1 = new SampleDelegate(SampleMethodOne);
            del2 = new SampleDelegate(SampleMethodTwo);
            del3 = new SampleDelegate(SampleMethodThree);
      
            del4 = del1 + del2 + del3;

            del4();

        Console.WriteLine("");

        // In this example del is a multicast delegate. You use += operator 
        // to chain delegates together and -= operator to remove.
            SampleDelegate del = new SampleDelegate(SampleMethodOne);

            del += SampleMethodTwo;
            del += SampleMethodThree;
            del -= SampleMethodTwo;

            del();
    }


        public static void SampleMethodOne()
        {
            Console.WriteLine("SampleMethodOne Invoked");
        }


        public static void SampleMethodTwo()
        {
            Console.WriteLine("SampleMethodTwo Invoked");
        }


        public static void SampleMethodThree()
        {
            Console.WriteLine("SampleMethodThree Invoked");
        }
    
}


/*
using System;

public delegate void SampleDelegate(out int Integer);
class Program
{
    public static void Main()
    {
        SampleDelegate del = new SampleDelegate(SampleMethodOne);
        del += SampleMethodTwo;


        // The ValueFromOutPutParameter will be 2, initialized by SampleMethodTwo(),
        // as it is the last method in the invocation list.
        int ValueFromOutPutParameter = -1;
        del(out ValueFromOutPutParameter);


        Console.WriteLine("Returned Value = {0}", ValueFromOutPutParameter);
    }


    // This method sets ouput parameter Number to 1
    public static void SampleMethodOne(out int Number)
    {
        Number = 1;
    }


    // This method sets ouput parameter Number to 2
    public static void SampleMethodTwo(out int Number)
    {
        Number = 2;
    }
}
*/
