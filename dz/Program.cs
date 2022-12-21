public static class Lesson457
{
    static void Main()
    {

     //Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает 
    //значение этого элемента или же указание, что такого элемента нет.

    int colums = ReadInt("Укажите индекс столбца: ");
    int rows = ReadInt("Укажите индекс строки: ");

    int[,] numbers = new int[6, 8];
    FillArray2D(numbers);
    PrintArray2D(numbers);

    if (rows < numbers.GetLength(0) && colums < numbers.GetLength(1)) 
    {
        Console.WriteLine(numbers[rows, colums]);
    }
    
    else Console.WriteLine($"{rows}{colums} -> числа в массиве нет");

    // Функция ввода массива

    int ReadInt(string message)
    {
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
    }

    // Функция заполнения массива рандомными числами 

    void FillArray2D(int[,] array)
    {
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 100);
        }
    }
}

    //  Функция вывода массива в терминал

    void PrintArray2D(int[,] array)
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


}
    }
