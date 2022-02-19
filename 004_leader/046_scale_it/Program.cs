// Написать программу масштабирования фигуры

using System.Globalization;
// Дробная часть через точку
CultureInfo culture = CultureInfo.CreateSpecificCulture("en-US");

void ShowResult (double[] vertexArray)
{
    Console.WriteLine($"Координаты масштабированной фигуры");
    for (int i = 0; i < vertexArray.Length; i += 2)
    {
        Console.Write($"({vertexArray[i]},{vertexArray[i+1]}) ");
    }
}

double[] ScaleIt(double[] vertexArray, double scaleIdx)
{
    for (int i = 0; i < vertexArray.Length; i++)
    {
        vertexArray[i] = vertexArray[i] * scaleIdx;
    }
    return vertexArray;
}

Console.WriteLine("Задайте координаты вершин фигуры");
Console.WriteLine("в виде (0,0) (2,0) (2,2) (0,2)");
Console.WriteLine("Дробная часть чисел отделяется точкой '.'");
string vertexStr = Console.ReadLine();
Console.WriteLine("Задайте коэффициент масштабирования фигуры");
double scaleIndex = double.Parse(Console.ReadLine(), culture);

if (scaleIndex < 0)
{
    Console.WriteLine("Масштаб не может быть отрицательным");
    return;
}

// Разделители
char[] separators = new char[] {' ', ',', '(', ')'};
string[] vertexCharArr = vertexStr.Split(separators, StringSplitOptions.RemoveEmptyEntries);
double[] vertexDoubleArr = new double[vertexCharArr.Length];

for (int i = 0; i < vertexCharArr.Length; i++)
{
    vertexDoubleArr[i] = double.Parse(vertexCharArr[i], culture); //* double.Parse(scaleIndex, culture);
}

// Проверяем, находится ли одна из вершин фигуры в точке (0, 0)
for (int i = 0; i < vertexDoubleArr.Length; i += 2)
{
    if (vertexDoubleArr[i] == 0 && vertexDoubleArr[i+1] == 0) 
    {
        ShowResult(ScaleIt(vertexDoubleArr, scaleIndex));
        return;
    }
}

ShowResult(ScaleIt(vertexDoubleArr, scaleIndex));
