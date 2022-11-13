// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
int m = 1;
int n = 20;
int sum = 0;
SumElements();
Console.Write(sum);

void SumElements()
{
    if (m <= n)
    {
        sum = sum + m;
        m = m+1;
        SumElements();
    }
}