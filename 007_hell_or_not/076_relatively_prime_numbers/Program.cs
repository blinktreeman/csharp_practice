// Задача: найти M при заданном N и получить одно из разбиений на группы
// N ≤ 10²⁰

Console.WriteLine("Задайте натуральное число N (N <= 10^20)");
// only 1,8...*10^19 (use decimal?)
ulong limit = ulong.Parse(Console.ReadLine());

Console.WriteLine("Число М групп взаимно простых чисел при разбиении");
Console.Write("чисел от 1 до N равно ");
double groups = Math.Floor(Math.Log2(limit)+1);
Console.WriteLine(groups);

Console.WriteLine("Группы чисел");
for (int i = 0; i < groups; i++)
{
    Console.Write($"Группа {i + 1}: ");
    for (ulong j = Convert.ToUInt64(Math.Pow(2, i)); (j < Convert.ToUInt64(Math.Pow(2, i+1)) && j <= limit); j++)
        Console.Write($"{j} ");
    Console.WriteLine();
}
