//Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
//Выполнить с помощью рекурсии.                
int n = 8;
PrintValues();




void PrintValues()
{
    if (n >= 1)
    {
        Console.Write(n);
        if (n != 1)
        {
            Console.Write(", ");
        }

        n = n - 1;
        PrintValues();
    }
}