// Дано число из отрезка [10, 99]. Показать наибольшую цифру числа

Console.WriteLine("Введите число в интервале от 10 до 99");

int number = int.Parse(Console.ReadLine());

if (number/10 > number%10) Console.WriteLine("Большее значение " + number/10);
else Console.WriteLine("Большее значение " + number%10);
