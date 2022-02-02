// Программа проверяет является ли пятизначное число палиндромом

Console.WriteLine("Введите пятизнаяное целое число");

int number = int.Parse(Console.ReadLine());

if (number < 10000 | number > 99999)
{
    Console.WriteLine("Число не пятизначное");
    return;
}

if (number / 10000 == number % 10 & number / 1000 % 10 == number / 10 % 10)
{
    Console.WriteLine("Число " + number + " является палиндромом");
}
else Console.WriteLine("Число " + number + " не является палиндромом");
