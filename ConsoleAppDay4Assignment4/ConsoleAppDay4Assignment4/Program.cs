using System;

class Program
{
    static void Main()
    {
        // Create an array of integers with a minimum size of 5
        int arraySize = 5;
        int[] randomArray = new int[arraySize];

        // Populate the array with random integer values
        Random random = new Random();
        for (int i = 0; i < arraySize; i++)
        {
            randomArray[i] = random.Next(1, 101); // Generating random integers between 1 and 100
        }

        // Calculate the sum and average of the elements in the array
        int arraySum = 0;
        foreach (int num in randomArray)
        {
            arraySum += num;
        }
        double arrayAverage = (double)arraySum / arraySize;

        // Display the results
        Console.WriteLine("Array: [" + string.Join(", ", randomArray) + "]");
        Console.WriteLine("Sum: " + arraySum);
        Console.WriteLine("Average: " + arrayAverage);
    }
}
