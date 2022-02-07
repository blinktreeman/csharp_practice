// Найти сумму чисел от 1 до А

Console.WriteLine("Введите положительное целое число А");

int number = int.Parse(Console.ReadLine());

if (number < 1)
{
    Console.WriteLine("Некорректно заданное значение");
    return;
}

int sum = 0;

for (int i = 1; i <= number; i++) sum += i;
Console.WriteLine("Сумма чисел от 1 до {0} равна {1}", number, sum);
