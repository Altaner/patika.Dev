using System;

class Result
{

    /*
     * Complete the 'plusMinus' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void plusMinus(List<int> arr)
    {   
        float n = 0;
        float p = 0;
        float z = 0;
        int counter = 0;
        foreach (int e in arr)
        {
            if (e < 0) n++;
            else if (e == 0) z++;
            else p++;
            counter++;
        }
        Console.WriteLine(Math.Round((p/counter), 6));
        Console.WriteLine(Math.Round((n/counter), 6));
        Console.WriteLine(Math.Round((z/counter), 6));
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.plusMinus(arr);
    }
}