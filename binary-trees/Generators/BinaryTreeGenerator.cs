using BinaryTrees.Models;

namespace BinaryTrees.Generators;

public class BinaryTreeGenerator
{
    enum ChildPossibilities
    {
        Left = 0,
        Right = 1,
        Both = 2,
    };

    /// <summary>
    /// GenerateBinaryTree(int size)
    /// Creates a binary tree of the size given with random left/right nodes
    /// </summary>
    /// <param name="size">The minimum number of nodes to instantiate</param>
    /// <returns>The root node of the created tree</returns>
    public static Node GenerateBinaryTree(int size)
    {
        Random random = new();
        Stack<Node> stack = new();

        Node root = new()
        {
            Data = random.Next(101)
        };

        stack.Push(root);

        for(int i = 0; i < size; i++)
        {
            Node currentNode = stack.Pop();
            var values = Enum.GetValues(typeof(ChildPossibilities));
            var direction = values.GetValue(random.Next(values.Length));
            
            switch (direction)
            {
                case ChildPossibilities.Left:
                    Node childLeftNode = new();
                    currentNode.Left = childLeftNode;
                    stack.Push(childLeftNode);
                    break;
                case ChildPossibilities.Right:
                    Node childRightNode = new();
                    currentNode.Left = childRightNode;
                    stack.Push(childRightNode);
                    break;
                case ChildPossibilities.Both:
                    Node[] childNodes = [new(), new()];
                    stack.Push(childNodes[0]);
                    stack.Push(childNodes[1]);
                    currentNode.Left = childNodes[0];
                    currentNode.Right = childNodes[1];
                    break;
                default:
                    break;
            }
        }

        return root;
    }
}