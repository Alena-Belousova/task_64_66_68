// Задайте значения M и N. Напишите программу, 
//которая найдёт сумму натуральных элементов в промежутке от M до N.
Console.WriteLine("задача 66");
Console.Write("задайте количество строк матрицы M: ");//5
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("задайте количество строк матрицы N: ");//10
int n = Convert.ToInt32(Console.ReadLine());
int sum = 0;
if (m > n)//5<10
{
    int t = m;//10
    m = n;//5
    n = t;
}
if (m == n)
    Console.WriteLine(n);
else
{
    Console.WriteLine(Numbers(n, m));
}

int Numbers(int a, int b)
{
    int max = a;//5
    int min = b;//10

    if (min <= max)//5<10
    {
        sum = sum + min;
        min++;
        return Numbers(max, min);
    }
    return sum;
}
