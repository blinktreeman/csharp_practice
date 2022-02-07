// Дано число обозначающее день недели. Выяснить является номер дня недели выходным

Console.WriteLine("Введите номер дня недели");

int weekDayNum = int.Parse(Console.ReadLine());

if (weekDayNum < 1 | weekDayNum > 7) 
{
    Console.WriteLine("Некорректный номер дня");
    return;
}

if (weekDayNum == 6 ^ weekDayNum == 7) Console.WriteLine("День недели с номером {0} выходной", weekDayNum);
else Console.WriteLine("День недели с номером {0} не выходной", weekDayNum);
