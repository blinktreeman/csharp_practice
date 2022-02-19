// Сформировать трехмерный массив не повторяющимися двузначными числами
// показать его построчно на экран выводя индексы соответствующего элемента

int[,,] threeDimArray = new int [4, 4, 4];
int count = 10;

for (int i = 0; i < threeDimArray.GetLength(0); i++)
{
    for (int j = 0; j < threeDimArray.GetLength(1); j++)
    {
        for (int k = 0; k < threeDimArray.GetLength(2); k++)
        {
            threeDimArray[i, j, k] = count++;
        }
    }
}

for (int i = 0; i < threeDimArray.GetLength(0); i++)
{
    for (int j = 0; j < threeDimArray.GetLength(1); j++)
    {
        for (int k = 0; k < threeDimArray.GetLength(2); k++)
        {
            Console.WriteLine($"[{i}, {j}, {k},] {threeDimArray[i, j, k]}");
        }
    }
}
