// Задать номер четверти, показать диапазоны для возможных координат

Console.WriteLine("Введите номер четверти координатной плоскости");
int quarterNum = int.Parse(Console.ReadLine());

string xRange = "", yRange = "";

if (quarterNum < 1 | quarterNum > 4)
{
    Console.WriteLine("Ошибочное значение четверти");
    return;
}

switch (quarterNum)
{
    case 1:
        xRange = "(0; +oo)";
        yRange = "(0; +oo)";
        break;
    case 2:
        xRange = "(0; -oo)";
        yRange = "(0; +oo)";
        break;
    case 3:
        xRange = "(0; -oo)";
        yRange = "(0; -oo)";
        break;
    case 4:
        xRange = "(0; +oo)";
        yRange = "(0; -oo)";
        break;
}

Console.WriteLine("Диапазоны координат для четверти " + quarterNum);
Console.WriteLine("по X " + xRange);
Console.WriteLine("по Y " + yRange);
