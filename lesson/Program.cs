Console.Clear();

/* int[] array = FillArray(5, 1, 10);
Console.WriteLine("[" + String.Join(",", array) + "]");
int[] FillArray(int size, int min, int max) 
{
    int[] filledArray = new int[size];

    for (int i = 0; i < filledArray.Length; i++)
    {
        filledArray[i] = new Random().Next(min, max + 1);
    }
    return filledArray;
}
 */

/* int[] array = FillArray(5, 1, 10);

Console.WriteLine("Входной массив:" + "[ " + String.Join(",", array) + " ]");

Console.WriteLine("Перевёрнутый массив: " + "[ " + String.Join(",", ReverseArray(array)) + " ]");

int[] FillArray(int size, int min, int max)
{
    int[] filledArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        filledArray[i] = new Random().Next(min, max + 1);
    }
    return filledArray;
}

int[] ReverseArray(int[] inputArray)
{
    int[] reverseArray = new int[inputArray.Length];

    for (int i = 0; i < inputArray.Length; i++)
    {
        reverseArray[i] = inputArray[inputArray.Length - 1 - i];
    }
    return reverseArray;
} */


/* Console.Write($"введите первое число:");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write($"введите второе число:");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write($"введите третье число:");
int num3 = Convert.ToInt32(Console.ReadLine());
if (num1 < (num2 + num3) && num2 < (num1 + num3) && num3 < (num2 + num1))
    Console.WriteLine($"Такой треугольник возможен");
else Console.WriteLine($"Такой треугольник НЕ возможен"); */

/* Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования. */


/* int[] array = FillArray(10, 1, 10);

Console.WriteLine("Входной массив:" + "[ " + String.Join(",", array) + " ]");

Console.WriteLine("Копия массив: " + " [ " + String.Join(",", RevArray(array)) + " ]");

int[] FillArray(int size, int min, int max)
{
    int[] filledArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        filledArray[i] = new Random().Next(min, max + 1);
    }
    return filledArray;
}

int[] RevArray(int[] inputArray)
{
    int[] revArray = new int[inputArray.Length];

    for (int i = 0; i < inputArray.Length; i++)
    {
        revArray[i] = inputArray[i];
    }
    return revArray;
} */


/* Console.Clear();
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());

Console.WriteLine($"В двоичной системе: {ConvertTo2(num)}");

string ConvertTo2(int num_local)
{
    string s = "";
    while (num_local > 0)
    {
        s = ((num_local % 2 == 0) ? "0" : "1") + s;
        num_local /= 2;
    }
    if (s == "") s = "0";
    return s;
} */


/* Console.WriteLine();
Console.Write("Введите число: ");
int num2 = int.Parse(Console.ReadLine());

int[] array = new int[num2];
array[0] = 0;
array[1] = 1;

for (int i = 2; i < num2; i++)
{
    array[i] = array[i-1] + array[i-2];
}

Console.WriteLine("Фибоначи: " + String.Join(", ", array)); */


/* Console.Clear();
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());

Console.WriteLine($"В двоичной системе: {ConvertTo2(num)}");

string ConvertTo2(int num_local)
{
    string s = "";
    while (num_local > 0)
    {
        s = ((num_local % 2 == 0) ? "0" : "1") + s;
        num_local /= 2;
    }
    if (s == "") s = "0";
    return s;
} */


