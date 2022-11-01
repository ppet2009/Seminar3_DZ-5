/*
Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2

*/
/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] myArray = new int[size];
    for(int i = 0; i < size; i++)
    {
        myArray[i] = new Random().Next(minValue, maxValue + 1);
    }                                                                                                               
    return myArray;
}
void ShowArray(int[] array)
{
    Console.WriteLine("Получившийся массив -> ");
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}
int ElementsCount(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}
Console.WriteLine("Введите размер массива ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение элемента");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение элемента");
int max = Convert.ToInt32(Console.ReadLine());
int [] myArray = CreateRandomArray(a, min, max);
ShowArray(myArray);
int result = ElementsCount(myArray);
Console.WriteLine($"В этом массиве содержится {result} четных элементов");
*/

/*Задайте одномерный массив, заполненный случайными числами.
/* Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

//[-4, -6, 89, 6] -> 0
*/
/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] myArray = new int[size];
    for(int i = 0; i < size; i++)
    {
        myArray[i] = new Random().Next(minValue, maxValue + 1);
    }                                                                                                               
    return myArray;
}
void ShowArray(int[] array)
{
    Console.WriteLine("Получившийся массив -> ");
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}
void ElementsCount(int[] array)
{
    
    int sumresult=0;
    for(int i = 0; i < array.Length; i++)
    {
        if(i % 2 != 0)sumresult += array[i];
    
    }
    Console.WriteLine($"сумма чисел в нечетных индексах ->{sumresult}");
}
Console.WriteLine("Введите размер массива ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение элемента");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение элемента");
int max = Convert.ToInt32(Console.ReadLine());
int [] myArray = CreateRandomArray(a, min, max);
ShowArray(myArray);
ElementsCount(myArray);
*/

/*Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76

*/

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] myArray = new int[size];
    for(int i = 0; i < size; i++)
    {
        myArray[i] = new Random().Next(minValue, maxValue + 1);
    }                                                                                                               
    return myArray;
}
void ShowArray(int[] array)
{
    Console.WriteLine("Получившийся массив -> ");
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}
void ElementsCount(int[] array)
{
    int ciferka = 0;
    int maxnum = 0;
    int minnum = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > maxnum)
        {
            maxnum = array[i];
            
            if(array[1] < minnum) minnum = array[i];
        }
        else minnum = array[i];

        ciferka = maxnum - minnum;

    
    }
    Console.WriteLine($"разница между максимальным и минимальным элементом -> {ciferka}");
}
Console.WriteLine("Введите размер массива ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение элемента");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение элемента");
int max = Convert.ToInt32(Console.ReadLine());
int [] myArray = CreateRandomArray(a, min, max);
ShowArray(myArray);
ElementsCount(myArray);
