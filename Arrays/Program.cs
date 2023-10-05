//Array is a collection of similar data

//Advantages: Arrays are strongly typed.

//Disadvantages: Arrays cannot grow in size once initialized. Have to rely on integral indices to store or retrieve items from the array.

using System;
class Program
{
    static void Main()
    {
        int i = 10;
        Console.WriteLine(i);

       
        int[] EvenNumbers = new int[5];

        EvenNumbers[0] = 0;
        EvenNumbers[1] = 2;
        EvenNumbers[2] = 4;
        EvenNumbers[3] = 6;
        EvenNumbers[4] = 8;

        Console.WriteLine(EvenNumbers[1]);
        Console.WriteLine(EvenNumbers[3]);




        int[] OddNumbers = new int[5];

        OddNumbers[0] = 1;
        OddNumbers[1] = 3;
        OddNumbers[2] = 5;
        OddNumbers[3] = 7;
        OddNumbers[4] = 9;

        Console.WriteLine(OddNumbers[2]);
        Console.WriteLine(OddNumbers[4]);
    }
}



//9th Youtube Video 
//Comments

//Single Line  (//)                  shortcut (ctrl + c + c) --- all line single comment

//Multi Line  (/* --- */)            shortcut (ctrl + shift + /)  --- multi line comment

// XML Documents (///) only for documentions (for summary)