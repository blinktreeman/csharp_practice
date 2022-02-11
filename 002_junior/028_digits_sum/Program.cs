// Подсчитать сумму цифр в числе

Console.WriteLine("Введите целое число");
int number = int.Parse(Console.ReadLine());
int sum = 0;

Console.Write($"В числе {number}");
number = Math.Abs(number);

while (number > 0)
{
    sum += number % 10;
    number /= 10;
}

Console.WriteLine($" сумма значений разрядов равна {sum}");