// Найти сумму чисел одномерного массива стоящих на нечетной позиции

int[] arrayA = new int[10];
Random rand = new Random();

Console.WriteLine("Задан массив со следующими элементами:");
for (int i = 0; i < arrayA.Length; i++)
{
    arrayA[i] = rand.Next(0, 10);
    Console.Write($"{arrayA[i]} ");
}

int sum = 0;

for (int i = 0; i < arrayA.Length; i += 2)
{
    sum += arrayA[i];
}

Console.WriteLine($"\nСумма чисел одномерного массива стоящих на нечетной позиции равна {sum}");
