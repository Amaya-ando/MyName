namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            (string Name, string Type, double Age, int NameCount) Pet;

            Console.Write("Введите, пожалуйста, имя питомца: ");
            Pet.Name = Console.ReadLine();
            Pet.NameCount = Pet.Name.Length;

            Console.Write("Укажите тип вашего питомца: ");
            Pet.Type = Console.ReadLine();

            Console.Write("Теперь, укажите его возраст: ");
            Pet.Age = Convert.ToInt32(Console.ReadLine());
            

            Console.WriteLine("Спасибо!");
            Console.WriteLine("Имя вашего питомца: {0}", Pet.Name);
            Console.WriteLine("Тип вашего питомца: {0}", Pet.Type);
            Console.WriteLine("Возраст вашего питомца: {0}", Pet.Age);
            Console.WriteLine("Длина имени вашего питомца {0}", Pet.NameCount);

            Console.ReadKey();
            
        }

          









        }
        
        

       
    }
