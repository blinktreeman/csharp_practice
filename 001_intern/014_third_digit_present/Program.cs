// Найти третью цифру числа или сообщить, что её нет

Console.WriteLine("Введите целое число");

int number = int.Parse(Console.ReadLine());

if (Math.Abs(number) < 100) 
{
    Console.WriteLine("В числе нет третьей цифры");
    return;
}

int thirdFromLeft = 2;
if (number < 0) thirdFromLeft = 3;  // Для отрицательного числа учитываем "-"
string numStr = number.ToString();
Console.WriteLine("Третья цифра от начала в числе {0}", numStr[thirdFromLeft]);
Console.WriteLine("Третья цифра от конца в числе {0}", numStr[^3]);