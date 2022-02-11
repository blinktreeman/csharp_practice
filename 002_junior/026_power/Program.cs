// Возведите число А в натуральную степень B используя цикл

Console.WriteLine("Введите основание степени А");
int baseNum = int.Parse(Console.ReadLine());
Console.WriteLine("Введите показатель степени В");
int indexNum = int.Parse(Console.ReadLine());

int sum = 1;
string sumStr = string.Empty;

for (int i = 1; i <= Math.Abs(indexNum); i++) 
{
    sum *= baseNum;
}
sumStr = sum.ToString();
if (indexNum < 0) sumStr = "1/" + sumStr;       // for negative indexes

Console.WriteLine($"Число {baseNum} в степени {indexNum} равно {sumStr}");
