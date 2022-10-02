// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] NumberGeneration(int size)
{
    Random random = new Random();
    int[] dataArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        dataArray[i] = random.Next(100, 1000);
    }
    return dataArray;
}

void PrintResult(int[] data)
{
    string result = String.Join(", ", data);
    Console.WriteLine($"[{result}]");
}



int CounterEvenNumber(int[] array)
{
    int counter = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            counter = counter + 1;
        }

    }
    return counter;
}


void LaunchFunction()
{
    Console.Clear();
    Console.Write("Введите количество элементов в массиве: ");
    int lenght = int.Parse(Console.ReadLine()!);
    int[] generationResultArray = NumberGeneration(lenght);
    PrintResult(generationResultArray);
    int resultCounter = CounterEvenNumber(generationResultArray);
    Console.WriteLine($"Количество четных чисел: {resultCounter}");

}

LaunchFunction();