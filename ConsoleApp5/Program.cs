namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            (string name, int age) anketa;

            Console.Write("Ваше имя: ");
            anketa.name = Console.ReadLine();
            Console.Write("Ваш возраст: ");
            anketa.age = Convert.ToInt32(Console.ReadLine());   

            Console.WriteLine("Ваше имя: {0}", anketa.name);
            Console.WriteLine("Вас зовут: {0}", anketa.age);

            Console.ReadKey();
            
        }

          









        }
        
        

       
    }
