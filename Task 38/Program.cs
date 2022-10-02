// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

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
    int numberMax = array[0];
    int numberMin = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > numberMax)
        {
            numberMax = array[i];
        }
        else
        {
            if (array[i] < numberMin)
            {
                numberMin = array[i];
            }
        }

    }
    int resultNumber = numberMax - numberMin;
    return resultNumber;

}


void LaunchFunction()
{
    Console.Clear();
    Console.Write("Введите количество элементов в массиве: ");
    int lenght = int.Parse(Console.ReadLine()!);
    int[] generationResultArray = NumberGeneration(lenght);
    PrintResult(generationResultArray);
    int result = CalculateResult(generationResultArray);
    Console.WriteLine($"Разница между максимальным и минимальным числом = {result}");
}

LaunchFunction();
