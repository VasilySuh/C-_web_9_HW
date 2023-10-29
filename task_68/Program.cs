// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int Ackermann(int m, int n)
{
    if (m == 0)
    {
        if (n == 0)
            return 1;
        else
            return Ackermann(0, n - 1) + Ackermann(0, n - 1);
    }
    else if (n == 0)
        return Ackermann(m - 1, 1);
    else
        return Ackermann(m - 1, 1) + Ackermann(m, n - 1);
}

Console.WriteLine("Введите первое неотрицательное число: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе неотрицательное число: ");
int numberN = Convert.ToInt32(Console.ReadLine());
if (numberM < 0 || numberN < 0)
{
    Console.WriteLine("Ошибка ввода!");
    return;
}
Console.WriteLine();
Console.WriteLine($"Результат функции Аккермана -> {Ackermann(numberM, numberN)}");