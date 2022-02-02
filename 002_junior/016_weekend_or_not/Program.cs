// Дано число обозначающее день недели. Выяснить является номер дня недели выходным

Console.WriteLine("Введите номер дня недели");

int weekDayNum = int.Parse(Console.ReadLine());

if (weekDayNum == 6 ^ weekDayNum == 7) Console.WriteLine("День недели с номером " + weekDayNum + " выходной");
else Console.WriteLine("День недели с номером " + weekDayNum + " не выходной");
