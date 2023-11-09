using System;

class Program
{
    static void Main()
    {
        // Using for loop to display the first 10 natural numbers
        Console.WriteLine("First 10 natural numbers:");
        for (int i = 1; i <= 10; i++)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();

        // Using while loop to print the first 10 even natural numbers
        Console.WriteLine("First 10 even natural numbers:");
        int evenCount = 1;
        int evenNumber = 2;
        while (evenCount <= 10)
        {
            Console.Write(evenNumber + " ");
            evenNumber += 2;
            evenCount++;
        }
        Console.WriteLine();

        // Using do-while loop to print the first 10 odd natural numbers
        Console.WriteLine("First 10 odd natural numbers:");
        int oddCount = 1;
        int oddNumber = 1;
        do
        {
            Console.Write(oddNumber + " ");
            oddNumber += 2;
            oddCount++;
        } while (oddCount <= 10);
        Console.WriteLine();
    }
}

