using AlgoritimosOrdenacao;
using AlgoritimosOrdencao;

namespace AlgoritimosOrdenacao.algoritimos
{
    public class SelectionSort : IOrderAlgoritmo
    {
        public string Name => "SelectionSort";
        string IOrderAlgoritmo.complexidadepiorcaso { get => "O(n^2)"; }
        string IOrderAlgoritmo.complexidadecasomedio { get => "O(n^2)"; }
        string IOrderAlgoritmo.complexidademelhorcaso { get => "O(n^2)"; }
        string IOrderAlgoritmo.complexidadeespacos { get => "O(n) total, O(1) auxiliar"; }

        public AlgoritimosResults Order(int[] unOrderList)
        {
            AlgoritimosResults results = new AlgoritimosResults();

            int n = unOrderList.Length;

            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    results.Comparisons++;
                    if (unOrderList[j] < unOrderList[minIndex])
                    {
                        minIndex = j;
                    }
                }
                if (minIndex != i)
                {
                    results.Swaps++;
                    int temp = unOrderList[minIndex];
                    unOrderList[minIndex] = unOrderList[i];
                    unOrderList[i] = temp;
                }
            }

            results.SortedArray = unOrderList;
            return results;
        }
    }
}
