using System;

class Program
{
    static void Main()
    {
        int? i = null;

        bool? AreYouMajor = null;

        if (AreYouMajor ==true)
        {
            Console.WriteLine("User is Major");
        }
        else if (AreYouMajor ==false)
        {
            Console.WriteLine("User is Not Major");
        }
        else
        {
            Console.WriteLine("User Not Answered Question");
        }



        int? TicketonSale = 50;
        int AvailableTicket;

        if(TicketonSale ==null) 
        {
            AvailableTicket = 0;
        }
        else
        {
            AvailableTicket = TicketonSale.Value;
            //AvailableTicket = (int)TicketonSale;               //.Value || (int) used --  (Convert int? to int)
        }
        Console.WriteLine("Available Tickets = {0}", AvailableTicket);




        int? TicketPass = null;

        int AvailablePass = TicketPass ?? 0;  //  (??) Null Coalescing Operator -- (0) is by default
        Console.WriteLine("Available Pass = {0}", AvailablePass);
        // if pass is null then print 0 else print  present Ticket pass 
    }
}