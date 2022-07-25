// Напишите программу вычисления функции Аккермана 
//с помощью рекурсии. Даны два неотрицательных числа m и n.
//A (m,n)
//1)если m=0 тогда n+1
//2)если m>0, n=0 тогда А (m-1, 1)
//3)если m>0, n>0 тогда A(m-1, A(m, n-1))
Console.WriteLine("задача 68");
Console.Write("задайте M: ");//0
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("задайте N: ");//2
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Akerman(m, n));

int Akerman(int a, int b)
{
    
    if (a == 0)
    {
        return b + 1;
    }
    else if (a > 0 && b == 0)
    {
        return Akerman(a-1,1) ;
    }
    else if (a> 0 && b > 0)
    {
        return Akerman(a-1, Akerman(a, b-1));
    }
    Console.WriteLine("что-то пошло не так!!");
   return 0; 
}

