Console.WriteLine("Введите два числа");

int numA = int.Parse(Console.ReadLine());
int numB = int.Parse(Console.ReadLine());

if (numA == numB * numB) Console.WriteLine("Число " + numA + " есть квадрат числа " + numB);
else Console.WriteLine("Число " + numA + " не является квадратом числа " + numB);
