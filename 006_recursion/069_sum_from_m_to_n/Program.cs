// Найти сумму элементов от M до N, N и M заданы

int SumOfNumbers (int fromNumber, int toNumber)
{
    if (fromNumber == toNumber) return fromNumber;
    else return fromNumber + SumOfNumbers(++fromNumber, toNumber);
}

Console.WriteLine("Задайте натуральное число");
Console.Write("N=");
int beginNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Задайте натуральное число");
Console.Write("M=");
int endNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Сумма чисел от N до M");

Console.WriteLine(SumOfNumbers(beginNumber, endNumber));