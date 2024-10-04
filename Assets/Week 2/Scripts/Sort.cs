using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sort : MonoBehaviour
{
    public int[] GenerateRandomArray(int length, int minValue, int maxValue)
    {
        int[] randomArray = new int[length];
        for (int i = 0; i < length; i++)
        {
            randomArray[i] = Random.Range(minValue, maxValue);
        }
        return randomArray;
    }

    // Sort Algorithm 1: Insertion Sort
    public void InsertionSort(int[] array)
    {
        for (int i = 1; i < array.Length; i++)
        {
            int key = array[i];
            int j = i - 1;

            // Di chuyen cac phan tu lon hon key ve sau
            while (j >= 0 && array[j] > key)
            {
                array[j + 1] = array[j];
                j = j - 1;
            }
            array[j + 1] = key;
        }
    }

    // Sort Algorithm 2: Selection Sort
    public void SelectionSort(int[] array)
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            int minIndex = i;
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[j] < array[minIndex])
                {
                    minIndex = j;
                }
            }
            // Swap
            int temp = array[minIndex];
            array[minIndex] = array[i];
            array[i] = temp;
        }
    }

    // Sort Algorithm 3: Quick Sort
    public void QuickSort(int[] array, int low, int high)
    {
        if (low < high)
        {
            int pi = Partition(array, low, high);
            QuickSort(array, low, pi - 1);
            QuickSort(array, pi + 1, high);
        }
    }

    private int Partition(int[] array, int low, int high)
    {
        int pivot = array[high];
        int i = (low - 1);
        for (int j = low; j < high; j++)
        {
            if (array[j] < pivot)
            {
                i++;
                int temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }
        }
        int temp1 = array[i + 1];
        array[i + 1] = array[high];
        array[high] = temp1;
        return i + 1;
    }

    // Sort Algorithm 4: Heap Sort
    public void HeapSort(int[] array)
    {
        int n = array.Length;

        // Xay dung heap toi da
        for (int i = n / 2 - 1; i >= 0; i--)
            Heapify(array, n, i);

        // Trich xuat tung phan tu khoi heap
        for (int i = n - 1; i >= 0; i--)
        {
            int temp = array[0];
            array[0] = array[i];
            array[i] = temp;
            Heapify(array, i, 0);
        }
    }

    private void Heapify(int[] array, int n, int i)
    {
        int largest = i;
        int left = 2 * i + 1;
        int right = 2 * i + 2;

        if (left < n && array[left] > array[largest])
            largest = left;
        if (right < n && array[right] > array[largest])
            largest = right;
        if (largest != i)
        {
            int swap = array[i];
            array[i] = array[largest];
            array[largest] = swap;
            Heapify(array, n, largest);
        }
    }

    // Sort Algorithm 5: Merge Sort
    public void MergeSort(int[] array)
    {
        if (array.Length < 2)
            return;
        int mid = array.Length / 2;
        int[] left = new int[mid];
        int[] right = new int[array.Length - mid];

        for (int i = 0; i < mid; i++)
            left[i] = array[i];
        for (int i = mid; i < array.Length; i++)
            right[i - mid] = array[i];

        MergeSort(left);
        MergeSort(right);
        Merge(array, left, right);
    }

    private void Merge(int[] array, int[] left, int[] right)
    {
        int i = 0, j = 0, k = 0;
        while (i < left.Length && j < right.Length)
        {
            if (left[i] <= right[j])
                array[k++] = left[i++];
            else
                array[k++] = right[j++];
        }
        while (i < left.Length)
            array[k++] = left[i++];
        while (j < right.Length)
            array[k++] = right[j++];
    }

    public void ReadArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Debug.Log("Element " + i + ": " + array[i]);
        }
    }

    void Start()
    {
        int[] randomNumbers = GenerateRandomArray(10, 1, 100);
        //----------------------Edit below --------------------
       MergeSort(randomNumbers);
        //----------------------Edit above --------------------
        ReadArray(randomNumbers);
    }
}
