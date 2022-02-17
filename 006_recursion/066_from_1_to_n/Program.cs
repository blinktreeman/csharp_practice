// Показать натуральные числа от 1 до N, N задано

string naturalNumbers(int fromNumber, int endOfInterval)
{
    if (fromNumber == endOfInterval) return fromNumber.ToString();
    else return fromNumber.ToString() + " " + naturalNumbers(++fromNumber, endOfInterval);
}

Console.WriteLine("Задайте положительное натуральное число");
Console.Write("N=");
int number = int.Parse(Console.ReadLine());
Console.WriteLine("Натуральные числа от 1 до N");
Console.WriteLine(naturalNumbers(1, number));
