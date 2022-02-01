// По заданному номеру дня недели вывести его название

string[] weekDays = new string[] {"Понедельник",
                                    "Вторник",
                                    "Среда",
                                    "Четверг",
                                    "Пятница",
                                    "Суббота",
                                    "Воскресенье"};

Console.WriteLine("Введите номер дня в неделе");

int dayNum = int.Parse(Console.ReadLine());

if (dayNum > 0 & dayNum < 8) Console.WriteLine("День недели под номером " + dayNum + " это " + weekDays[dayNum-1]);
else Console.WriteLine("Такого дня не бывает");
