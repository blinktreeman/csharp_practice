// Найти третью цифру числа или сообщить, что её нет

Console.WriteLine("Введите целое число");

int number = int.Parse(Console.ReadLine());

if (number > 99) 
{
    Console.WriteLine("Третья цифра от конца (третий разряд) в числе " + number / 100 % 10);
    
    int tempNum = number;
    int numDigits = 0;
    while (tempNum > 0)         // how many digits in a number
    {
        tempNum = tempNum / 10;
        numDigits++;
    }
    while (numDigits > 3)       // magic number!
    {
        number = number / 10;
        numDigits--;
    }

    Console.WriteLine("Третья цифра от начала в числе " + number % 10);
}
else Console.WriteLine("В числе нет третьей цифры");
