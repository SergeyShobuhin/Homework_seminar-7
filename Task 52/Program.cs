// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


// Функция определения массива
int [,]  GetArrayRandom(int line, int column)
    {
        int[,] array = new int [line,column];
        var random = new Random();

        for (int i = 0; i < line; i++)
            {
                 for (int j = 0; j < column; j++)
                 {
                    array[i,j] = random.Next(0, 10);
                    Console.Write(array[i,j]  + "   ");
                 }
                 Console.WriteLine();
            }
            
        return array;
    }

// Функция вычисления среднее арифметического по столбцам
void GetArithmeticArrayСolumn(int [,] array)
{
    double sum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = 0;
            for (int i = 0; i < array.GetLength(0); i++)
                {
                    sum = sum + array[i, j];  
                }
            sum = sum / array.GetLength(0);
            Console.Write($" [{Math.Round((sum), 2)}] ");
        }
}

//Задаём массив
Console.Write("Введите размер массива N: ");
int line = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите размер массива M: ");
int column = Convert.ToInt32(Console.ReadLine());

//Вызов функций
var array = GetArrayRandom(line, column);
Console.Write("Cреднее арифметическое столбцам:");
GetArithmeticArrayСolumn(array);

