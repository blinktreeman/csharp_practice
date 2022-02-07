// Задать массив из 8 элементов и вывести их на экран

int[] arrayA = new int[8] {1, 2, 3, 4, 5, 6, 7, 8};

for (int i = 0; i < arrayA.Length; i++)
{
    Console.WriteLine("Элемент массива {0} равен {1}", i+1, arrayA[i]);
}
