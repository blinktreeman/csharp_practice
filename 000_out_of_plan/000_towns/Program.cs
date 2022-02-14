using System;

string strAns = String.Empty;
int coldTemp = 100;
int hotTemp = -100;
string coldCity = String.Empty;
string hotCity = String.Empty;
int sum = 0;
int count = 0;

do
{    
    Console.WriteLine("Введите Город и температуру через пробел");
    string strA = Console.ReadLine();
    string[] arrStr = strA.Split(" ");
    string Town = arrStr[0];
    int Tem = int.Parse(arrStr[1]);
    sum += Tem;
    if (Tem < coldTemp) 
    {
        coldTemp = Tem;
        coldCity = Town;
    }
    if (Tem > hotTemp) 
    {
        hotTemp = Tem;
        hotCity = Town;
    } 
    count ++;

    Console.WriteLine("Продолжить?");
    strAns = Console.ReadLine();

} while (strAns != "нет");

Console.WriteLine($"Теплый город {hotCity}");
Console.WriteLine($"Холодный город {coldCity}");
Console.WriteLine($"Средняя температура {sum / count}");
