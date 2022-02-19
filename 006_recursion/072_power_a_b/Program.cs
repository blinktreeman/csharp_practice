// Написать программу возведения числа А в целую стень B

int PowerAB(int baseNum, int indexNum)
{
    if (indexNum == 1) return baseNum;
    else return baseNum * PowerAB(baseNum, --indexNum);
}

Console.WriteLine("Задайте основание степени");
Console.Write("A=");
int baseNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Задайте показатель степени");
Console.Write("B=");
int indexNumber = int.Parse(Console.ReadLine());

Console.WriteLine($"Число {baseNumber} в степени {indexNumber} равно {PowerAB(baseNumber, indexNumber)}");
