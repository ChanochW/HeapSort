namespace HeapSort;

public class Program {
    public static void Main() {
        Console.WriteLine("Array:");
        var arrayHeapSort = new ArrayHeapSort<int>();
        
        int[] array = { 12, 11, 13, 5, 6, 7 };
        Console.WriteLine("Original array:");
        PrintArray(array);
        
        arrayHeapSort.Sort(array);
        
        Console.WriteLine("Sorted array:");
        PrintArray(array);
        
        //---------------------------------------------
        Console.WriteLine("Recursion:");
        var recursiveHeapSort = new RecursiveHeapSort<int>();
        
        int[] arr = { 12, 11, 13, 5, 6, 7 };
        Console.WriteLine("Original array:");
        PrintArray(arr);

        recursiveHeapSort.Sort(arr);

        Console.WriteLine("Sorted array:");
        PrintArray(arr);
    }
    
    private static void PrintArray(int[] arr) {
        int n = arr.Length;
        for (int i = 0; i < n; ++i) {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
    }
}