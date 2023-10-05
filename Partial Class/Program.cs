using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    public static void Main()
    {

    }


    public class Geeks
    {
        private string Author_name;
        private int Total_articles;

        public Geeks(string a, int t)
        {
            this.Author_name = a;
            this.Total_articles = t;
        }

        public void Display()
        {
            Console.WriteLine("Author's name is : " + Author_name);
            Console.WriteLine("Total number articles is : " + Total_articles);
        }
    }

}