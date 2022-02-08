// Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y

bool[,] variantsArr = new bool[4, 2]{{true, true}, {true, false}, {false, true}, {false, false}};

for (int i = 0; i < 4; i++)
{
    if (!(variantsArr[i, 0] & variantsArr[i, 1]) == !variantsArr[i, 0] | !variantsArr[i, 1])    // ¬(X ⋁ Y) = ¬X ⋀ ¬Y
    {
        Console.WriteLine("Значения переменных X = {0}, Y = {1}. Утверждение истинно", variantsArr[i, 0], variantsArr[i, 1]);
    }
    else 
    {
        Console.WriteLine("Значения переменных X = {0}, Y = {1}. Утверждение ложно", variantsArr[i, 0], variantsArr[i, 1]);
    }
}
