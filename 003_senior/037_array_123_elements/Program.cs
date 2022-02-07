// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

int[] arrayA = new int[123];
Random rand = new Random();

Console.WriteLine("Задан массив со следующими элементами:");
for (int i = 0; i < arrayA.Length; i++)
{
    arrayA[i] = rand.Next(0, 1000);
    Console.Write(arrayA[i] + " ");
}

int count = 0;

for (int i = 0; i < arrayA.Length; i++)
{
    if (arrayA[i] >= 10 & arrayA[i] <= 99) count++;
}

Console.WriteLine("\n"+"В массиве {0} элементов принадлежащих интервалу [10,99]", count);
