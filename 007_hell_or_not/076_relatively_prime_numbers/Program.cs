// Задача: найти M при заданном N и получить одно из разбиений на группы
// N ≤ 10²⁰

Console.WriteLine("Задайте натуральное число N (N <= 10^20)");

decimal limit = decimal.Parse(Console.ReadLine());

Console.WriteLine("Число М групп взаимно простых чисел при разбиении");
Console.Write("чисел от 1 до N равно ");
int groups = (int)Math.Floor(Math.Log2((double)limit) + 1);
Console.WriteLine(groups);

Console.WriteLine("Группы чисел");
for (int i = 0; i < groups; i++)
{
    Console.Write($"Группа {i + 1}: ");
    for (decimal j = Convert.ToDecimal(Math.Pow(2, i)); 
                (j < Convert.ToDecimal(Math.Pow(2, i + 1)) && j <= limit); 
                j++)
        Console.Write($"{j} ");
    Console.WriteLine();
}
