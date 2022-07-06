 //Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] fillArray (int[] arr)
    {
        int length = arr.Length;
        int index = 0;
        while (index < length)
        {
            arr[index] = new Random().Next(1, 99);
            index++;
        }
        return arr;
    }

void printArray (int[] arr1)
{
    int count = arr1.Length;
    int position = 0;
    while (position < count)
        {
            Console.Write(arr1[position] + "|");
            position++;
        }
    Console.WriteLine();
}

int[] array = new int[8];

fillArray(array);
printArray(array);