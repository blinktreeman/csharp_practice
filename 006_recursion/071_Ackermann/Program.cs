// Написать программу вычисления функции Аккермана

//              | n + 1,                    m = 0;
//  A(m, n) =   | A(m - 1, n),              m > 0, n = 0;
//              | A(m - 1, A(m, n - 1))     m > 0, n > 0.

int[] Ackermann(int[] mn)
{
    if (mn[0] == 0) return mn{0, n + 1};
}


int[] mnAckermann = new int[2];
Console.WriteLine("Задайте натуральное число");
Console.Write("m=");
mnAckermann[0] = int.Parse(Console.ReadLine());
Console.WriteLine("Задайте натуральное число");
Console.Write("n=");
mnAckermann[1] = int.Parse(Console.ReadLine());

Console.WriteLine(Ackermann(mnAckermann));