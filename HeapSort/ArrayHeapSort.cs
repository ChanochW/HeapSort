namespace HeapSort; 

public class ArrayHeapSort<T> where T : IComparable<T> {
    public void Sort(T[] arr) {
        for (var c = arr.Length - 1; c >= 0; c--) {
            Heapify(arr, c);
            (arr[c], arr[0]) = (arr[0], arr[c]);
        }
    }

    private void Heapify(T[] arr, int index) {
        if (index % 2 == 1) {
            if (arr[(index - 1) / 2].CompareTo(arr[index]) < 0) {
                (arr[index], arr[(index - 1) / 2]) = (arr[(index - 1) / 2], arr[index]);
                index--;
            }
        }
        
        for (var c = index; c > 0; c -= 2) {
            if (arr[(c - 1) / 2].CompareTo(arr[c]) < 0) {
                (arr[c], arr[(c - 1) / 2]) = (arr[(c - 1) / 2], arr[c]);
            }
            if (arr[(c - 1) / 2].CompareTo(arr[c - 1]) < 0) {
                (arr[c - 1], arr[(c - 1) / 2]) = (arr[(c - 1) / 2], arr[c - 1]);
            }
        }
    }
}
