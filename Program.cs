using AlgoritimosOrdenacao.algoritimos;
using AlgoritimosOrdencao.algoritimos;

namespace AlgoritimosOrdencao;

internal class Program
{
    private static void Main(string[] args)
    {
        int quantDados = 1000;
        ViewData view = new ViewData();
        Dados data = new Dados(quantDados);
        view.showData(algoritimosEnum.bubbleSort, data);
        view.showData(algoritimosEnum.insertionSort, data);
        view.showData(algoritimosEnum.mergeSort, data);
        view.showData(algoritimosEnum.selectionSort, data);
        view.showData(algoritimosEnum.quickSort, data);
        algoritimosEnum[] algoritmos = { algoritimosEnum.bubbleSort, algoritimosEnum.insertionSort, algoritimosEnum.mergeSort, algoritimosEnum.quickSort, algoritimosEnum.selectionSort };

        //view.showComparation(algoritmos, data);




    }

}