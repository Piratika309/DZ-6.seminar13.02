// Показать двумерный массив размером m×n заполненный вещественными числами

Console.WriteLine("Введите количество строк: ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите количество столбцов: ");
int n = int.Parse(Console.ReadLine() ?? "0");

double [,] array = new double [n,m];
Random random = new Random();
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i,j] = random.NextDouble()*100;
        Console.Write($"{array[i,j]}\t");
    }
     Console.WriteLine();
}
