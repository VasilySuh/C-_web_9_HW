// Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. 
// Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


int SumOfRangeOfNumbers(int numA, int numB)
{
    if (numA == numB) return numA;
    else
    {
        return SumOfRangeOfNumbers(numA + 1, numB) + numA;
    }
}

Console.WriteLine("Введите первое натуральное число: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе натуральное число: ");
int numberN = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

Console.WriteLine($"Сумма натуральных элементов в промежутке от {numberM} до {numberN} = {SumOfRangeOfNumbers(numberM, numberN)}");