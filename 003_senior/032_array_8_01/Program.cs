// Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран

int[] arrayA = new int[8];
Random rand = new Random();

for (int i = 0; i < arrayA.Length; i++) arrayA[i] = rand.Next(0, 2);

Console.WriteLine("Элементы массива");
Console.WriteLine(string.Join(" ", arrayA));
