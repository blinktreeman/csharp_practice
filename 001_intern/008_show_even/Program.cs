// Показать четные числа от 1 до N

Console.WriteLine("Введите число N");

int number = int.Parse(Console.ReadLine());

Console.WriteLine("Четные числа в диапазоне от 1 до N");
for (int i = 1; i <= number; i++)
{
    if (i % 2 == 0) Console.Write(i + " ");
}
