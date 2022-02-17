// Показать натуральные числа от N до 1, N задано

string naturalNumbers(int naturalNumber)
{
    if (naturalNumber == 1) return naturalNumber.ToString();
    else return naturalNumber.ToString() + " " + naturalNumbers(--naturalNumber);
}

Console.WriteLine("Задайте положительное натуральное число");
Console.Write("N=");
int number = int.Parse(Console.ReadLine());
Console.WriteLine("Натуральные числа от N до 1");
Console.WriteLine(naturalNumbers(number));