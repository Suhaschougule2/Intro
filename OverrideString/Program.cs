using System;

namespace Override
{
    public class Program
    {
        public static void Main()
        {
            int number = 10;

            Console.WriteLine(number.ToString());






            Customer C1 = new Customer();                //cc object
            C1.FirstName = "YYYY";
            C1.LastName = "OOOO";

            Console.WriteLine(C1.ToString());                            // cc << Customer << Override(namespace)
            Console.WriteLine(Convert.ToString(C1));                    //another 
                                                                        








            //override Equals Method
            
            Customer C3 = C1;            //Declaring object C3 Equals to C1

            Console.WriteLine(C1 == C3);
            Console.WriteLine(C1.Equals(C3));                //overriding the Equals 






            Customer C4 = new Customer();                //cc object
            C4.FirstName = "YYYY";
            C4.LastName = "OOOO";


           
            Console.WriteLine(C4 == C1);                 //gives false
            Console.WriteLine(C4.Equals(C1));            //gives true













            //Convert To String vs To String

            Customer C2 = null; ;
            string str = Convert.ToString(C2);               //using Convert To String
            Console.WriteLine(str);                           //handle null


            string str2 = C2.ToString();                   //using TO String
            Console.WriteLine(str2);                //  (throws null reference exception




        }
    }



    public class Customer
    {
        public string FirstName { get; set; }    
        public string LastName { get; set; }






        //overriding to strind method

        public override string ToString()
        {
           // return base.ToString();
           return this.FirstName + " " + this.LastName;
        }





        //overriding using equals
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (!(obj is Customer))
            {
                return false;
            }

            return this.FirstName == ((Customer)obj).FirstName && this.LastName == ((Customer)obj).LastName;
        }
    }
}