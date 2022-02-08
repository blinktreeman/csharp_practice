// Определить сколько чисел больше 0 введено с клавиатуры

double number = 0;
int aboveZero = 0;

Console.WriteLine("Поочередно вводите числа. Для выхода - любое нечисловое значение");

do
{
    try
    {
        number = double.Parse(Console.ReadLine());
    }
    catch
    {
        Console.WriteLine("Введено {0} чисел больше нуля", aboveZero);
        return;       
    }
    finally
    {
        if (number > 0) aboveZero++;
    }
}
while (true);
