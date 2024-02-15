class SparseLinkedMatrix
{
    public Node? First;
    public required Node[]? nodes;
    private int CountCol { get; set; }
    public SparseLinkedMatrix() { First = null; }

    public void Create(int lines, int[] cols)
    {
        Node node = nodes[lines] = new() { val = cols[0], next = null }, last;
        last = node;
        CountCol = cols.Length;
        node = node.next;
        for (int j = 1; j < cols.Length - 1; j++)
        {
            if (node != null) node = node.next;
            node = new()
            {
                val = cols[j],
                next = null
            };
            last.next = node;
            last = node;
        }
    }
    public void Display()
    {
        Node node;
        for (int i = 0; i < nodes.Length; i++)
        {
            node = nodes[i];
            while (node != null)
            {
                System.Console.Write(node.val + " ");

                node = node.next;
            }
            System.Console.WriteLine();
        }
    }
}