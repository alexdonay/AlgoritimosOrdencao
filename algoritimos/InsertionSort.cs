using System;

namespace AlgoritimosOrdencao.algoritimos
{
    public class InsertionSort : IOrderAlgoritmo
    {
        public string Name => "InsertionSort";
        string IOrderAlgoritmo.complexidadepiorcaso { get => "O(n^2)"; }
        string IOrderAlgoritmo.complexidadecasomedio { get => "O(n^2)"; }
        string IOrderAlgoritmo.complexidademelhorcaso { get => "O(n)"; }
        string IOrderAlgoritmo.complexidadeespacos { get => "O(n) total O(1) auxiliar"; }

        public AlgoritimosResults Order(int[] unOrderList)
        {
            AlgoritimosResults results = new AlgoritimosResults();
            int n = unOrderList.Length;
            
            
            for (int i = 0; i < n-1; ++i)
            {
              for(int j = i +1; j>0; j--)
                {
                    results.Comparisons++;
                    if (unOrderList[j-1] > unOrderList[j])
                    {
                        results.Swaps++;
                        int temp = unOrderList[j-1];
                        unOrderList[j - 1] = unOrderList[j];
                        unOrderList[j] = temp;
                    }
                }
            }
            results.SortedArray = unOrderList;
            return results;
        }
    }
}
//https://www.w3resource.com/csharp-exercises/searching-and-sorting-algorithm/searching-and-sorting-algorithm-exercise-6.php