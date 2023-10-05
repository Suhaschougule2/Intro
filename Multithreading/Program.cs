using System;
using System.Threading;

class Program
{
    public static void Main()
    {

        //main thread

        Thread mainthread = Thread.CurrentThread;
        mainthread.Name = "Main Thread";
        //Console.WriteLine(mainthread.Name);

        Console.WriteLine(mainthread.Name + " is Complete.");                 //main thread complete


        //CountDown();
        //CountUp();



        Thread thread1 = new Thread(Down.CountDown);                       //creating instance of threads
        Thread thread2 = new Thread(CountUp);

        thread1.Start();
        thread2.Start();


        
    }

    class Down
    {
        public static void CountDown()                                    //thread 1
        {
            for (int i = 10; i >= 0; i--)
            {
                Console.WriteLine("Timer 1: " + i + "seconds");
                Thread.Sleep(1000);
            }
            Console.WriteLine("Timer 1 is completed");
        }
    }




    public static void CountUp()                                        //thread 2
    {
        for (int i = 0; i <= 10; i++)
        {
            Console.WriteLine("Timer 2: " + i + "seconds");
            Thread.Sleep(1000);
        }
        Console.WriteLine("Timer 2 is completed");
    }
}
