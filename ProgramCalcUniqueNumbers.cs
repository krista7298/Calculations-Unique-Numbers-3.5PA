// See https://aka.ms/new-console-template for more information
/*******************************************************************
* Name: Krista Agustin
* Date: 07/05/2026
* Assignment SDC220 Week 3 PA – Calculations & Unique Numbers
*
* Main application class.
* This application stores 10 integer values in an array, stores
* unique values in a List, and calculates the count, sum, and average
* for both collections.
*/

using System.Collections.Generic;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\nKrista Agustin - Week 3 PA Calculations & Unique Numbers\n");

        int[] numbersArray = new int[10];
        List<int> uniqueNumbers = new List<int>();

        for (int i = 0; i < numbersArray.Length; i++)
        {
            Console.Write("Please enter an integer value: ");
            int value = Convert.ToInt32(Console.ReadLine());

            numbersArray[i] = value;

            if (!uniqueNumbers.Contains(value))
            {
                uniqueNumbers.Add(value);
            }
        }

        int arraySum = CalculateSum(numbersArray);
        int arrayAverage = arraySum / numbersArray.Length;

        int uniqueSum = CalculateSum(uniqueNumbers);
        int uniqueAverage = uniqueSum / uniqueNumbers.Count;

        Console.WriteLine("\nThe count of integers entered is: {0}", numbersArray.Length);
        Console.WriteLine("The sum of integers entered is: {0}", arraySum);
        Console.WriteLine("The average of integers entered is: {0}", arrayAverage);

        Console.WriteLine("\nThe count of unique integers entered is: {0}", uniqueNumbers.Count);
        Console.WriteLine("The sum of unique integers entered is: {0}", uniqueSum);
        Console.WriteLine("The average of unique integers entered is: {0}", uniqueAverage);
    }

    public static int CalculateSum(int[] values)
    {
        int total = 0;

        foreach (int value in values)
        {
            total += value;
        }

        return total;
    }

    public static int CalculateSum(List<int> values)
    {
        int total = 0;

        foreach (int value in values)
        {
            total += value;
        }

        return total;
    }
}
