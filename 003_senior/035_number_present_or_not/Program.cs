// Определить, присутствует ли в заданном массиве, некоторое число

int[] arrayA = new int[8] {1, 2, 3, 4, 5, 6, 7, 8};

Console.WriteLine("Введите целое число");
int number = int.Parse(Console.ReadLine());

for (int i = 0; i < arrayA.Length; i++)
{
    if (arrayA[i] == number)
    {
        Console.WriteLine("Число {0} присутствует в массиве", number);
        return;
    }
}

Console.WriteLine("Число {0} отсутствует в массиве", number);
