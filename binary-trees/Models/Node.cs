namespace BinaryTrees.Models;

public class Node
{
    public Node()
    {
        Random random = new();
        Data = random.Next(101);
    }
    
    public object? Data { get; set; }
    public Node? Right { get; set; }
    public Node? Left { get; set; }
}