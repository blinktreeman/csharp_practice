// Определить количество цифр в слове (числе)

/*Console.WriteLine("Введите целое число");
int number = int.Parse(Console.ReadLine());
int numDigits = 1;

Console.Write("В числе {0}", number);

while (Math.Abs(number) > 9)
{
    number /= 10;       // 123456
    numDigits ++;
}

Console.WriteLine(" разрядов {0}", numDigits);
*/

Console.WriteLine("Введите последовательность знаков");
string strA = Console.ReadLine();

//int[] arrayA = new int[10] {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};

int count = 0;
int number;

for (int i = 0; i < strA.Length; i++)
{
    if (int.TryParse(strA[i].ToString(), out number)) count++;
}
Console.WriteLine($"Количество цифр {count}");

//foreach (strA) 
//{
//    int.TryParse(strA)
//}