// Определить количество цифр в числе

Console.WriteLine("Введите целое число");
string numStr = Console.ReadLine();

Console.WriteLine("В числе {0} разрядов {1}", numStr, numStr.Length);

int number = int.Parse(numStr);
int numDigits = 0;

while (number > 0)
{
    number /= 10;
    numDigits ++;
}

Console.WriteLine("Точно, разрядов {0}", numDigits);
