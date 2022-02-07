// Написать программу вычисления произведения чисел от 1 до N

Console.WriteLine("Введите положительное целое число N");
int number = int.Parse(Console.ReadLine());
int multiRes = 1;

if (number < 1)
{
    Console.WriteLine("Некорректно заданное значение");
    return;
}

for (int i = 1; i <= number; i++)
{
    multiRes *= i;
}

Console.WriteLine("Произведение чисел от 1 до {0} (N!) равно {1}", number, multiRes);
