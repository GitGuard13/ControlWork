using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите массив строк через запятую:");
        string[] inputArr = Console.ReadLine().Split(",");

        int count = 0;
        for (int i = 0; i < inputArr.Length; i++)
        {
            if (inputArr[i].Length <= 3)
                count++;
        }

        string[] resultArr = new string[count];
        int index = 0;
        for (int i = 0; i < inputArr.Length; i++)
        {
            if (inputArr[i].Length <= 3)
            {
                resultArr[index] = inputArr[i];
                index++;
            }
        }

        Console.WriteLine("Результат:");
        Console.WriteLine("[" + string.Join(", ", resultArr) + "]");
    }
}
