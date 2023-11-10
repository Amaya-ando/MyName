using System;
using System.Drawing;
// которая в цикле вызывает метод ShowColor()
// записывает его значение в массив из трех цветов favcolors, а потом отображает значения этого массива. 
class MainClass
{
    static void Main(string[] args)
    {
        var favcolors = new string[3];

        for (int i = 0; i < favcolors.Length; i++)
        {
            favcolors[i] = ShowColor();

        }

        Console.WriteLine("Ваши любимые цвета:");
        foreach (var color in favcolors)
        {
            Console.WriteLine(color);
        }


        Console.ReadKey();
    }
    static string ShowColor()
    {
        string color = Console.ReadLine();

        return color;

    }






   
}





























