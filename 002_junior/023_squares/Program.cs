// Показать таблицу квадратов чисел от 1 до N

Console.WriteLine("Введите целое число N");

int number = int.Parse(Console.ReadLine());

Console.WriteLine("Таблица квадратов чисел от 1 до N");
for (int i = 1; i <= number; i++)
{
    Console.WriteLine("{0, 5}^2 = {1, -20}", i, i*i);
}
