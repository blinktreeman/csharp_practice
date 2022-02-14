// 
/*
Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());

string reverseNum (int num)
{
    if (num < 10) return num.ToString(); 
    else
    {
        return (num % 10).ToString() + reverseNum (num / 10);
    }
}

Console.WriteLine(reverseNum(number));
*/

Console.WriteLine("Введите число");                     // 2    3
int number = int.Parse(Console.ReadLine());             // 2    2
Console.WriteLine("Введите степень числа");             // 2   1
int index = int.Parse(Console.ReadLine());              //

int stepen (int num, int ind)
{
    if (ind == 0) return 1;
    if (ind == 1) return num;
    else return num *= stepen(num, ind - 1 );
}

Console.WriteLine(stepen(number, index));
