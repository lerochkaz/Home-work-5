// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


int[] NumberGeneration(int size)
{
    Random random = new Random();
    int[] dataArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        dataArray[i] = random.Next(1, 100);
    }
    return dataArray;
}

void PrintResult(int[] data)
{
    string result = String.Join(", ", data);
    Console.WriteLine($"[{result}]");
}


int CalculateResult(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        sum = sum + array[i];
    }

    return sum;

}


void LaunchFunction()
{
    Console.Clear();
    Console.Write("Введите количество элементов в массиве: ");
    int lenght = int.Parse(Console.ReadLine()!);
    int[] generationResultArray = NumberGeneration(lenght);
    PrintResult(generationResultArray);
    int result = CalculateResult(generationResultArray);
    Console.WriteLine($"Сумма элементов, которые находятся на нечетных позициях в массиве = {result}");
}

LaunchFunction();