using System;

namespace AlgoritimosOrdencao
{
    public class ViewData
    {
        public ViewData() { }
        public void showData(algoritimosEnum algoritmo, Dados dados)
        {
            Context ctx = new Context(algoritmo, dados);
            Console.WriteLine($"{ctx.getName()}");
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine($"Complexidade Melhor: {ctx.getComplexidadeMelhorCaso()}");
            Console.WriteLine($"Complexidade Caso medio: {ctx.getComplexidadeCasoMedio()}");
            Console.WriteLine($"Complexidade Pior Caso: {ctx.getComplexidadePiorCaso()}");
            Console.WriteLine($"Complexidade de espaços pior caso: {ctx.getComplexidadeEspacos()}");


            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine($"| {algoritmo}      | Tipo de Dados     | Comparações | Trocas |");
            Console.WriteLine("------------------------------------------------------------");

            
            printResults(ctx.getName(), "Ordenada", ctx.ResultsInOrder());
            printResults(ctx.getName(), "Não Ordenada", ctx.ResultsUnOrder());
            printResults(ctx.getName(), "Inversamente", ctx.ResultsInverseOrder());

            Console.WriteLine("------------------------------------------------------------");
        }

        private void printResults(string algoritmo, string tipoDados, AlgoritimosResults results)
        {
            string format = "| {0,-15} | {1,-17} | {2,-11} | {3,-6} |";
            Console.WriteLine(format, "", tipoDados, results.Comparisons, results.Swaps);
        }

        public void showComparation(algoritimosEnum[] algoritmos, Dados dados)
        {
            Console.WriteLine("------------------------------------------------------------------------");
            Console.WriteLine("| Algoritmo           | Total de Comparações | Total de Trocas | Eficiência |");
            Console.WriteLine("------------------------------------------------------------------------");

            // Calcular o total de comparações e trocas para todos os algoritmos
            int totalComparisons = 0;
            int totalSwaps = 0;
            foreach (var algoritmo in algoritmos)
            {
                AlgoritimosResults results = RunAlgorithm(algoritmo, dados);
                totalComparisons += results.Comparisons;
                totalSwaps += results.Swaps;
            }

            // Calcular a eficiência de cada algoritmo em relação ao total
            foreach (var algoritmo in algoritmos)
            {
                AlgoritimosResults results = RunAlgorithm(algoritmo, dados);
                double comparisonEfficiency = (double)results.Comparisons / totalComparisons * 100;
                double swapEfficiency = (double)results.Swaps / totalSwaps * 100;
                Console.WriteLine($"| {algoritmo,-20} | {results.Comparisons,-20} | {results.Swaps,-15} | {comparisonEfficiency,-10:F2}% / {swapEfficiency,-10:F2}% |");
            }

            Console.WriteLine("------------------------------------------------------------------------");
        }
    

    private AlgoritimosResults RunAlgorithm(algoritimosEnum algoritmo, Dados dados)
    {
        Context ctx = new Context(algoritmo, dados);
        AlgoritimosResults results = new AlgoritimosResults();

        results.Comparisons += ctx.ResultsInOrder().Comparisons;
        results.Swaps += ctx.ResultsInOrder().Swaps;

        results.Comparisons += ctx.ResultsUnOrder().Comparisons;
        results.Swaps += ctx.ResultsUnOrder().Swaps;

        results.Comparisons += ctx.ResultsInverseOrder().Comparisons;
        results.Swaps += ctx.ResultsInverseOrder().Swaps;

        return results;
    }



}

}
