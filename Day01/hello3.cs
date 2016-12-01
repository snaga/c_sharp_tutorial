using System;

public class Hello3
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello, world! - 3");
        Console.WriteLine("You entered the following {0} command line arguments:", args.Length);
        for (int i=0; i < args.Length; i++)
        {
            Console.WriteLine("{0}", args[i]);
        }
    }
}