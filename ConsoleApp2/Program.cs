using System;

class MainClass
{
    public static void Main(string[] args)
    {
        Console.Write("What is your name?: ");
        var name = Console.ReadLine();
        Console.Write("How old are you?: ");
        var age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Your name is {0} and age is {1}", name, age); 
        Console.Write("When's your birthday?: ");
        var birthday = Console.ReadLine();
        Console.WriteLine("Your birthday {0} ", birthday);
        Console.ReadKey();



       






     








    }
}

