//Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
/*int[,] Create2dArray(int rows, int columns, int min, int max)
{
    int[,] newArray = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            newArray[i, j] = new Random().Next(min, max + 1);
        }
    }
    return newArray;
}

void ShowArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] Sort(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int count = 0; count < array.GetLength(1); count++)
            for (int j = 0; j < array.GetLength(1) - 1; j++)
                if (array[i, j] < array[i, j + 1])
                {
                    int temp = array[i, j + 1];
                    array[i, j + 1] = array[i, j];
                    array[i, j] = temp;
                }
    return array;
}

Console.Write("Input numbers of rows: ");
int user_rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input numbers of columns: ");
int user_columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Input numbers of min: ");
int user_min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input numbers of max: ");
int user_max = Convert.ToInt32(Console.ReadLine());
int[,] newArray = Create2dArray(user_rows, user_columns, user_min, user_max);
ShowArray(newArray);
int[,] newArray2 = Sort(newArray);
ShowArray(newArray2);
*/

//Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
/*int[,] Create2dArray(int rows, int columns, int min, int max)
{
    int[,] newArray = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            newArray[i, j] = new Random().Next(min, max + 1);
        }
    }
    return newArray;
}

void ShowArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

double[] Sum(int[,] array)
{
    double[] Summa = new double[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        double sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        Summa[i] = sum;
    }
    return Summa;
}

void Smallest(double[] array)
{
    double A = 100;
    int B = 0;
    for (int i = 0; i < array.Length; i++)
    if(array[i]< A)
    {
    A = array[i];
    B = i+1;
    }
    Console.WriteLine($"Row number {B} ");
}

void Show1Array(double[] array)
{
    for (int i = 0; i < array.Length; i++)
            Console.Write(array[i] + " ");   
}

Console.Write("Input numbers of rows: ");
int user_rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input numbers of columns: ");
int user_columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Input numbers of min: ");
int user_min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input numbers of max: ");
int user_max = Convert.ToInt32(Console.ReadLine());
int[,] newArray = Create2dArray(user_rows, user_columns, user_min, user_max);
ShowArray(newArray);
double[] newArray1 = Sum(newArray);
Console.WriteLine("Sum of elements");
Show1Array(newArray1);
Console.WriteLine();
Smallest(newArray1);
*/


//Напишите программу, которая заполнит спирально массив 4 на 4.
/*int[,] Spiral()
{
int[,] spiral = new int[4,4];
int num = 1;
int iMin = 0;
int jMin = 0;
int iMax = 4;
int jMax = 4;
while(iMin< iMax && jMin < jMax)
{
    int i = iMin;
    int j = jMin;
    for(j = jMin;j < jMax;j++)
    {
        spiral[i,j] = num;
        num++;
    }
    j = jMax - 1;
    for(i = iMin+1;i < iMax;i++)
    {
        spiral[i,j] = num;
        num++;
    }
    i  = iMax-1;
    for(j = jMax-2;j >= jMin;j--)
    {
        spiral[i,j] = num;
        num++;
    }
    j = jMin;
    for(i = iMax-2;i > iMin;i--)
    {
        spiral[i,j] = num;
        num++;
    }
    iMin++;
    jMin++;
    iMax--;
    jMax--;
}
return spiral;
}

void ShowArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] result = Spiral();
ShowArray(result);
*/