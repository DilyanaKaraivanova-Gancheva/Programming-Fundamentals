using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Kamino_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            int dnaLength = int.Parse(Console.ReadLine());
            string[] sequance = Console.ReadLine().Split(new[] { '!' },StringSplitOptions.RemoveEmptyEntries).ToArray();

            int counter = 0;
            int currentLength = 0;
            int bestlength = -1;
            int[] bestsequance = new int[dnaLength];
            int sum = 0;
            int currentSum = 0;
            int bestSum = 0;
            int currantLastIndex = 0;
            int sampleIndex = 0;
            int bestSampleIndex = 0;
            int startIndex = -1;
           
            while (true)
            {  
                if (sequance[0] == "Clone them" )
                {
                    break;
                }
                var numSequance = sequance.Select(int.Parse).ToArray();
                sum = sequance.Select(int.Parse).Sum();
                currentLength = 0;
                currantLastIndex = 0;
                counter = 0;

                for (int i = 0; i < sequance.Length; i++)
                {
                   
                    if (numSequance[i] == 1)
                    {
                        counter++;
                        if (currentLength < counter)
                        {
                            currentLength = counter;
                            currantLastIndex = i;
                            currentSum = sum;
                        }
                  }
                    else
                    {
                        counter = 0;
                    }
                }

                sampleIndex++;
                int currentStartIndex = currantLastIndex - currentLength + 1;

                if (bestlength < currentLength)
                {
                    bestlength = currentLength;
                    bestsequance = numSequance;
                    startIndex = currentStartIndex;
                    bestSampleIndex = sampleIndex;
                    bestSum = currentSum;
                }
                else if (bestlength == currentLength)
                {
                    if (startIndex > currentStartIndex)
                    {
                        bestlength = currentLength;
                        bestsequance = numSequance;
                        startIndex = currentStartIndex;
                        bestSampleIndex = sampleIndex;
                        bestSum = currentSum;
                    }
                    else if (startIndex == currentStartIndex)
                    {
                        if (bestSum < currentSum)
                        {
                            bestlength = counter;
                            bestsequance = numSequance;
                            bestSampleIndex = sampleIndex;
                            bestSum = currentSum;
                        }
                    }
                }
                sequance = Console.ReadLine().Split(new[] { '!' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            }
            
            Console.WriteLine($"Best DNA sample {bestSampleIndex } with sum: {bestSum}.");
            Console.WriteLine(string.Join(" ", bestsequance));
        }
    }
}
