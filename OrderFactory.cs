using AlgoritimosOrdenacao.algoritimos;
using AlgoritimosOrdencao.algoritimos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritimosOrdencao
{
    public class OrderFactory
    {
      
        public OrderFactory() { }
        public  IOrderAlgoritmo getInstance(algoritimosEnum algoritimos) { 
            switch(algoritimos)
            {
                case (algoritimosEnum.bubbleSort): return new BubbleSort();
                case (algoritimosEnum.insertionSort): return new InsertionSort();
                case (algoritimosEnum.mergeSort): return new MergeSort();
                case (algoritimosEnum.quickSort): return new QuickSort();
                case (algoritimosEnum.selectionSort): return new SelectionSort();
                default: return null;
            }
        
        }
    }
}
