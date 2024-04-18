using System;

namespace AlgoritimosOrdencao.algoritimos
{
    public class BubbleSort : IOrderAlgoritmo
    {

        string IOrderAlgoritmo.Name { get => "Bubble Sort"; }
        string IOrderAlgoritmo.complexidadepiorcaso { get => "O(n^2)"; }
        string IOrderAlgoritmo.complexidadecasomedio { get => "O(n^2)"; }
        string IOrderAlgoritmo.complexidademelhorcaso { get => "O(n)"; }
        string IOrderAlgoritmo.complexidadeespacos { get => "O(1)"; }
        public AlgoritimosResults Order(int[] unOrderList)
        {
            AlgoritimosResults _Results = new AlgoritimosResults();
            bool trocado;
            do
            {
                trocado = false;
                for(int i = 0; i < unOrderList.Length-1; i++)
                {
                    _Results.Comparisons++;
                    if (unOrderList[i]> unOrderList[i + 1])
                    {
                        _Results.Swaps++;
                        Trocar(ref unOrderList[i], ref unOrderList[i+1]);
                        trocado = true;
                    }
                }
            }while( trocado);

            _Results.SortedArray = unOrderList;
            return _Results;
        }

        private static void Trocar(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
       
    }
}

