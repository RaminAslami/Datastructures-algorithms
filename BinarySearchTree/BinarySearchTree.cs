namespace AlgorithmsDatastructures.BinarySearchTree;

public class BinarySearchTree
{
    public TreeNode Root { get; set; } = null;

    public void Insert(int key, string value)
    {
        Root = InsertItem(Root, key, value);
    }

    public TreeNode InsertItem(TreeNode node, int key, string value)
    {
        TreeNode newNode = new TreeNode(key, value);

        //If this is the first time insert, create Root
        if (node == null)
        {
            node = newNode;
            return newNode;
        }
        //If root isn't NULL, TRAVERSE, FIND  

        if (key < node.Key)
        {
            node.LeftChild = InsertItem(node.LeftChild, key, value);
        }
        else
        {
            node.RightChild = InsertItem(node.RightChild, key, value);
        }

        return node;

    }

    public string Find(int key)
    {
        TreeNode node = Find(Root, key);

        return node == null ? null : node.Value;
    }

    private TreeNode? Find(TreeNode node, int key)
    {
        if (node == null || key == node.Key)
        {
            return node;
        }
        else if (key < node.Key)
        {
            return Find(node.LeftChild, key);
        }
        else if (key > node.Key)
        {
            return Find(node.RightChild, key);
        }
        return null;
        
    }
}