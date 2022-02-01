Console.WriteLine("Введите два числа");

int numA = int.Parse(Console.ReadLine());
int numB = int.Parse(Console.ReadLine());

if (numA > numB) Console.WriteLine("Большее число " + numA + " и меньшее " + numB);
else 
{
    if (numA < numB) Console.WriteLine("Большее число " + numB + " и меньшее " + numA);
    else Console.WriteLine("Числа равны");
}