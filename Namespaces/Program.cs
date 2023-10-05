using System;
using PATA = ProjectA.TeamA;                                    // use ally (alias names/directives)    
using PATB = ProjectA.TeamB;
using PATC = ProjectA.TeamC;

class Program
{
    static void Main()
    {
        // ProjectA.TeamA.ClassA.Print();                    //Calling  (direct)                  (as package)
        // ProjectA.TeamB.ClassA.Print();

       // ClassA.Print();
       // ClassA.Print();                                  //ambiguous reference  (class A present in both teams)


        PATA.ClassA.Print();
        PATB.ClassA.Print();                                //resolve ambiguity


        PATC.ClassA.Print();              //ProjectA.TeamC.ClassA.Print();
        PATC.ClassB.Print();
    }
}



//namespaces provide assistance in avoiding name clashes           //used to organise program  
namespace ProjectA
{
    namespace TeamA
    {
        class ClassA
        {
            public static void Print() 
            {
                Console.WriteLine(" Team A print method");
            }
        }
    }
}

namespace ProjectA
{
    namespace TeamB
    {
        class ClassA
        {
            public static void Print()
            {
                Console.WriteLine(" Team B print method");
            }
        }
    }
}


namespace ProjectA
{
    namespace TeamC
    {
        class ClassA
        {
            public static void Print()
            {
                Console.WriteLine(" Team C-Class A print method");
            }
        }


        class ClassB
        {
            public static void Print()
            {
                Console.WriteLine(" Team C-Class B print method");
            }
        }
    }
}

//namespace contain

//another namespace
//class 
//interface
//struct
//enum
//delegate