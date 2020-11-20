using System;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            var srn = new Random();
            for (int i = 0;i < array.Length;i++)
            {
                array[i] = srn.Next(0,11);
                Console.Write(array[i]);
            }
            Console.WriteLine();
            int temp;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0;j < array.Length - 1;j++)
                {
                    if (array[j]>array[j+1])
                    {
                        temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
                      
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);     
            }
        }
    }
}
