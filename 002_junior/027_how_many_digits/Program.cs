// Определить количество цифр в числе

Console.WriteLine("Введите целое число");
int number = int.Parse(Console.ReadLine());
int numDigits = 1;

Console.Write("В числе {0}", number);

while (Math.Abs(number) > 9)
{
    number /= 10;
    numDigits ++;
}

Console.WriteLine(" разрядов {0}", numDigits);
