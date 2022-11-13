﻿//  Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
int m = 3;
int n = 2;
Console.Write($"A(m,n) = "+ Ackermann (m, n));

int Ackermann(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else
    {
        if ((m != 0) && (n == 0))
        {
            return Ackermann(m - 1, 1);
        }
        else
        {
            return Ackermann(m - 1, Ackermann(m, n - 1));
        }
    }
}
