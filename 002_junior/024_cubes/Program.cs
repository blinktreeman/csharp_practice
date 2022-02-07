// Найти кубы чисел от 1 до N

Console.WriteLine("Введите целое число N");

int number = int.Parse(Console.ReadLine());

Console.WriteLine("Таблица кубов чисел от 1 до N");
for (int i = 1; i <= number; i++)
{
    Console.WriteLine("{0, 5}^3 = {1, -20}", i, Math.Pow(i, 3));
}
