using System;

namespace BubbleSort
{
    class Sorting
    {
        static void Main(string[] args)
        {
            int[] mixdata = { 56, 23, 2, 86, 102, 45 };
            int temp;

            for (int j = 0; j < mixdata.Length - 1; j++)
            {
                for (int i = 0; i < mixdata.Length - 1; i++)
                {
                    if (mixdata[i] > mixdata[i + 1])
                    {
                        temp = mixdata[i + 1];
                        mixdata[i + 1] = mixdata[i];
                        mixdata[i] = temp;
                    }
                }
            }

            Console.WriteLine("Bubble sort data:");
            foreach (int p in mixdata)
                Console.Write(p + " ");
            Console.Read();
        }
    }
}