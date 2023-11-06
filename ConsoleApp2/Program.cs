class MainClass
{
    static void Main(string[] args)
    {
        (string Name, string LastName, string Login, int LoginLength, bool HasPet, string[] favcolors, double Age) User;

        for (; ;)
        {

            Console.Write("Введите ваше имя:\n");
            User.Name = Console.ReadLine();

            Console.Write("Введите вашу фамилию:\n");
            User.LastName = Console.ReadLine();

            Console.Write("Введите ваш логин:\n");
            User.Login = Console.ReadLine();
            User.LoginLength = User.Login.Length;

            Console.Write("Есть ли у вас животные? Да или Нет\n");
            var result = Console.ReadLine();

            if (result == "Да")
            {
                User.HasPet = true;
            }
            
            else
            {
                User.HasPet = false;
            }

            Console.Write("Введите ваш возраст\n");
            User.Age = double.Parse(Console.ReadLine());

            User.favcolors = new string[3];
            Console.Write("Введите три своих любимых цвета");
            
            for (int i = 0; i < User.favcolors.Length; i++)
            {
                User.favcolors[i] = Console.ReadLine();
            }
           

        }
    }        }             









            

        
        