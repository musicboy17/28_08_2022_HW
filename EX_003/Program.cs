// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

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
int summ = 0;
double arithmeticMean = 0;
for (int i = 0; i < columnsLength; i++)
{
    for (int j = 0; j < rowsLength; j++)
    {
        summ = summ + table[i, j];
        
    }
      arithmeticMean = summ / columnsLength-1;

      Console.Write($"{arithmeticMean}   ");

}
