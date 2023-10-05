using System;
using System.Text;

namespace String
{
    class Program
    {
        public static void Main()
        {
            string name = "ONE\nTWO\nTHREE\nFOUR\n";
            Console.WriteLine(name);

            string name1 = "C:\\Users\\SuhasC\\Pictures\\Screenshots\n";
            Console.WriteLine(name1);

            string name2 = @"C:\\Users\\SuhasC\\Pictures\\Screenshots";  //verbatim literal (@ symbol)
            Console.WriteLine(name2);





            //normal string

            Console.WriteLine();
            string userString = "C#";
            userString += "Video";
            userString += "Tutorial";
            userString += "for";
            userString += "Beginners";
            Console.WriteLine(userString);







            //string builders

            Console.WriteLine();
            StringBuilder userStringg = new StringBuilder("C#");
            userStringg.Append("Video");
            userStringg.Append("Tutorial");
            userStringg.Append("for");
            userStringg.Append("Beginners");
            Console.WriteLine(userStringg);
            Console.WriteLine(userStringg.ToString());


        }
    }
}