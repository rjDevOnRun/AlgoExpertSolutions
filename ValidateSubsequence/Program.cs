using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidateSubsequence
{
    class Program
    {
        //https://www.algoexpert.io/questions/Validate%20Subsequence
        static void Main(string[] args)
        {
            //List<int> array = new List<int> { 5, 1, 22, 25, 6, -1, 8, 10 };
            //List<int> sequence = new List<int> { 1, 6, -1, 10 };

            //List<int> array = new List<int> { 5, 1, 22, 25, 6, -1, 8, 10 };
            //List<int> sequence = new List<int> { 5, 1, 22, 22, 25, 6, -1, 8, 10 };

            List<int> array = new List<int> { 5, 1, 22, 25, 6, -1, 8, 10 };
            List<int> sequence = new List<int> { 1, 6, -1, -1, 10 };

            //bool IsSequence = IsValidSubsequence(array, sequence);
            bool IsSequence = IsValidSubsequenceSolution(array, sequence);

            Console.WriteLine($"Sequence Match = {IsSequence}");
            Console.ReadKey();
        }

        private static bool IsValidSubsequence(List<int> array, List<int> sequence)
        {
            int foundMatchCount = 0;
            int nextArrayIndex = 0;
            for (int seqIndex = 0; seqIndex < sequence.Count; seqIndex++)
            {
                for (int arrIndex = nextArrayIndex; arrIndex < array.Count; arrIndex++)
                {
                    if(array[arrIndex] == sequence[seqIndex])
                    {
                        Console.WriteLine($"{array[arrIndex]} == {sequence[seqIndex]}");
                        foundMatchCount++; nextArrayIndex = arrIndex;
                        break;
                    }
                }
            }
            if (foundMatchCount == sequence.Count)
                return true;

            return false;
        }

        private static bool IsValidSubsequenceSolution(List<int> array, List<int> sequence)
        {
            int arrIdx = 0; int seqIdx = 0;
            while (arrIdx< array.Count && seqIdx < sequence.Count)
            {
                Console.Write($"{array[arrIdx]} == {sequence[seqIdx]} ??? ");
                if (array[arrIdx] == sequence[seqIdx])
                {
                    Console.Write(" -> True\n");
                    seqIdx++;
                }
                Console.Write("\n");
                arrIdx++;
            }
            Console.WriteLine($"{seqIdx} - {sequence.Count}");
            return seqIdx == sequence.Count;
        }
    }
}
