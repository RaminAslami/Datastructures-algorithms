namespace AlgorithmsDatastructures.Queue;

public class Queue
{
    public int MaxSize { get; set; } //sets number of elements
    public int[] QueueArray; //Actual array we will store elements in
    public int Front { get; set; } //index to keep track of front
    public int Rear { get; set; } //index to keep track of adds
    public int NItems { get; set; } //this will keep track of length´

    public Queue(int size)
    {
        MaxSize = size;
        QueueArray = new int[MaxSize];
        Front = 0;
        Rear = -1;
    }
    public void Enqueue(int item)
    {
        //increment the pointer or the line
        Rear++;
        //insert the new item to new increment
        QueueArray[Rear] = item;
        //increment;
        NItems++;
    }
    public int Dequeue()
    {
        int temp = QueueArray[Front];
        Front++;

        if (Front == MaxSize)
        {
            Front = 0;
        }

        NItems--;

        return temp;
    }

    public int Peek()
    {
        return QueueArray[Front];
    }
}