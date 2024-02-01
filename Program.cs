//Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.
System.Console.WriteLine("Task 1");
void naturalNumbers(int M, int N)
{
    if (M != N)
    {
        System.Console.Write($"{M} ");
        naturalNumbers(++M, N);
        return;
    }
    System.Console.Write($"{M} ");
    return;
}

void inputNumbers()
{
    System.Console.Write("input M: ");
    int M = int.Parse(Console.ReadLine()!);
    System.Console.Write("input N: ");
    int N = int.Parse(Console.ReadLine()!);
    naturalNumbers(M, N);
}
inputNumbers(); // Запуск 1 задачи

//Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
System.Console.WriteLine("\n\nTask 2");
int functionAccerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0)
    {
        return functionAccerman(m - 1, 1);
    }
    else
    {
        return functionAccerman(m - 1, functionAccerman(m, n - 1));
    }
}
void showAccerman()
{
    System.Console.Write("input M: ");
    int M = int.Parse(Console.ReadLine()!);
    System.Console.Write("input N: ");
    int N = int.Parse(Console.ReadLine()!);
    int result = functionAccerman(N, M);
    System.Console.WriteLine(result);
}
showAccerman(); // Запуск 2 задачи
//Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.
System.Console.WriteLine("\n\nTask3");
int[] numbers = { 1, 2, 5, 0, 10, 34, 54, 22, 0, 33 };
System.Console.Write("Array: ");
System.Console.WriteLine(String.Join(", ", numbers));
void showNumbers(int i = 0)
{
    if (i != numbers.Length - 1)
    {
        showNumbers(++i);
        System.Console.Write($"{numbers[--i]} ");
        return;
    }
    System.Console.Write($"{numbers[i]} ");
    return;
}
showNumbers(); // Запуск 3 задачи
