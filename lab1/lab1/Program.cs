using System;

public class HW1
{
    public static long QueueTime(int[] customers, int n)
    {
        long[] time = new long[n];

        for (int i = 0; i < customers.Length; i++)
        {
            long min_time = time[0];
            int min_index = 0;

            for (int j = 1; j < n; j++)
            {
                if (time[j] < min_time)
                {
                    min_time = time[j];
                    min_index = j;
                }
            }

            time[min_index] = time[min_index] + customers[i];
        }

        long max_time = time[0];

        for (int i = 0; i < n; i++)
        {
            if (time[i] > max_time)
            {
                max_time = time[i];
            }
        }

        return max_time;
    }
}

class Program
{
    public static void Main(string[] args)
    {
        int n = 1;
        int[] customers = {5, 3, 4};

        Console.WriteLine(HW1.QueueTime(customers, n));
    }
}