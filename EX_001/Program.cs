// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными 
// вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

Console.WriteLine("Введите размер двумерного масситва");
Console.WriteLine("количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

int rowsLength = rows;
int columnsLength = columns;

double [,] table = new double[rows, columns]; 

// for (rows = 0; rows < rowsLength; rows++)
// {
//     for (columns = 0; columns  < columnsLength; columns++)
//     {
//         Console.Write($"{table[rows, columns]} ");
//     }
//     Console.WriteLine();
// }

void FillArray(double[,] table)
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
