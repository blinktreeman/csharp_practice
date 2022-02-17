// Найти точку пересечения двух прямых заданных уравнением 
// y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы

double  k1 = 3, k2 = 5, 
        b1 = 2, b2 = 8,
        xCross = 0, yCross = 0;

/* 
y1 = k1 * x + b1
y2 = k2 * x + b2
В точке пересечения y1 = y2, x1 = x2
k1 * x + b1 = k2 * x + b2, отсюда:
k1 * x - k2 * x = b2 - b1
x = (b2 - b1) / (k1 - k2)
*/

Console.WriteLine("Точка персечения прямых");
Console.WriteLine($"1. y = {k1} * x + {b1}");
Console.WriteLine($"2. y = {k2} * x + {b2}");

if (k1 == k2) 
{
    Console.WriteLine("Прямые не пересекаются");
    return;
}

xCross = (b2 - b1) / (k1 - k2);

// Y из первого уравнения:
yCross = k1 * xCross + b1;

Console.WriteLine($"есть точка с координатами ({xCross}, {yCross})");
