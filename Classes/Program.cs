using System;

class Customer                                                            //class
{ 
    string _firstName;     //fields
    string _lastName;


    public Customer() : this("No First Provided", "No LastName provided")         //constructor without parameters
    {

    }
    public Customer(string FirstName, string LastName)                    //constructor  with parameters  (initialize class fields)  does not contain return value, always have same class name
    { 
        this._firstName = FirstName;
        this._lastName = LastName;
    }

    public void PrintFullName()            //method
    {
        Console.WriteLine("Full Name = {0}", this._firstName + " " + this._lastName);
    }

    ~Customer()             //Destructor without parameters   
    { 
        //Clean up code
    }
}









class Circle
{
    public static float _PI;                    // static class member field

    int _Radius;                         //instance field



    static Circle()                         //static cons called once once. used to initialize static field
    {
        Console.WriteLine("Static Constructor Called");
        Circle._PI = 3.142F;
    }



    public Circle(int Radius)                    //instance cons
    {
        Console.WriteLine("Instance Constructor Called");
        this._Radius = Radius;
    }

    public static void print()                //static method
    {
        //
    }


    public float CalculateArea()              // instance method
    {
        return Circle._PI * this._Radius * this._Radius;                   //static member calling using class name
    }

}







class Program
{
    public static void Main()
    {
        Customer C1 = new Customer("ABC", "XYZ");                    //Instance of class   --   constructor is called automatically when instance is called
        C1.PrintFullName();


        Customer C2 = new Customer();                                //parameterless constructor
        C2.PrintFullName();
















        Circle circle = new Circle(5);
        float Area = circle.CalculateArea();                // instance method calling using instance class name


        Circle.print();                                     //static method calling using class name                              

        Console.WriteLine("Area of Circle is {0}", Area);


        Circle circle2 = new Circle(10);
        float Area2 = circle2.CalculateArea();

        Console.WriteLine("Area of Circle2 is {0}", Area2);



        Console.WriteLine(Circle._PI);


    }
}