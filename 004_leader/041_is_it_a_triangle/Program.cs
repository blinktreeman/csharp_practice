// Выяснить являются ли три числа сторонами треугольника

bool sideIsLonger(int idx, int[] arrA)
{
    int sum = 0;
    for (int i = 0; i < arrA.Length; i++)
    {
        if (i != idx) sum += arrA[i];
    }
    return (arrA[idx] >= sum);
}

int[] triangleSides = new int[3];

Console.WriteLine("Введите значения длин сторон треугольника");
Console.Write("сторона a = ");
triangleSides[0] = int.Parse(Console.ReadLine());
Console.Write("сторона b = ");
triangleSides[1] = int.Parse(Console.ReadLine());
Console.Write("сторона c = ");
triangleSides[2] = int.Parse(Console.ReadLine());

for (int i = 0; i < triangleSides.Length; i++)
{
    if (sideIsLonger(i, triangleSides))
    {
        Console.WriteLine("Одна из заданных сторон больше или равна сумме двух других.");
        Console.WriteLine("Заданные значения не могут являться сторонами треугольника");
        return;
    }
}

Console.WriteLine("Заданные значения могут являться сторонами треугольника");
