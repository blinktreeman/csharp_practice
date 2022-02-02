// Написать программу вычисления значения функции y = f(a)

int faMethod(int a)
{
    int y = a;  // some function y = f(a)
    return y;
}

Console.WriteLine("Для вычисления значения y = f(a) введите значение аргумента 'a'");
int numA = int.Parse(Console.ReadLine());

Console.WriteLine("Значение функции равно " + faMethod(numA));
