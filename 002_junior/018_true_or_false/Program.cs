// Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y

bool[,] variantsArr = new bool[4, 2]{{true, true}, {true, false}, {false, true}, {false, false}};

Console.WriteLine("Таблица истинности");
Console.WriteLine("|   X   |   Y   | ¬(X ⋁ Y) = ¬X ⋀ ¬Y  |");
for (int i = 0; i < 4; i++)
{
    Console.WriteLine("| " + Convert.ToString(variantsArr[i, 0]) + " | " + Convert.ToString(variantsArr[i, 1]) + " | " + 
        Convert.ToString(!(variantsArr[i, 0] & variantsArr[i, 1]) == !variantsArr[i, 0] | !variantsArr[i, 1]));
}
