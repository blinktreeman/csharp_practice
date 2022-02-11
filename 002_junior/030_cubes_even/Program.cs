// Показать КУБЫ чисел, ЗАКАНЧИВАЮЩИХСЯ на четную цифру (?)

Console.WriteLine("Задайте диапазон целых чисел");
Console.Write("Начало диапазона А=");
int numA = int.Parse(Console.ReadLine());
Console.Write("Конец диапазона B=");
int numB = int.Parse(Console.ReadLine());

Console.WriteLine("Таблица кубов чисел от A до B заканчивающихся на четную цифру");
for (int i = numA; i <= numB; i++)
{
    if (Math.Pow(i, 3) % 2 == 0) Console.WriteLine("{0, 5}^3 = {1, -20}", i, Math.Pow(i, 3));
}
