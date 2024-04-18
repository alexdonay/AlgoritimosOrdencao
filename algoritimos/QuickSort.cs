using AlgoritimosOrdencao;
using System;

namespace AlgoritimosOrdencao.algoritimos
{
    public class QuickSort : IOrderAlgoritmo
    {
        public string Name => "QuickSort";
        string IOrderAlgoritmo.complexidadepiorcaso { get => "O(n^2)"; }
        string IOrderAlgoritmo.complexidadecasomedio { get => "O(n log n)"; }
        string IOrderAlgoritmo.complexidademelhorcaso { get => "O(n log n)"; }
        string IOrderAlgoritmo.complexidadeespacos { get => "O(n)"; }

        private AlgoritimosResults results = new AlgoritimosResults();
        

        AlgoritimosResults IOrderAlgoritmo.Order(int[] unOrderList)
        {
            results.Comparisons = 0;
            results.Swaps = 0;

            QuickSortArray(unOrderList, 0, unOrderList.Length - 1);

            results.SortedArray = unOrderList;
            return results;
        }

        private void QuickSortArray(int[] array, int left, int right)
        {
            if (left < right)
            {
                int pivotIndex = Partition(array, left, right);
                QuickSortArray(array, left, pivotIndex - 1);
                QuickSortArray(array, pivotIndex + 1, right);
            }
        }

        private int Partition(int[] array, int left, int right)
        {
            
            int pivot = array[(left + right) / 2];
            int i = left - 1;
            int j = right + 1;

            while (true)
            {
                do
                {
                    i++;
                    results.Comparisons++;
                } while (array[i] < pivot);

                do
                {
                    j--;
                    results.Comparisons++;
                } while (array[j] > pivot);

                if (i >= j)
                    return j;

                Swap(array, i, j);
            }
        }

        private void Swap(int[] array, int i, int j)
        {
            results.Swaps++;
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }
}
