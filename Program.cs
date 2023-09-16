using System;

class SortingAlgorithms
{
    static void SelectionSort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            int minIndex = i;
            for (int j = i + 1; j < n; j++)
            {
                if (arr[j] < arr[minIndex])
                {
                    minIndex = j;
                }
            }
            int temp = arr[i];
            arr[i] = arr[minIndex];
            arr[minIndex] = temp;
        }
    }
    static void BubbleSort(int[] arr)
    {
        int n = arr.Length;
        bool swapped;
        for (int i = 0; i < n - 1; i++)
        {
            swapped = false;

            for (int j = 0; j < n - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                    swapped = true;
                }
            }
            if (!swapped)
                break;
        }
    }
    static void InsertionSort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 1; i < n; i++)
        {
            int key = arr[i];
            int j = i - 1;
            while (j >= 0 && arr[j] > key)
            {
                arr[j + 1] = arr[j];
                j = j - 1;
            }
            arr[j + 1] = key;
        }
    }
    static void Main()
    {
        int[] arrSelection = { 29, 1, 44, 11, 22, 51 };
        int[] arrBubble = { 23, 8, 12, 2, 26, 3, 44 };
        int[] arrInsertion = { 111, 1, 39, 0, 22, 11 };
        Console.WriteLine("Original arrays:");
        Console.WriteLine("Selection Sort: " + string.Join(", ", arrSelection));
        Console.WriteLine("Bubble Sort: " + string.Join(", ", arrBubble));
        Console.WriteLine("Insertion Sort: " + string.Join(", ", arrInsertion));
        SelectionSort(arrSelection);
        BubbleSort(arrBubble);
        InsertionSort(arrInsertion);
        Console.WriteLine("\nSorted arrays:");
        Console.WriteLine("Selection Sort: " + string.Join(", ", arrSelection));
        Console.WriteLine("Bubble Sort: " + string.Join(", ", arrBubble));
        Console.WriteLine("Insertion Sort: " + string.Join(", ", arrInsertion));
    }
}