// Задача 36: Задайте одномерный массив, заполненный случайными 
// числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Write("Задайте количество элементов массива: ");
int number = Convert.ToInt32(Console.ReadLine());
int[] arrayRandomX = new int[number];

void newArray(int number)
{
    for (int i = 0; i < number; i++)
    {
        arrayRandomX[i] = new Random().Next(1, 999);
        Console.Write(arrayRandomX[i] + " ");
    }
}

int sumOfOddNumbers(int[] arrayRandomX)
{
    int sumOfOddNumbers = 0;
    for (int i = 0; i < arrayRandomX.Length; i++)
    {
        if (arrayRandomX[i] % 2 != 0)
        
        sumOfOddNumbers = sumOfOddNumbers + arrayRandomX[i];
    }
    return sumOfOddNumbers;
}


newArray(number);
Console.Write($"\n Сумма нечётных чисел в массиве: {sumOfOddNumbers(arrayRandomX)}");


