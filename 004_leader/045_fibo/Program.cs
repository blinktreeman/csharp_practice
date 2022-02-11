// Показать числа Фибоначчи
void showFibo (int last, int current, int limOut)
{
    if (current + last > limOut) return;
    Console.Write("{0} ", last + current);
    showFibo (current, last + current, limOut);
}

Console.WriteLine("Задайте предел для числовой последовательности Фибоначчи");

int limit = int.Parse(Console.ReadLine());

Console.Write("0 1 ");
showFibo (0, 1, limit);
