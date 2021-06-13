using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using OfficeOpenXml;

namespace AlgorithmTimer
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            List<int> list = new List<int>();
            Stopwatch timer;

            Dictionary<int, double> runTimes = new Dictionary<int, double>();

            for (int numElements = 1000; numElements < 100000; numElements += 1000)
            {
                Console.WriteLine("Performing iterate twice for " + numElements + " elements...");

                // generate the list of random numbers
                list.Clear();
                for (int i = 1; i <= numElements; i++)
                {
                    list.Add(rand.Next());
                }

                // perform the algorithm
                timer = new Stopwatch();
                timer.Start();
                IterateTwice(list);
                timer.Stop();

                // record the data
                double elapsed = timer.Elapsed.TotalMilliseconds;
                runTimes.Add(numElements, elapsed);

                Console.WriteLine("Elapsed: " + elapsed);
                Console.WriteLine("\r\n");
            }

            /*
            for (int numElements = 1000000; numElements <= 100000000; numElements += 1000000)
            {
                Console.WriteLine("Performing insertion sort for " + numElements + " elements...");

                // generate the list of random numbers
                list.Clear();
                for (int i = 1; i <= numElements; i++)
                {
                    list.Add(rand.Next());
                }

                // perform the sort
                timer = new Stopwatch();
                timer.Start();
                List<int> sortedList = InsertionSort(list);
                timer.Stop();

                // record the data
                double elapsed = timer.Elapsed.TotalMilliseconds;
                runTimes.Add(numElements, elapsed);

                Console.WriteLine("Elapsed: " + elapsed);
                Console.WriteLine("\r\n");
            }
            */

            // write to Excel
            using (ExcelPackage pck = new ExcelPackage(new System.IO.FileInfo("output.xlsx")))
            {
                ExcelWorksheet ws = pck.Workbook.Worksheets.Add("Output");

                int row = 1;
                foreach (var kvp in runTimes)
                {
                    ws.Cells[row, 1].Value = kvp.Key;
                    ws.Cells[row, 2].Value = kvp.Value;

                    row++;
                }

                pck.Save();
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        public static void IterateTwice(List<int> list)
        {
            foreach (var i in list)
            {
                foreach (var j in list)
                {
                    int result = i * j;
                }
            }
        }

        public static int CheckAllPairs(int[] list)
        {
            int count = 0;

            for (int i = 0; i < list.Length; i++)
            {
                for (int j = i+1; j < list.Length; j++)
                {
                    if (list[i] + list[j] == 0)
                        count++;
                }
            }

            return count;
        }

        public static List<int> InsertionSort(List<int> list)
        {
            int i = 1;
            while (i < list.Count)
            {
                int j = 1;
                while ((j > 0) && (list[j-1] > list[j]))
                {
                    Swap(list, j, j - 1);

                    j--;
                }

                i++;
            }

            return list;
        }

        private static void Swap(List<int> list, int indexA, int indexB)
        {
            int tmp = list[indexA];
            list[indexA] = list[indexB];
            list[indexB] = tmp;
        }
    }
}
