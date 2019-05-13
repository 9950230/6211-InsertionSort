using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int length = 100000;
            int[] numbers = new int[length];
            int[] numbersCopy = new int[length];
            int[] numbersCopy2 = new int[length];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(0, length);
            }

            Array.Copy(numbers, numbersCopy, length);
            Array.Copy(numbers, numbersCopy2, length);

            //Console.WriteLine("Unsorted: ");
            //foreach (int number in numbers)
            //Console.Write(" {0}", number);

            Stopwatch sw = new Stopwatch();
            sw.Start();
            int[] sortedNumbers = InsertionSort(numbersCopy);
            sw.Stop();
            Console.WriteLine("\nInsertion Sort: {0} milliseconds", sw.ElapsedMilliseconds);

            Stopwatch sw2 = new Stopwatch();
            sw2.Start();
            int[] sortedNumbers2 = StandardBubbleSort(numbersCopy2);
            sw2.Stop();
            Console.WriteLine("\nBubble Sort: {0} milliseconds", sw2.ElapsedMilliseconds);

            //Console.WriteLine("Insertion Sorted: ");
            //foreach (int number in sortedNumbers)
            //Console.Write(" {0}", number);

            //Console.WriteLine("Bubble Sorted: ");
            //foreach (int number in sortedNumbers2)
            //    Console.Write(" {0}", number);

            Console.ReadLine();

        }

        static int[] InsertionSort(int[] array)
        {
            int temp, j;

            for (int i = 1; i < array.Length; i++)
            {
                j = i;
                temp = array[i];
                while (j > 0 && array[j - 1] >= temp)
                {
                    array[j] = array[j - 1];
                    j--;
                }
                array[j] = temp;
            }

            return array;
        }

        static int[] StandardBubbleSort(int[] numbers)
        {
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = 0; j < numbers.Length - 1; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        int temp = numbers[j + 1];
                        numbers[j + 1] = numbers[j];
                        numbers[j] = temp;
                    }
                }
            }
            return numbers;
        }
    }
}
