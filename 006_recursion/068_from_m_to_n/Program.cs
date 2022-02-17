// Показать натуральные числа от M до N, N и M заданы

string NaturalNumbers(int number, int endOfInterval)
{
    if (number == endOfInterval) return number.ToString();
    else return number.ToString() + " " + NaturalNumbers(++number, endOfInterval);
}



Console.WriteLine("Задайте натуральное число");
Console.Write("N=");
int beginNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Задайте натуральное число");
Console.Write("M=");
int endNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Натуральные числа от N до M");

Console.WriteLine(NaturalNumbers(beginNumber, endNumber));
