// Задача 68: Напишите программу вычисления функции Аккермана с помощью
// рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
int Aker(int n, int m)
{
    if (n<0 || m<0) return -1;
    if (n == 0) return m + 1;
    else if (n > 0 && m == 0) return Aker(n - 1, 1);
    return Aker(n - 1, Aker(n, m - 1));

}
Console.Write("Введите первое число: ");
int n = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число: ");
int m = int.Parse(Console.ReadLine()!);
if (Aker(n,m)==-1) 
Console.WriteLine("Число не должно быть меньше нуля");
else
Console.WriteLine(Aker(n,m));
