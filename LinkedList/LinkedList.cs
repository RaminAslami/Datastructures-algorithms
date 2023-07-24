namespace AlgorithmsDatastructures.LinkedList;

public class LinkedList
{
    //Data Structure for LinkedList!
    public Node? Head { get; set; }

    public void InsertFirst(int data)
    {

        Node newNode = new Node();
        newNode.Data = data;
        newNode.Next = Head;
        
        //insert node to first!
        //O(1)
        Head = newNode;
    }

    public Node DeleteFirst()
    {
        //assign a temporary variable
        Node temp = Head;
        //assign the value
        Head = Head.Next;

        return temp;
    }

    public void DisplayList()
    {
        Console.WriteLine("Iterating thru list...");
        Node current = Head;

        while (current != null)
        {
            current.DisplayNode();
            current = current.Next;
        }
    }

    public void InsertLast(int data)
    {
        Node current = Head;

        while (current != null)
        {
            current = current.Next;
        }

        Node newNode = new Node();
        newNode.Data = data;
        current.Next = newNode;

    }
    
    
}