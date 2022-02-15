// Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел

int[] arrayA = new int[30];
Random rand = new Random();
int evenNum = 0;
int oddNum = 0;

Console.WriteLine("Массив с числами:");

for (int i = 0; i < arrayA.Length; i++)
{
    arrayA[i] = rand.Next(100, 1000);
    if (arrayA[i] % 2 == 0) evenNum++;
    else oddNum++;
    Console.Write($"{arrayA[i]} ");
}

Console.WriteLine($"\nКоличество четных чисел в массиве {evenNum}");
Console.WriteLine($"Количество нечетных чисел в массиве {oddNum}");
