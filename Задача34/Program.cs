// Задача 34: Задайте массив заполненный случайными 
// положительными трёхзначными числами. Напишите 
// программу, которая покажет количество 
// чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

Console.Write("Задайте количество элементов массива: ");
int number = Convert.ToInt32(Console.ReadLine());
int[] arrayRandomX = new int[number];

void newArray(int number)
{
    for (int i = 0; i < number; i++)
    {
        arrayRandomX[i] = new Random().Next(99,999);
        Console.Write(arrayRandomX[i] + " ");
    }
}

int sumOfEvenNumbers(int[] arrayRandomX)
{
    int sumOfEvenNumbers = 0;
    for (int i = 0; i < arrayRandomX.Length; i++)
    {
        if (arrayRandomX[i] % 2 == 0)
        sumOfEvenNumbers = sumOfEvenNumbers + 1;
    }
    return sumOfEvenNumbers;
}

newArray(number);
Console.Write($"\n Количество чётных чисел в массиве: {sumOfEvenNumbers(arrayRandomX)}");

