namespace PoplarTree;
public class Program
{
    static void Main(string[] args)
    {
        var root = new TreeNode<char>(null, 'D');
        root.AddChild('B');
        root.AddChild('F');

        // 0 is B
        root.children[0].AddChild('A');
        root.children[0].AddChild('C');

        // 1 is F
        root.children[1].AddChild('E');
        root.children[1].AddChild('G');


        Console.WriteLine("In Order: ");
        TreeNode<char>.TraverseInOrder(root);

        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("Pre Order: ");
        TreeNode<char>.TraversePreOrder(root);

        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("Post Order: ");
        TreeNode<char>.TraversePostOrder(root);


        Thread.Sleep(4000);
    }
}


public class TreeNode<T>
{
    T data;
    public List<TreeNode<T>> children;
    TreeNode<T> parentNode;


    public TreeNode(TreeNode<T> parent, T data)
    {
        this.data = data;

        this.parentNode = parent;

        children = new List<TreeNode<T>>();
    }


    public void AddChild(T data)
    {
        var child = new TreeNode<T>(this, data);

        // this -
            // This! object = a pointer

        children.Add(child);
    }


    // Copy
    public static void TraverseInOrder(TreeNode<T> root)
    {
        // Guard Clause
        if (root == null) return;

        // Left
        for (int i = 0; i < root.children.Count / 2; i++)
        {
            TraverseInOrder(root.children[i]);
        }

        // Self
        Console.WriteLine(root.data);

        // Right
        for (int i = (root.children.Count / 2); i < root.children.Count; i++)
        {
            TraverseInOrder(root.children[i]);
        }
    }



    public static void TraversePreOrder(TreeNode<T> root)
    {
        // Guard Clause
        if (root == null) return;

        // Self
        Console.WriteLine(root.data);

        // Left
        for (int i = 0; i < root.children.Count / 2; i++)
        {
            TraverseInOrder(root.children[i]);
        }

        // Right
        for (int i = (root.children.Count / 2); i < root.children.Count; i++)
        {
            TraverseInOrder(root.children[i]);
        }
    }


    // Delete
    public static void TraversePostOrder(TreeNode<T> root)
    {
        // Guard Clause
        if (root == null) return;

        // Left
        for (int i = 0; i < root.children.Count / 2; i++)
        {
            TraverseInOrder(root.children[i]);
        }

        // Right
        for (int i = (root.children.Count / 2); i < root.children.Count; i++)
        {
            TraverseInOrder(root.children[i]);
        }

        // Self
        Console.WriteLine(root.data);

    }
}

