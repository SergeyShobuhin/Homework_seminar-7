// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


// Функция определения массива
void GetArrayRandom(int n, int m, int minValue, int maxValue)
    {
        double[,] array = new double [n,m];
        var random = new Random();

        for (int i = 0; i < n; i++)
            {
                 for (int j = 0; j < m; j++)
                 {
                    array[i,j] = Math.Round((random.Next(minValue, maxValue + 1) + random.NextDouble()),2);
                    Console.Write(array[i,j]  + "   ");
                 }
                 Console.WriteLine();
            }

    }

//Определяем массив
Console.Write("Введите размер массива N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите размер массива M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите начальное значение интервала ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите конечное значение интервала: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

//Вызов функций
GetArrayRandom(n, m, minValue, maxValue);



