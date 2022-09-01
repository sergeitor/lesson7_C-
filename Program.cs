//  Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.


Console.WriteLine("Введите количество строк таблицы:");

int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов таблицы:");

int cols = Convert.ToInt32(Console.ReadLine());

double [,] DoubleArray(int m, int n)
{

  double [,] matrix = new double[m,n];


    for(int i = 0; i < matrix.GetLength(0); i++)
      {
          for(int j = 0; j < matrix.GetLength(1); j++)
           {
              matrix[i,j] = Math.Round((new Random().NextDouble() * 20 - 10),1);
           }
      }
      return matrix;
}

double [,] result = DoubleArray(rows,cols);

for(int i = 0; i < result.GetLength(0); i++)
{
    for(int j = 0; j < result.GetLength(1); j++)
    {
         Console.Write(result[i,j] + "\t");
    }
    Console.WriteLine();
}

//  Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
 
 int number1 = new Random().Next(1,10);

 int number2 = new Random().Next(1,10);
  


  int [,] matrix = new int[number1,number2];


    for(int i = 0; i < matrix.GetLength(0); i++)
      {
          for(int j = 0; j < matrix.GetLength(1); j++)
           {
              matrix[i,j] = new Random().Next(1,20);
           }
      }

Console.WriteLine("Введите  строку таблицы:");

int row = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите столбец таблицы:");

int col = Convert.ToInt32(Console.ReadLine());

if(row <= number1 && col <= number2)
{
   Console.WriteLine(matrix[row,col]);
}
else 
{
   Console.WriteLine("Нет такого элемента в таблице!");
}


// решил бы и 52 задачу, но банально времени не хватило.


