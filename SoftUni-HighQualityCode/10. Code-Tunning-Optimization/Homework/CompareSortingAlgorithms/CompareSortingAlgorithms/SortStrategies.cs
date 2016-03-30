using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareSortingAlgorithms
{
    class SortStrategies
    {
        public static T[] InsertionSort<T>(T[] inputarray, Comparer<T> comparer = null)
        {
            var equalityComparer = comparer ?? Comparer<T>.Default;
            for (var counter = 0; counter < inputarray.Length - 1; counter++)
            {
                var index = counter + 1;
                while (index > 0)
                {
                    if (equalityComparer.Compare(inputarray[index - 1], inputarray[index]) > 0)
                    {
                        var temp = inputarray[index - 1];
                        inputarray[index - 1] = inputarray[index];
                        inputarray[index] = temp;
                    }
                    index--;
                }
            }
            return inputarray;
        }

        public static void SelectionSort<T>(T[] a) where T : IComparable
        {
            for (int sortedSize = 0; sortedSize < a.Length; sortedSize++)
            {
                int minElementIndex = sortedSize;
                T minElementValue = a[sortedSize];
                for (int i = sortedSize + 1; i < a.Length; i++)
                {
                    if (a[i].CompareTo(minElementValue) < 0)
                    {
                        minElementIndex = i;
                        minElementValue = a[i];
                    }
                }
                a[minElementIndex] = a[sortedSize];
                a[sortedSize] = minElementValue;
            }
        }
        #region QuickSort
        public static void QuickSort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int pivot = Partition(arr, left, right);

                if (pivot > 1)
                    QuickSort(arr, left, pivot - 1);

                if (pivot + 1 < right)
                    QuickSort(arr, pivot + 1, right);
            }
        }

        private static int Partition(int[] numbers, int left, int right)
        {
            int pivot = numbers[left];
            while (true)
            {
                while (numbers[left] < pivot)
                    left++;

                while (numbers[right] > pivot)
                    right--;

                if (left < right)
                {
                    int temp = numbers[right];
                    numbers[right] = numbers[left];
                    numbers[left] = temp;
                }
                else
                {
                    return right;
                }
            }
        }
        #endregion

        #region MergeSort
        public static void MergeSort(ref int[] unsortedArray, int leftIndex, int rightIndex)
        {
            if (leftIndex < rightIndex)
            {
                int middleIndex = (leftIndex + rightIndex) / 2;
                //Sort left (will call Merge to produce a fully sorted left array)
                MergeSort(ref unsortedArray, leftIndex, middleIndex);
                //Sort right (will call Merge to produce a fully sorted right array)
                MergeSort(ref unsortedArray, middleIndex + 1, rightIndex);
                //Merge the sorted left & right to finish off.
                Merge(ref unsortedArray, leftIndex, middleIndex, rightIndex);
            }
        }

        private static void Merge(ref int[] unsortedArray, int leftIndex, int middleIndex, int rightIndex)
        {
            int lengthLeft = middleIndex - leftIndex + 1;
            int lengthRight = rightIndex - middleIndex;
            int[] leftArray = new int[lengthLeft + 1];
            int[] rightArray = new int[lengthRight + 1];
            for (int i = 0; i < lengthLeft; i++)
            {
                leftArray[i] = unsortedArray[leftIndex + i];
            }
            for (int j = 0; j < lengthRight; j++)
            {
                rightArray[j] = unsortedArray[middleIndex + j + 1];
            }
            leftArray[lengthLeft] = Int32.MaxValue;
            rightArray[lengthRight] = Int32.MaxValue;
            int iIndex = 0;
            int jIndex = 0;
            for (int k = leftIndex; k <= rightIndex; k++)
            {
                if (leftArray[iIndex] <= rightArray[jIndex])
                {
                    unsortedArray[k] = leftArray[iIndex];
                    iIndex++;
                }
                else
                {
                    unsortedArray[k] = rightArray[jIndex];
                    jIndex++;
                }
            }
        }
        #endregion

    }
}
