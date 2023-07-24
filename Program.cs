// See https://aka.ms/new-console-template for more information


using System.Collections;
using System.Collections.Concurrent;
using System.Threading.Channels;
using System.Xml;
using AlgorithmsDatastructures.BinarySearch;
using AlgorithmsDatastructures.BinarySearchTree;
using AlgorithmsDatastructures.HashTable;
using AlgorithmsDatastructures.LinkedList;
using Stack = AlgorithmsDatastructures.Stack.Stack;


public class Program
{
    public static void Main(string[] args)
    {
         int[] primes = new[]
             { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97 };

        // Console.WriteLine(BinarySearchClass.BinarySearching(primes, 100));

         

        // SortingAlgorithmBasedOnStart(items, 0);

        //SortingAlgorithm(items);

        int[] arr1 = new[] { 1, 3, 2 };
        
        //InsertValueBeforeIndex(arr1, 1, 2);

        //teddy smith

        int[] intArr = new int[10];

        int length = 0;

        for (int i = 0; i < 6; i++)
        {
            intArr[length] = i;
            length++;
        }

        //insertion at the end of array
        // intArr[length] = 8;
        // length++;


        //inserting at the start of an array

        // for (int i = 3; i >= 0; i--)
        // {
        //     //we add every single item infront of the previous item
        //     //this leaves the first index empty
        //     intArr[i + 1] = intArr[i];
        // }

        // intArr[0] = 20;

        //insert anywhere in the array
        //the thing that determines the insertion is the condition index
        //because this spot will be empty in the array

        // for (int i = intArr.Length - 2; i >= 2; i--)
        // {
        //     //shift each elemnt one postion to the right
        //     intArr[i + 1] = intArr[i];
        // }

        // intArr[2] = 8;

        // for (int i = 1; i < length; i++)
        // {
        //    
        //     //move to the left
        //     intArr[i - 1] = intArr[i];
        //
        // }

        for (int i = 1; i < arr1.Length; i++)
        {
            intArr[i - 1] = intArr[i];
        }

        intArr[length] = 0;
        length--;

        foreach (var VARIABLE in intArr)
        {
            Console.WriteLine(VARIABLE);
        }

        //Linear search Array

        int[] arrayLinear = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        bool LinearSearch(int[] array, int key)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == key)
                {
                    return true;
                }
            }

            return false;
        }

        //Linked List

        //Creating the links!
        Node nodeA = new Node();
        nodeA.Data = 123;

        Node nodeB = new Node();
        nodeB.Data = 534;

        Node nodeC = new Node();
        nodeC.Data = 493;

        Node nodeD = new Node();
        nodeD.Data = 929;

        nodeA.Next = nodeB;
        nodeB.Next = nodeC;
        nodeC.Next = nodeD;
        
        //usage of defined methods

        LinkedList linkedList = new LinkedList();
        
        // linkedList.InsertFirst(1);
        // linkedList.InsertFirst(2);
        // linkedList.InsertFirst(3);
        // linkedList.InsertFirst(4);
        //
        // linkedList.DeleteFirst();
        // linkedList.DeleteFirst();
        //
        // linkedList.InsertLast(188);


        Stack stack = new Stack(10);

        for (int i = 0; i < 3; i++)
        {
            stack.Push("Squirtle");
            stack.Push("Pickachu");
            stack.Push("Charmander");
        }

        stack.Pop();
        stack.Peek();

        while (!stack.isEmpty())
        {
            var var = stack.Pop();
            //Console.WriteLine(var);
        }


        //for arrays the insertions are o(n) because you often
        //use shifting

        //for linkedlist insertions are o(1)

        //Queue First in First Out

        Queue queue = new Queue(10);
        
        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(3);
        queue.Enqueue(4);

        queue.Dequeue();
        queue.Dequeue();

        queue.Peek();

        
        //Binary search tree

        BinarySearchTree bst = new BinarySearchTree();
        bst.Insert(7, "Squirtle");
        bst.Insert(23, "Ekans");
        bst.Insert(15, "Mew");
        bst.Insert(4, "Charmander");
        bst.Insert(4, "Bulbasaur");

        Console.WriteLine(bst.Find(15));
        
        //Bubble sort
       
        /* traverse from left and compare adjacent elements and the higher one is placed at right side.
            In this way, 
        the largest element is moved to the rightmost end at first.
            This process is then continued to find the second largest and place it and 
            so on until the data is sorted.
        
        */
        
        int[] items = new[] { 6, 5, 1, 7, 2, 4};

        items.Aggregate((result, items) => result * items);

        var bubble = BubbleSort(items);

        // foreach (var VARIABLE in bubble)
        // {
        //     Console.WriteLine(VARIABLE);
        // }
        //
        
        SayHello(3);

        HashTable hashtable = new HashTable();
        hashtable.Set("Teddy", "656-234-2341");
        hashtable.Set("Smith", "656-979-2334");
        hashtable.Set("Jessica", "878-191-2919");
        hashtable.Set("Sarah", "192-019-1239");
        hashtable.Set("Eric", "291-294-1393");

        Console.WriteLine(hashtable.Get("Teddy"));
        Console.WriteLine(hashtable.Get("Smith"));
        Console.WriteLine(hashtable.Get("Jessica"));
        Console.WriteLine(hashtable.Get("Sarah"));
        Console.WriteLine(hashtable.Get("Eric"));

    }

    //Recursion
    public static int RecursiveFactorial(int num)
    {
        if (num == 0)
        {
            return 1;
        }

        return num * RecursiveFactorial(num - 1);

    }
    public static int IterativeFactorial(int num)
    {
        if (num == 0)
        {
            return 1;
        }
        
        int factorial = 1;

        for (int i = 1; i <= num; i++)
        {
            factorial = factorial * i;
        }

        return factorial;
    }


    public static void SayHello(int amount)
    {
        if (amount > 1)
        {
            SayHello(amount -1);

        }
        Console.WriteLine("hello world");

    }

    public static int[] BubbleSort(int[] array)
    {
        int temp = 0;

        for (int pointer = 0; pointer< array.Length; pointer++)
        {
            for (int sort = 0; sort < array.Length -1; sort++)
            {
                if (array[sort] > array[sort +1])
                {
                    temp = array[sort + 1];
                    array[sort + 1] = array[sort];
                    array[sort] = temp;
                }
            }
        }

        return array;


    }
    
    


    public static void ImplementTationInsertSort(int[] arr, int rightIndex, int value)
    {
        int insertion = rightIndex + 1;

        while (value < arr[rightIndex - 1])
        {
            Console.WriteLine("hellooooo");
            insertion--;
        }

        Console.WriteLine(insertion + "testing!");

        arr[insertion] = value;

        foreach (var VARIABLE in arr)
        {
            Console.WriteLine(VARIABLE);
        }
    }


    public static void InsertValueBeforeIndex(int[] array, int rightIndex, int value)
    {
        int insertIndex = rightIndex + 1;

//        Console.WriteLine(array[insertIndex - 1]);

        while (insertIndex > 0 && value < array[insertIndex - 1])
        {
            array[insertIndex] = array[insertIndex - 1];
            insertIndex--;
        }

        array[insertIndex] = value;

        foreach (var VARIABLE in array)
        {
            Console.WriteLine(VARIABLE);
        }
    }

    public static void InsertionSort(int[] array, int rightIndex, int value)
    {
        var newArr = new int[array.Length + 1];

        for (int i = 0; i < array.Length; i++)
        {
            var minIndex = i;


            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[j] < array[minIndex])
                {
                    minIndex = j;
                }
            }

            var temp = array[i];

            array[i] = array[minIndex];

            array[minIndex] = temp;

            newArr[i] = array[i];
        }

        foreach (var VARIABLE in newArr)
        {
            Console.WriteLine("test " + VARIABLE);
        }
    }


    public static void Swap(int[] arr, int firstIndex, int lastIndex)
    {
        var temporayHolder = arr[firstIndex];

        arr[firstIndex] = arr[lastIndex];
        arr[lastIndex] = temporayHolder;

        foreach (var VARIABLE in arr)
        {
            Console.WriteLine(VARIABLE);
        }
    }


    public static void SortingAlgorithm(int[] arr)
    {
        var tempArr = new int[arr.Length];

        for (int i = 0; i < arr.Length; i++)
        {
            var minIndex = i;

            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[j] < arr[minIndex])
                {
                    minIndex = j;
                }
            }

            //själva algoritmen sker här
            int temp = arr[i];
            arr[i] = arr[minIndex];
            arr[minIndex] = temp;

            tempArr[i] = arr[i];
        }

        foreach (var VARIABLE in tempArr)
        {
            Console.WriteLine($"Iterera nya arrayen:  {VARIABLE}");
        }
    }


    public static void SortingAlgorithmBasedOnStart(int[] arr, int startIndex)
    {
        var minIndex = startIndex;

        for (int i = minIndex; i < arr.Length; i++)
        {
            Console.WriteLine(arr[i]);
            Console.WriteLine(arr[minIndex]);

            if (arr[i] < arr[minIndex])
            {
                minIndex = i;
                Console.WriteLine($"Hello {arr[i]}");
            }
        }

        Console.WriteLine("The least value is at index: " + minIndex + " with the value: " + arr[minIndex]);
    }


    private static int GuessPrime(int[] arr, int target)
    {
        var min = 0;
        var max = arr.Length - 1;
        var iterations = 1;

        while (min <= max)
        {
            var guess = (max + min) / 2;

            if (arr[guess] == target)
            {
                Console.WriteLine($"You found it! Total iterations  {iterations}");
                return guess;
            }
            else if (arr[guess] > target)
            {
                max = guess - 1;
            }
            else
            {
                min = guess + 1;
            }

            iterations++;
        }

        return -1;
    }


    public static void GuessingGame(int maxInput)
    {
        //binary search

        var min = 1;
        var randomNum = new Random().Next(min, maxInput + 1);


        while (true)
        {
            Console.WriteLine($"Guess a number between {min} and {maxInput}");
            var guess = Int32.Parse(Console.ReadLine());

            if (guess == randomNum)
            {
                Console.WriteLine($"You have guessed the number {randomNum} correct!");
                return;
            }
            else if (guess < randomNum)
            {
                Console.WriteLine("Your guess was too low!");
                min = guess + 1;
            }
            else if (guess > randomNum)
            {
                Console.WriteLine("Your guess was too high!");
                maxInput = guess - 1;
            }
            else
            {
                Console.WriteLine($"You lost since {randomNum} is the only remaining!");
            }
        }
    }

    public static void BinaryGame()
    {
        Console.WriteLine("Welcome to the random binary game guesser! Guess between 1-10");

        var random = new Random();
        int[] sequence = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        var randomNum = random.Next(sequence.First(), sequence.Last() + 1);

        var lastNum = sequence.Length - 1;
        var firstNum = 0;

        while (firstNum <= lastNum)
        {
            var input = Int32.Parse(Console.ReadLine());

            int middleIndex = (firstNum + lastNum) / 2;
            var guess = sequence[middleIndex];

            if (input < 1 || input > 10)
            {
                Console.WriteLine("Out of range you lost!");
                return;
            }

            if (input == randomNum)
            {
                Console.WriteLine("You guessed the correct number!");
                return;
            }

            if (input > randomNum)
            {
                Console.WriteLine("You guessed too high!");
                lastNum = middleIndex - 1;
                Console.WriteLine($"Guess between {sequence[firstNum]} and {sequence[lastNum]}");
            }
            else
            {
                Console.WriteLine("Too low guess!");
                firstNum = middleIndex + 1;
                Console.WriteLine($"Guess between {sequence[firstNum]} and {sequence[lastNum]}");
            }
        }

        Console.WriteLine("You ran out of guesses. The correct number was: " + randomNum);
    }


    public static int BinarySearch(int[] arr, int target)
    {
        int firstIndex = 0;
        int lastIndex = arr.Length - 1;

        while (firstIndex <= lastIndex)
        {
            int middleIndex = (int)Math.Floor((firstIndex + lastIndex) / 2.0);

            if (arr[middleIndex] == target)
            {
                return middleIndex;
            }

            if (arr[middleIndex] > target)
            {
                lastIndex = middleIndex - 1;
            }
            else
            {
                firstIndex = middleIndex + 1;
            }
        }

        return -1;
    }
}


/*
 

*/