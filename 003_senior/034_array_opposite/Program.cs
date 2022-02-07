// Написать программу замену элементов массива на противоположные

int[] arrayA = new int[8] {1, 2, 3, 4, 5, 6, 7, 8};

Console.WriteLine("Исходный массив");
for (int i = 0; i < arrayA.Length; i++)
{
    Console.Write(arrayA[i] + " ");
}

Console.WriteLine("");
Console.WriteLine("Элементы заменены на противоположные");

for (int i = 0; i < arrayA.Length / 2; i++)
{
    int temp = arrayA[i];
    arrayA[i] = arrayA[^(i+1)];
    arrayA[^(i+1)] = temp;
}

for (int i = 0; i < arrayA.Length; i++)
{
    Console.Write(arrayA[i] + " ");
}