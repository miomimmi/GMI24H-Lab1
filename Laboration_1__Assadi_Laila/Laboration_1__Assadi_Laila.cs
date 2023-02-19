using System;
using System.IO;
using LaborationInterfaces;

namespace Assadi_Laila
{
    public class Laboration_1 : ILaboration_1
    {
       
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
