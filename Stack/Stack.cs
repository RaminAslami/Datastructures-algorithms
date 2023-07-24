namespace AlgorithmsDatastructures.Stack;

public class Stack
{
    public int MaxSize { get; set; } //you need maxsize to make array
    public string[] StackArray { get; set; }
    public int Top { get; set; }

    public Stack(int size)
    {
       MaxSize = size;
       StackArray = new string[MaxSize];
       //-1 because the array is 0 index. If not it skips first elem
       Top = -1;
    }

    public void Push(string item)
    {
        Top++;
        StackArray[Top] = item;
    }

    public string Pop()
    {
        int old_top = Top;
        //decrement for new top
        Top--;

        return StackArray[old_top];
    }

    public string Peek()
    {
        return StackArray[Top];
    }

    public bool isEmpty()
    {
        return Top == 0;
    }
    
    public bool isFull()
    {
        return MaxSize -1  == Top;
    }
    
}