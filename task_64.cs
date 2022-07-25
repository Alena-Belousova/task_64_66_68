// Задайте значения M и N. Напишите программу, 
//которая выведет все натуральные числа в промежутке от M до N.
Console.WriteLine("задача 64");
Console.Write("задайте количество строк матрицы M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("задайте количество строк матрицы N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Numb(n, m));
int Numb(int n, int m)
{
   int max = m;
    int min = n;
    if (max < min)
    {
        max = n;
        min = m;
    }
    if (min == max) 
    return min;
    else
    {
        Console.Write(Numb(max - 1, min) + ";");
        return max;

    }
}