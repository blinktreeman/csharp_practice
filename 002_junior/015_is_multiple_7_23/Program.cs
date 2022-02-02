// Дано число. Проверить кратно ли оно 7 и 23

Console.WriteLine("Введите целое число");

int number = int.Parse(Console.ReadLine());

if (number % 7 == 0 & number % 23 == 0) Console.WriteLine("Число кратно 7-ми и 23-ем");
else Console.WriteLine("Число не кратно 7-ми или 23-ем");
