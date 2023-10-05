using System;


public class Customer                         //type (by default private)
{
    private int _id = 100;                             //member (fields)  (by default internal)


    public int Id            //properties
    {
        get
        {
            return _id;
        }
        set
        {
            _id = value;
        }
    }
}


public class Program
{
    private static void Main()
    {
        Customer C1 = new Customer();
        Console.WriteLine(C1.Id);

        //_id is inaccessible due to its protection level
        // C1._id = 101;
    }
}
