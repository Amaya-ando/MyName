class MainClass
{ // 1. Создать метод без возвращаемого значения.
  // 2. В параметрах метода - принимать массив int
  // 3. Внутри метода должна происходить сортировка и вывод.
    

    static void Main(string[] args)
    {
        int[] lessi = GetArrayFromConsole();
        ArrayOrk(lessi);
    }

    static int[] GetArrayFromConsole()
    {
        var result = new int[5];

        for (int i = 0; i < result.Length; i++)
        {
            Console.WriteLine("Введите элемент массива номер {0}", i + 1);
            result[i] = int.Parse(Console.ReadLine());

        }
        return result;
    
    }

    static void ArrayOrk(int[] Array)
    {
        int temp;

        for (int i = 0; i < Array.Length; i++)
        {
            for (int j = i + 1; j < Array.Length; j++)
            {
                if (Array[i] > Array[j])
                {
                    temp = Array[i];
                    Array[i] = Array[j];
                    Array[j] = temp;
                }
            }
        }

        foreach (var item in Array)
        {
            Console.Write(item);
        }
   
    
    
    }





}

    







            

        
        