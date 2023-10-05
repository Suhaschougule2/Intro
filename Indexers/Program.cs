// C# program to illustrate the Indexer
using Indexers;
using System;

// class declaration
public class IndexerCreation
{

    // class members
    private string[] val = new string[3];

    // Indexer declaration
    // public - access modifier
    // string - the return type of the Indexer
    // this - is the keyword having a parameters list
    public string this[int index]
    {

        // get Accessor
        // retrieving the values
        // stored in val[] array of string
        get
        {

            return val[index];
        }


        // set Accessor
        // setting the value at
        // passed index of val
        set
        {

            // value keyword is used
            // to define the value
            // being assigned by the
            // set indexer.
            val[index] = value;
        }
    }
}



// Driver Class
public class Program
{

    // Main Method
    public static void Main()
    {

        // creating an object of parent class which
        // acts as primary address for using Indexer
        IndexerCreation ic = new IndexerCreation();

        // Inserting values in ic[]
        // Here we are using the object
        // of class as an array
        ic[0] = "C";
        ic[1] = "CPP";
        ic[2] = "CSHARP";

        Console.Write("Printing values stored in objects used as arrays\n");

        // printing values
        Console.WriteLine("First value = {0}", ic[0]);
        Console.WriteLine("Second value = {0}", ic[1]);
        Console.WriteLine("Third value = {0}", ic[2]);
















        Overloadingindexer Obj = new Overloadingindexer();

        Obj[0] = "Hello"; // Value of word[0]

        Obj[1.0f] = " Geeks"; // Value of word[1]

        Console.WriteLine();
        Console.WriteLine(Obj[0] + Obj[1.0f]);

    }
}
