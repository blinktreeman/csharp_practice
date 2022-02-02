// Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0
// Порядок четвертей против часовой стрелки

Console.WriteLine("Введите координату X точки (нулевое значение не допускается)");
int coordX = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату Y точки (нулевое значение не допускается)");
int coordY = int.Parse(Console.ReadLine());

int quarterNum = 1;

if (coordX == 0 | coordY == 0)
{
    Console.WriteLine("Нулевое значение недопустимо");
    return;
}
if (coordX > 0 & coordY > 0) quarterNum = 1;
if (coordX < 0 & coordY > 0) quarterNum = 2;
if (coordX < 0 & coordY < 0) quarterNum = 3;
if (coordX > 0 & coordY < 0) quarterNum = 4;
Console.WriteLine("Точка находится в " + quarterNum + " четверти");
