// Задача 50. Напишите программу, которая на вход принимает позиции 
// элемента в двумерном массиве, и возвращает значение этого элемента 
// или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 1,7 -> такого числа в массиве нет (1 строчка, 7 столбец)

Console.WriteLine("Введите размер двумерного масситва");
Console.WriteLine("количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

int rowsLength = rows;
int columnsLength = columns;

int [,] table = new int[rows, columns]; 

void FillArray(int [,] table)
{
    for (int i = 0; i < rowsLength; i++)
    {
        for (int j = 0; j < columnsLength; j++)
        {
            table[i,j] = new Random().Next(-10, 10);
        }
    }
}
FillArray(table);

for (rows = 0; rows < rowsLength; rows++)
{
    for (columns = 0; columns  < columnsLength; columns++)
    {
        Console.Write($"{table[rows, columns]} ");
    }
    Console.WriteLine();
}

Console.WriteLine("Введите позицию элемента в массиве - номер строки: ");
int rowsPosition = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите позицию элемента в массиве - номер столбца: ");
int columnsPosition = Convert.ToInt32(Console.ReadLine());

if (rowsPosition > rows || columnsPosition > columns)
{
    Console.WriteLine("Такой позиции нет");
}
else 
Console.WriteLine($"Значение элемента: {table[rowsPosition, columnsPosition]} ");

