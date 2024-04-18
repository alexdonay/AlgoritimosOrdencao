using AlgoritimosOrdenacao;
using AlgoritimosOrdencao;

namespace AlgoritimosOrdenacao.algoritimos
{
    public class MergeSort : IOrderAlgoritmo
    {
        private AlgoritimosResults Results = new AlgoritimosResults();
        string IOrderAlgoritmo.Name { get => "Bubble Sort"; }
        string IOrderAlgoritmo.complexidadepiorcaso { get => "Theta(n log n)"; }
        string IOrderAlgoritmo.complexidadecasomedio { get => "Theta(n log n)"; }
        string IOrderAlgoritmo.complexidademelhorcaso { get => "Theta(n log n)  tipico, Theta(n log n) variante natural"; }
        string IOrderAlgoritmo.complexidadeespacos { get => "Theta(n log n)"; }
        public AlgoritimosResults Order(int[] unOrderList)
        {
            Results.Comparisons = 0;
            Results.Swaps = 0;

            MergeSortArray(unOrderList);
            return Results;
        }

        private void MergeSortArray(int[] array)
        {
            int n = array.Length;
            if (n < 2) return;

            int mid = n / 2;
            int[] leftArray = new int[mid];
            int[] rightArray = new int[n - mid];

            System.Array.Copy(array, 0, leftArray, 0, mid);
            System.Array.Copy(array, mid, rightArray, 0, n - mid);

            MergeSortArray(leftArray);
            MergeSortArray(rightArray);

            Merge(leftArray, rightArray, array);
        }

        private void Merge(int[] leftArray, int[] rightArray, int[] array)
        {
            int n1 = leftArray.Length;
            int n2 = rightArray.Length;
            int iLeft = 0, iRight = 0, k = 0;

            while (iLeft < n1 && iRight < n2)
            {
                Results.Comparisons++;
                if (leftArray[iLeft] <= rightArray[iRight])
                {
                    array[k] = leftArray[iLeft];
                    iLeft++;
                }
                else
                {
                    array[k] = rightArray[iRight];
                    iRight++;
                    Results.Swaps += n1 - iLeft; // Correção para contar as movimentações corretamente
                }
                k++;
            }

            while (iLeft < n1)
            {
                array[k] = leftArray[iLeft];
                iLeft++;
                k++;
                Results.Swaps++;
            }

            while (iRight < n2)
            {
                array[k] = rightArray[iRight];
                iRight++;
                k++;
                Results.Swaps++;
            }
        }
    }
}
