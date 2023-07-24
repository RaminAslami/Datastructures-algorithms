namespace AlgorithmsDatastructures.BinarySearch;

public static class BinarySearchClass
{

    public static int BinarySearching(int[] arr, int value)
    {

       int startPostion = 0;
       int endPostion = arr.Length -1;

        while (startPostion <= endPostion)
        {
            int middleIndex = (startPostion + endPostion) / 2;

            if (arr[middleIndex] == value)
            {
                return middleIndex;
            }
            else if (arr[middleIndex] < value)
            {
                startPostion = startPostion + value;
            }

            else
            {
                endPostion = endPostion - value;
            }
            
        }

        return -1;

    }
    
}