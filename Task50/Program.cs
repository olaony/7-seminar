// Напишите программу, которая на вход принимает позиции 
// элемента в двумерном массиве, и возвращает значение 
// этого элемента или же указание, что такого элемента нет.

Console.Write("Введите количество строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());

int[, ] matrix = new int[n, m];
InputMatrix(matrix);
PrintMatrix(matrix);

void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(-10, 11);      
    }
}

void PrintMatrix(int[,] matrix)
{
    Console.WriteLine(); 
        for (int i = 0; i < matrix.GetLength(0); i++) 
        { 
            for (int j = 0; j < matrix.GetLength(1); j++) 
                Console.Write(matrix[i, j] + " \t"); 
            Console.WriteLine();
        }
}

Console.Write("Введите номер столбца: ");
int k = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Введите номер строки: ");
int l = Convert.ToInt32(Console.ReadLine()); 

FindPosition(matrix, k, l);



void FindPosition(int[,] matrix, int i, int j)
{
        if (i < matrix.GetLength(0) && j < matrix.GetLength(1)) 
            Console.WriteLine(matrix[i,j]);  
        else Console.WriteLine("there is no position"); 
}

