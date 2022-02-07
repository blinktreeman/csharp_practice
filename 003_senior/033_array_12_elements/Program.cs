// Задать массив из 12 элементов, заполненных числами из [0,9]. Найти сумму положительных/отрицательных??? элементов массива

int[] arrayA = new int[12];

for (int i = 0; i < arrayA.Length; i++)
{
    arrayA[i] = new Random().Next(0, 10);
    Console.WriteLine("Элемент массива {0} равен {1}", i+1, arrayA[i]);
}

int sumPositive = 0;
int sumNegative = 0;

for (int i = 0; i < arrayA.Length; i++)
{
    if (arrayA[i] > 0) sumPositive += arrayA[i];
    else sumNegative += arrayA[i];
}

Console.WriteLine("Сумма положительных чисел равна {0}", sumPositive);
Console.WriteLine("Сумма отрицательных чисел равна {0}", sumNegative);