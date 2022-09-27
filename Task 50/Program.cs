// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, 
// что такого элемента нет. Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


// Функция определения массива
double [,]  GetArrayRandom(int n, int m, int minValue, int maxValue)
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
        return array;
    }

//Задаём массив
Console.Write("Введите размер массива N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите размер массива M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите начальное значение интервала ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите конечное значение интервала: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

//Вызов функций
var array = GetArrayRandom(n, m, minValue, maxValue);


/* блок определения нахождения элемента массива */

// задаём строку и столбец
Console.WriteLine("введите номер строки");
int numberLine = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите номер столбца");
int numberСolumn = Convert.ToInt32(Console.ReadLine());

//Вызов функций
CheckInArrayAdressNumber(array);

//определяем соответствие нахождения элемента в массиве
void CheckInArrayAdressNumber(double[,] array)
{
    if (numberLine > array.GetLength(0) || numberСolumn > array.GetLength(1))
        {
            Console.WriteLine("Элемент с таким адресом отсутствует");
        }
    else
        {
            Console.WriteLine($"Адрес массива [{numberLine} , {numberСolumn}] равно {array[numberLine-1,numberСolumn-1]}");
        }
}