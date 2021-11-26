using System;

class Program {
    public static void Main(string[] args)
    {
        Console.WriteLine("Fuck you World!");

         Fb:
    Console.WriteLine("Welcome to the Installation of Text Wars.");
    Console.WriteLine("To begin, say Y ");
    Console.WriteLine("and say N to cancel it.");
    string ansactive = Console.ReadLine();
    if (ansactive == "Y") {
        Console.WriteLine("Okay, starting...");
         System.Threading.Thread.Sleep(TimeSpan.FromSeconds(2));
    }
    else if (ansactive == "N") {
        Console.WriteLine("Okay, canceling...");
        System.Threading.Thread.Sleep(TimeSpan.FromSeconds(3));
        Environment.Exit(1);
    } 
    else {
        Console.WriteLine("Woops, an ERROR, try again would ya?");
        System.Threading.Thread.Sleep(TimeSpan.FromSeconds(1));
        goto Fb;
    }
    Console.WriteLine("Do you want to install the Source Code?");
    Console.WriteLine("Y for yes and N for no");
    string ansactive2 = Console.ReadLine();
    if (ansactive2 == "Y") {
        
    }

    }
}