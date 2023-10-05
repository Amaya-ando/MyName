using System;

class MainClass
{
    public static void Main(string[] args)
    {
        ConsoleColor Semaphore;

        Semaphore = ConsoleColor.Green;

        Console.WriteLine(Semaphore);
    }
}

enum Semaphore
{
    Red = 100,
    Yellow = 200,
    Green = 300

}

