namespace Wema.BIT.Models;

  /*  public class User
    {
        public static void Main(string[] args)
        {
            // -- for single line comments
            *//*
             * multiline comments
             *//*

            Console.WriteLine("Hello, World!");
        }
    }*/


//namespace Wema.BIT.User 
    public class User
    {
        public static void Main(string[] args)
        {
            // -- for single line comments
            /*
             * multiline comments
             */

            Console.WriteLine("Hello, World!");
            Payment.Greet();
            Payment p = new Payment();
            p.GreetMe();

            string greet = p.GreetMe();

            Console.WriteLine(greet);

        }
    }

    public class Payment
    {
        public static string Name = "Johnson";

        public static void Greet()
        {
            Console.WriteLine("Good Afternoon!");
        }

        public string GreetMe()
        {
            Console.WriteLine("Good Afternoon!");

            return "Good Afternoon";
        }
    }



