// Написать программу вычисления функции Аккермана

//              | n + 1,                    m = 0;
//  A(m, n) =   | A(m - 1, 1),              m > 0, n = 0;
//              | A(m - 1, A(m, n - 1))     m > 0, n > 0.

using System.Runtime.CompilerServices;

int[] Ackermann(int[] mn)
{
    if (mn[0] == 0) 
    {
        mn[1]++;
        return mn;
    }
    else if (mn[0] > 0 & mn[1] == 0)
    {
        mn[0]--;
        mn[1] = 1;
        try
        {
            RuntimeHelpers.EnsureSufficientExecutionStack();
            return Ackermann(mn);
        }
        catch (InsufficientExecutionStackException)
        {
            var task = Task<int>.Run(() => Ackermann(mn));
            return task.Result;
        }
    }
    else
    {
        mn[1]--;
        int temp = mn[0] - 1;
        try
        {
            RuntimeHelpers.EnsureSufficientExecutionStack();
            Ackermann(mn);
        }
        catch (InsufficientExecutionStackException)
        {
            var task = Task<int>.Run(() => Ackermann(mn));
            mn = task.Result;
        }

        mn[0] = temp;
        try
        {
            RuntimeHelpers.EnsureSufficientExecutionStack();
            return Ackermann(mn);
        }
        catch (InsufficientExecutionStackException)
        {
            var task = Task<int>.Run(() => Ackermann(mn));
            return task.Result;
        }
    }
}

int[] mnAckermann = new int[2];
Console.WriteLine("Задайте натуральное число");
Console.Write("m=");
mnAckermann[0] = int.Parse(Console.ReadLine());
Console.WriteLine("Задайте натуральное число");
Console.Write("n=");
mnAckermann[1] = int.Parse(Console.ReadLine());

Console.WriteLine($"результат вычисления функции Аккермана равен {Ackermann(mnAckermann)[1]}");
