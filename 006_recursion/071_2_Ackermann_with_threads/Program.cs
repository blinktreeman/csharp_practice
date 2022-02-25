// Написать программу вычисления функции Аккермана

//              | n + 1,                    m = 0;
//  A(m, n) =   | A(m - 1, 1),              m > 0, n = 0;
//              | A(m - 1, A(m, n - 1))     m > 0, n > 0.

using System.Diagnostics;
using System.Runtime.CompilerServices;
ulong count = 0;

int[] Ackermann(int[] mn)
{
    count++;
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

Stopwatch stopWatch = new Stopwatch();
stopWatch.Start();
Console.WriteLine($"результат вычисления функции Аккермана равен {Ackermann(mnAckermann)[1]}");
stopWatch.Stop();
TimeSpan ts = stopWatch.Elapsed;
string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:000}",
            ts.Hours, ts.Minutes, ts.Seconds,
            ts.Milliseconds);
Console.WriteLine("Время выполнения hrs:min:sec:ms " + elapsedTime);
Console.WriteLine($"Входов в метод {count}");