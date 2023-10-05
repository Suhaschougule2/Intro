//Struct Contain --  private,public,constructor,methods
//struct is value type  -- used stack(short live)  (class is reference type -- used heap(lives start till end))


//struct cant have destructors class have


using System;

public struct Customer
{
    private int _id;
    private string _name;

    public int ID
    {
        get { return this._id; }
        set { this._id = value; }
    }

    public string Name
    {
        get { return this._name; }
        set { this._name = value; }
    }



    //constructor
    public Customer(int id, string name)
    {
        this._id = id;
        this._name = name;
    }


    //method
    public void PrintDetails()
    {
        Console.WriteLine("Id = {0} & Name = {1}", this._id, this._name);
    }
}




public class Program
{
     public static void Main()
     {
        Customer C1 = new Customer(100,"Yo");       //object instance
        C1.PrintDetails();



        Customer C2 = new Customer();
        C2.ID = 200;
        C2.Name = "Suiii";
        C2.PrintDetails();




        Customer C3 = new Customer
        {
            ID = 300,
            Name ="AABB"
        };
        C3.PrintDetails();
    }
 }