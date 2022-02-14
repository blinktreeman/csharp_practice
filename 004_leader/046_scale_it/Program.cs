// Написать программу масштабирования фигуры

using System.Globalization;
// Дробная часть через точку
CultureInfo culture = CultureInfo.CreateSpecificCulture("en-US");

Console.WriteLine("Задайте координаты вершин фигуры");
Console.WriteLine("в виде (0,0) (2,0) (2,2) (0,2)");
Console.WriteLine("Дробная часть чисел отделяется точкой '.'");
string vertexStr = Console.ReadLine();
Console.WriteLine("Задайте коэффициент масштабирования фигуры");
string scaleInd = Console.ReadLine();
if (double.Parse(scaleInd, culture) < 0)
{
    Console.WriteLine("масштаб не может быть отрицательным");
    return;
}

// Разделители
char[] separators = new char[] {' ', ',', '(', ')'};
string[] vertexCharArr = vertexStr.Split(separators, StringSplitOptions.RemoveEmptyEntries);
double[] vertexDoubleArr = new double[vertexCharArr.Length];

for (int i = 0; i < vertexCharArr.Length; i++)
{
    vertexDoubleArr[i] = double.Parse(vertexCharArr[i], culture) * double.Parse(scaleInd, culture);
}

Console.WriteLine($"Координаты фигуры с масштабом {scaleInd}");
for (int i = 0; i < vertexDoubleArr.Length; i +=2)
{
    Console.Write($"({vertexDoubleArr[i]},{vertexDoubleArr[i+1]}) ");
}
