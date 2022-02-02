// По двум заданным числам проверять является ли одно квадратом другого

Console.WriteLine("Введите два целых числа");

int numA = int.Parse(Console.ReadLine());
int numB = int.Parse(Console.ReadLine());

if (numA == numB * numB | numB == numA * numA)
{
    if (numA == numB * numB) Console.WriteLine("Число " + numA + " есть квадрат числа " + numB);
    else Console.WriteLine("Число " + numB + " есть квадрат числа " + numA);
    return;
}
Console.WriteLine("Одно число не является квадратом другого");
