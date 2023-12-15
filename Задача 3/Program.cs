using System;

class Program
{
    static void PrintArrayReverse(int[] arr, int index)
    {
        if (index >= 0)
        {
            Console.WriteLine(arr[index]);
            PrintArrayReverse(arr, index - 1);
        }
    }

    static void Main()
    {
        int[] myArray = { 1, 2, 5, 10, 34 };

        Console.WriteLine("Элементы массива, начиная с конца:");
        PrintArrayReverse(myArray, myArray.Length - 1);
    }
}
