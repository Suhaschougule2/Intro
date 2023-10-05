using System;

class Program
{
    public static void Main()
    {

        int[] Values = (int[])Enum.GetValues(typeof(Gender));            //get.values & names -- Enum methods(go to defination)

        foreach (int value in Values) 
        { 
            Console.WriteLine(value);
        }


        string[] Names = Enum.GetNames(typeof(Gender));

        foreach (string name in Names)
        {
            Console.WriteLine(name);
        }





















        Customer[] customers = new Customer[3];

        customers[0] = new Customer()
        {
            Name = "Karan",
            Gender = Gender.Male,                     //gender value
        };

        customers[1] = new Customer()
        {
            Name = "Alia",
            Gender = Gender.Female
        };

        customers[2] = new Customer()
        {
            Name = "Saum",
            Gender = Gender.Unknown
        };


        foreach (Customer customer in customers)
        {
            Console.WriteLine("Name = {0} && Gender = {1}", customer.Name, GetGender(customer.Gender));   
        }

    }

    //0 for unknown
    //1 for male
    //2 for female




    public static string GetGender(Gender gender)          //using enum class of Gender
    {
        // The swicth here is less readable because of these integral numbers
        switch (gender)
        {
            case Gender.Unknown:               //case Start from 0                    //instead of numbers using enum field
                return "Unknown";

            case Gender.Male:
                return "Male";

            case Gender.Female:
                return "Female";

            default:
                return "Invalid Data for Gender";
        }
    }
}






public enum Gender                           //using enum (strongly typed constant)   //use for replacing integral constants (makes program readable ) 
{
    Unknown,            //enum starts from 0 bydeafult    its changable
    Male,
    Female,
}







public class Customer
    {
        public string Name { get; set; }
        public Gender Gender { get; set; }                              //enum Gender class
    }



