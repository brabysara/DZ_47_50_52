// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

int m = GetNumberFU("Задайте строки ","Ошибка ввода!");
int n = GetNumberFU("Задайте столбцы ","Ошибка ввода!");
int minValue = GetNumberFU("Задайте минимальное значение случайного вещества ","Ошибка ввода!");
int maxValue = GetNumberFU("Задайте максимальное значение случайного вещества  ","Ошибка ввода!");

int GetNumberFU(string m , string b )
{
    while(true)
    {
        Console.WriteLine(m);
        if (int.TryParse(Console.ReadLine(), out int UN ))
            return UN;
        Console.WriteLine(b);
    }
}

double[,] zapl = Zapl(m, n , minValue, maxValue);

double[,] Zapl(int m , int n, int minValue , int maxValue)
{
    double[,] vivod = new double[m,n];
    for(int i = 0; m > i; i++)
    {
        for(int g = 0; n > g; g++)
    {
        vivod[i,g] = new Random().Next(minValue * 10 , maxValue * 10)/10.0;
    }
    }
    return vivod;
}

vivod(zapl);

void vivod(double[,] zapoln)
{
    for(int i = 0; zapoln.GetLength(0) > i; i++)
    {
        for(int g = 0; zapoln.GetLength(1) > g; g++)
        {
            Console.Write($" {zapoln[i,g]}");
        }
    Console.WriteLine();
    }
}


//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

int m1 = GetNumberFU("Задайте строки ","Ошибка ввода!");
int n1 = GetNumberFU("Задайте столбцы ","Ошибка ввода!");
int minValue1 = GetNumberFU("Задайте минимальное значение случайного вещества ","Ошибка ввода!");
int maxValue1 = GetNumberFU("Задайте максимальное значение случайного вещества  ","Ошибка ввода!");

double[,] zapl1 = Zapl1(m1, n1 , minValue1, maxValue1);

double[,] Zapl1(int m , int n, int minValue , int maxValue)
{
    double[,] vivod = new double[m,n];
    for(int i = 0; m > i; i++)
    {
        for(int g = 0; n > g; g++)
    {
        vivod[i,g] = new Random().Next(minValue, maxValue +1);
    }
    }
    return vivod;
}

int znachenie1 = GetNumberFU("Введите строку ","Ошибка ввода!");

int znachenie2 = GetNumberFU("Введите столбец ","Ошибка ввода!");

vivod(zapl1);
try
{
    
    Console.WriteLine(zapl1[znachenie1,znachenie2]+"-> Такое число есть");
}
catch
{
    Console.Write("->  такого числа нет ");
}


//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.


int rows = 3;
int colums = 4;
int[,] numbers = new int[rows, colums];
FillArray2D(numbers);
PrintArray2D(numbers);

double[] avgNumbers = new double[numbers.GetLength(1)];

for (int i = 0; i < numbers.GetLength(1); i++)
{
    double result = 0.0;
    for (int j = 0; j < numbers.GetLength(0); j++)
    {
        result += numbers[j, i];
    }
    avgNumbers[i] = result / numbers.GetLength(0);
}
PrintArray(avgNumbers);


void FillArray2D(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}


void PrintArray2D(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}


void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}


int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

