class Program
{
    static void Main(string[] args)
    {
        SparseLinkedMatrix sparse = new() { nodes = new Node[5] };
        sparse.Create(0, [0, 0, 0, 0, 8, 0]);
        sparse.Create(1, [0, 0, 0, 7, 0, 0]);
        sparse.Create(2, [0, 0, 0, 0, 9, 0]);
        sparse.Create(3, [0, 0, 0, 0, 0, 3]);
        sparse.Create(4, [6, 0, 0, 4, 0, 0]);


        sparse.Display();
    }
}