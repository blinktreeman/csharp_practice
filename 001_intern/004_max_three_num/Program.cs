// Найти максимальное из трех чисел

int maximum = 0;

Console.WriteLine("Введите три числа");

for (int i = 0; i < 3; i++) 
{
    int number = int.Parse(Console.ReadLine());
    if (number > maximum) maximum = number;
}

Console.WriteLine("Максимальное число из заданных равно " + maximum);
