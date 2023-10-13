namespace HeapSort; 

public class RecursiveHeapSort<T> where T : IComparable<T> {
    public void Sort(T[] arr) {
        //TODO null checks and stuff
        var head = Treeify(arr);
        for (var c = arr.Length; c > 0; c--) {
            Heapify(head);
            arr[c - 1] = head!.Data;
            head.Data = Removify(head);
        }
    }

    private T Removify(Node node) {
        if (node is not { Right: null }) {
            if (node.Right is { Right: null, Left: null }) {
                var data = node.Right.Data;
                node.Right = null;
                return data;
            }
            return Removify(node.Right);
        } 
        if (node is not { Left: null }) {
            if (node.Left is { Right: null, Left: null }) {
                var data = node.Left.Data;
                node.Left = null;
                return data;
            }
            return Removify(node.Left);
        }

        return node.Data;
    }

    private void Heapify(Node? node) {
        if (node is null or { Left: null, Right: null }) {
            return;
        }
        
        Heapify(node.Left);
        
        if (node.Left?.Data.CompareTo(node.Data) >= 0) {
            (node.Left.Data, node.Data) = (node.Data, node.Left.Data);
        }
        
        Heapify(node.Right);
        
        if (node.Right?.Data.CompareTo(node.Data) >= 0) {
            (node.Right.Data, node.Data) = (node.Data, node.Right.Data);
        }
    }

    private Node? Treeify(T[] arr, int i = 0) {
        return i >= arr.Length ? null : new Node {
            Data = arr[i],
            Left = Treeify(arr, 2 * i + 1),
            Right = Treeify(arr, 2 * i + 2)
        };
    }
    
    private class Node {
        public T Data { get; set; }
        public Node? Left { get; set; }
        public Node? Right { get; set; }
    }
}
