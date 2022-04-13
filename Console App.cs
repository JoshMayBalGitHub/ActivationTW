using System;

class Program {
    public static void Main(string[] args)
    {
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
        Environment.Exit(0);
    } 
    else {
        Console.WriteLine("Woops, an ERROR, try again would ya?");
        System.Threading.Thread.Sleep(TimeSpan.FromSeconds(1));
        goto Fb;
    }

     Console.WriteLine("Starting Installer......");
     System.Threading.Thread.Sleep(TimeSpan.FromSeconds(5));
     Console.WriteLine("Getting some files ready.....");
     System.Threading.Thread.Sleep(TimeSpan.FromSeconds(5));
     Console.WriteLine("Checking file integrity....");
     System.Threading.Thread.Sleep(TimeSpan.FromSeconds(2));
     Console.WriteLine("Installing.....");
     System.Threading.Thread.Sleep(TimeSpan.FromSeconds(1));
     Console.WriteLine("Installing textwars.csproj.....");
     System.Threading.Thread.Sleep(TimeSpan.FromSeconds(5));
     Console.WriteLine("Done!");
     System.Threading.Thread.Sleep(TimeSpan.FromSeconds(2));
     Console.WriteLine("Installing textwars.cs.....");
     System.Threading.Thread.Sleep(TimeSpan.FromSeconds(5));
     Console.WriteLine("Done!");
     System.Threading.Thread.Sleep(TimeSpan.FromSeconds(1));
     Console.WriteLine("Installing bin stuff.......");
     System.Threading.Thread.Sleep(TimeSpan.FromSeconds(7));
     Console.WriteLine("Done!");
     System.Threading.Thread.Sleep(TimeSpan.FromSeconds(1));
     Console.WriteLine("Installing obj stuff..........");
     System.Threading.Thread.Sleep(TimeSpan.FromSeconds(7));
     Console.WriteLine("Done!");
     System.Threading.Thread.Sleep(TimeSpan.FromSeconds(1));

    Fb2:
    Console.WriteLine("Do you wish to install the .vscode stuff?");
    Console.WriteLine("Y for yes and N for no");
     string ans2active = Console.ReadLine();
    if (ans2active == "Y") {
        Console.WriteLine("Okay.....");
        System.Threading.Thread.Sleep(TimeSpan.FromSeconds(2));
    }
    else if (ans2active == "N") {
        Console.WriteLine("Okay......");
        System.Threading.Thread.Sleep(TimeSpan.FromSeconds(2));
        goto Fb3;
    } 
    else {
        Console.WriteLine("Woops, an ERROR, try again would ya?");
        System.Threading.Thread.Sleep(TimeSpan.FromSeconds(1));
        goto Fb2;
    }
    Console.WriteLine("Installing .vscode stuff......");
    System.Threading.Thread.Sleep(TimeSpan.FromSeconds(5));
    Console.WriteLine("Done!");
    System.Threading.Thread.Sleep(TimeSpan.FromSeconds(1));
    Fb3:
    Console.WriteLine("Do you wish to install:");
    Console.WriteLine("L for Linux Version");
    Console.WriteLine("M for MacOS Version");
    Console.WriteLine("W for Windows Version");
    string ans3active = Console.ReadLine();
    if (ans3active == "L") {
        Console.WriteLine("Okay.....");
        System.Threading.Thread.Sleep(TimeSpan.FromSeconds(2));
    }
    else if (ans3active == "M") {
        Console.WriteLine("Okay......");
        System.Threading.Thread.Sleep(TimeSpan.FromSeconds(2));
        
    }
     else if (ans3active == "W") {
        Console.WriteLine("Okay......");
        System.Threading.Thread.Sleep(TimeSpan.FromSeconds(2));
        goto Fb4;
    } 
    else {
        Console.WriteLine("Woops, an ERROR, try again would ya?");
        System.Threading.Thread.Sleep(TimeSpan.FromSeconds(1));
        goto Fb3;
    }
    Console.WriteLine("Installing Run.sh");
    System.Threading.Thread.Sleep(TimeSpan.FromSeconds(5));
    Console.WriteLine("Done!");
    System.Threading.Thread.Sleep(TimeSpan.FromSeconds(1));
    goto Fb5;

    Fb4:
    Console.WriteLine("Installing Run.bat");
    System.Threading.Thread.Sleep(TimeSpan.FromSeconds(5));
    Console.WriteLine("Done!");
    System.Threading.Thread.Sleep(TimeSpan.FromSeconds(1));
    Fb5:

    Console.WriteLine("Install Finished!");
    System.Threading.Thread.Sleep(TimeSpan.FromSeconds(1));
    Console.WriteLine("Press Enter to exit....");
    string ans4active = Console.ReadLine();
    }
}