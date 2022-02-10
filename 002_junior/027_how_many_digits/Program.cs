// Определить количество цифр в слове

Console.WriteLine("Введите последовательность знаков");
string strA = Console.ReadLine();

int count = 0;
int number;

for (int i = 0; i < strA.Length; i++)
{
    if (int.TryParse(strA[i].ToString(), out number)) count++;
}
Console.WriteLine($"Количество цифр {count}");
