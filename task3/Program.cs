Console.WriteLine("Введите число");
try
{
    int num = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Куб числа от 1 до {num}:");
    for (int i = 1; i <= num; i++)
    {
        int result = i * i * i;
        Console.Write($"{result} ");
    }
}

catch
{
    Console.WriteLine("Ошибка выполнения");
}