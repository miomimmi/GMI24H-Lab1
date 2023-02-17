using System;
using System.IO;
using LaborationInterfaces;

namespace Assadi_Laila
{
    public class Laboration_1 : ILaboration_1
    {
        public static void Main(string[] args)
        {
            int inDataSize = 90000; // 3000000 - 490000000

            Console.WriteLine("Skapar och spar indata");
            int[] indata = new int[inDataSize];
            int[] copyOfIndata = new int[indata.Length];

            Laboration_1 lab = new();
            
            Console.WriteLine("Mäter algoritmens exekveringstid");
            
            DateTime s = DateTime.Now;
            lab.ReverseArray_Improved(copyOfIndata);
            DateTime e = DateTime.Now;
            TimeSpan executionTime = e - s;

            DateTime s1 = DateTime.Now;
            lab.ReverseArray_Improved(copyOfIndata);
            DateTime e1 = DateTime.Now;
            TimeSpan executionTime1 = e1 - s1;

            DateTime s2 = DateTime.Now;
            lab.ReverseArray_Improved(copyOfIndata);
            DateTime e2 = DateTime.Now;
            TimeSpan executionTime2 = e2 - s2;

            DateTime s3 = DateTime.Now;
            lab.ReverseArray_Improved(copyOfIndata);
            DateTime e3 = DateTime.Now;
            TimeSpan executionTime3 = e3 - s3;

            DateTime s4 = DateTime.Now;
            lab.ReverseArray_Improved(copyOfIndata);
            DateTime e4 = DateTime.Now;
            TimeSpan executionTime4 = e4 - s4;

            DateTime s5 = DateTime.Now;
            lab.ReverseArray_Improved(copyOfIndata);
            DateTime e5 = DateTime.Now;
            TimeSpan executionTime5 = e5 - s5;

            DateTime s6 = DateTime.Now;
            lab.ReverseArray_Improved(copyOfIndata);
            DateTime e6 = DateTime.Now;
            TimeSpan executionTime6 = e6 - s6;

            DateTime s7 = DateTime.Now;
            lab.ReverseArray_Improved(copyOfIndata);
            DateTime e7 = DateTime.Now;
            TimeSpan executionTime7 = e7 - s7;

            DateTime s8 = DateTime.Now;
            lab.ReverseArray_Improved(copyOfIndata);
            DateTime e8 = DateTime.Now;
            TimeSpan executionTime8 = e8 - s8;

            DateTime s9 = DateTime.Now;
            lab.ReverseArray_Improved(copyOfIndata);
            DateTime e9 = DateTime.Now;
            TimeSpan executionTime9 = e9 - s9;

            double ms = executionTime.TotalMilliseconds;
            Console.WriteLine($"Indata-storlek: {inDataSize:e2}\t Exekveringstid: {ms} millisekunder");

            double ms1 = executionTime1.TotalMilliseconds;
            Console.WriteLine($"Indata-storlek: {inDataSize:e2}\t Exekveringstid: {ms1} millisekunder");

            double ms2 = executionTime2.TotalMilliseconds;
            Console.WriteLine($"Indata-storlek: {inDataSize:e2}\t Exekveringstid: {ms2} millisekunder");

            double ms3 = executionTime3.TotalMilliseconds;
            Console.WriteLine($"Indata-storlek: {inDataSize:e2}\t Exekveringstid: {ms3} millisekunder");

            double ms4 = executionTime4.TotalMilliseconds;
            Console.WriteLine($"Indata-storlek: {inDataSize:e2}\t Exekveringstid: {ms4} millisekunder");

            double ms5 = executionTime5.TotalMilliseconds;
            Console.WriteLine($"Indata-storlek: {inDataSize:e2}\t Exekveringstid: {ms5} millisekunder");

            double ms6 = executionTime6.TotalMilliseconds;
            Console.WriteLine($"Indata-storlek: {inDataSize:e2}\t Exekveringstid: {ms6} millisekunder");

            double ms7 = executionTime7.TotalMilliseconds;
            Console.WriteLine($"Indata-storlek: {inDataSize:e2}\t Exekveringstid: {ms7} millisekunder");

            double ms8 = executionTime8.TotalMilliseconds;
            Console.WriteLine($"Indata-storlek: {inDataSize:e2}\t Exekveringstid: {ms8} millisekunder");

            double ms9 = executionTime9.TotalMilliseconds;
            Console.WriteLine($"Indata-storlek: {inDataSize:e2}\t Exekveringstid: {ms9} millisekunder");



        }

        public uint MaxDiff_BruteForce(int[] inputArray)
        {
            int result = 0;

            // kontrollerar kombinationer med två for loopar
            for (int i = inputArray.Length - 1; i > -1; --i)
            {
                for (int j = inputArray.Length - 1; j > -1; --j)
                {
                    int diff = inputArray[j] - inputArray[i];

                    // hittar största skillnaden 
                    if (diff > result)
                    {
                        result = diff;
                    }
                }
            }
            return (uint)result;
        }

        public uint MaxDiff_Improved(int[] inputArray)
        {
            if (inputArray.Length < 1)
            {
                return 0;
            }
            
            int min = inputArray[0];
            int max = inputArray[0];
            
            // loopar igenom för att hitta största och minsta talen i arrayen
            for (int i = 0; i < inputArray.Length; i++)
            {
                if (inputArray[i] < min)
                { 
                    min = inputArray[i];
                } 
                if (inputArray[i] > max)
                {
                    max = inputArray[i];
                }   
            }
            
            // subtaherar största med minsta talet för att få största skillnaden
            int result = max - min;
            return (uint)result; 
        }

        public uint NOfOccurrences(int[] inputArray, int value)
        {
            int x = 0;
            
            // loopar igenom arrayen och kontrollerar om bestämda talet finns med i arrayen
            for (int i = 0; i < inputArray.Length; i++)
            {
                if (value == inputArray[i])
                {
                    x++;
                }
            }
            return (uint)x;
        }

        public void ReverseArray(int[] inputArray)
        {
            int i = 1;
            while (i < inputArray.Length)
            {
                int nextValue = inputArray[i];
                int j = i;

                while (j > 0)
                {
                    inputArray[j] = inputArray[j - 1];
                    j--;
                }

                inputArray[0] = nextValue;
                i++;
            }
        }

        public void ReverseArray_Improved(int[] inputArray)
        {
            int i = 0;
            int j = inputArray.Length - 1;
            
            // loppar igenom och vänder på ordningen av arrayen
            while (i < j)
            {
                int nextValue = inputArray[i];
                inputArray[i] = inputArray[j];
                inputArray[j] = nextValue;
                i++;
                j--;
            }
        }
    }
}
