// Задайте двумерный массив из целых чисел. Найдите среднее 
//арифметическое элементов в каждом столбце.

Console.Write("Введите количество строк: ");
int n = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Введите количество столбцов: ");
int m = Convert.ToInt32(Console.ReadLine()); 

int[,] matrix = new int[n, m];
for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(-10, 11);
    }

Console.WriteLine();
float[] summ = new float[m];

for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + " \t");
            }
            Console.WriteLine();
    }

for (int i = 0; i < matrix.GetLength(0); i++)
    {
        summ[i] = 0;
        for (int j = 0; j < matrix.GetLength(0); j++)
            {
                summ[i] += matrix[j, i];
            }
        summ[i] = summ[i] / (float)n;
    }
        Console.WriteLine("Среднее арифметическое столбцов: "+ string.Join(" ", summ));
    






