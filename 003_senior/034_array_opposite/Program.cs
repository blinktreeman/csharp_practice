// Написать программу замены элементов массива на противоположные

int[] arrayA = new int[10] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

Console.WriteLine("Исходный массив");
Console.WriteLine(string.Join(" ", arrayA));

for (int i = 0; i < arrayA.Length / 2; i++)
{
    int temp = arrayA[i];
    arrayA[i] = arrayA[^(i+1)];
    arrayA[^(i+1)] = temp;
}

Console.WriteLine("Элементы заменены на противоположные");
Console.WriteLine(string.Join(" ", arrayA));
