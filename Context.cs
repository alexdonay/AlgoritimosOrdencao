using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritimosOrdencao
{
    public class Context
    {
        private IOrderAlgoritmo Order { get; set; }
        private IOrderAlgoritmo UnOrder { get; set; }
        private IOrderAlgoritmo InverseOrder {get; set; }
        private int[] listaOrdenada { get; set; }
        private int[] listaNaoOrdenada { get; set; }
        private int[] listaInversamente { get; set; }

        private string name;
        IOrderAlgoritmo orderAlgoritmo { get; set; }
        private OrderFactory factory = new OrderFactory();
        public Context(algoritimosEnum algoritimo, Dados args) {

            this.orderAlgoritmo = this.factory.getInstance(algoritimo);
            this.Order = this.factory.getInstance(algoritimo);
            this.UnOrder = this.factory.getInstance(algoritimo);
            this.InverseOrder = this.factory.getInstance(algoritimo);
            
            this.listaOrdenada = args.listaOrdenada;
            this.listaNaoOrdenada = args.listaNaoOrdenada;
            this.listaInversamente = args.listaInversamenteOrdenada;
            this.name = Order.Name;
        }
        public string getName()
        {
            return this.name;
        }
        public string getComplexidadePiorCaso()
        {
            return this.orderAlgoritmo.complexidadepiorcaso;
        }
        public string getComplexidadeCasoMedio()
        {
            return this.orderAlgoritmo.complexidadecasomedio;
        }
        public string getComplexidadeMelhorCaso()
        {
            return this.orderAlgoritmo.complexidademelhorcaso;
        }
        public string getComplexidadeEspacos()
        {
            return this.orderAlgoritmo.complexidadeespacos;
        }
        public AlgoritimosResults ResultsInOrder()
        {
            int[] orderedList = new int[listaOrdenada.Length];
            Array.Copy(listaOrdenada, orderedList, listaOrdenada.Length);
            this.listaOrdenada = orderedList;
            return this.Order.Order(orderedList);
        }
        public AlgoritimosResults ResultsUnOrder()
        {
            int[] orderedList = new int[listaNaoOrdenada.Length];
            Array.Copy(listaNaoOrdenada, orderedList, listaNaoOrdenada.Length);
            this.listaOrdenada = orderedList;
            return this.UnOrder.Order(orderedList);
        }
        public AlgoritimosResults ResultsInverseOrder()
        {
            int[] orderedList = new int[listaInversamente.Length];
            Array.Copy(listaInversamente, orderedList, listaInversamente.Length);
            this.listaInversamente = orderedList;
            return this.InverseOrder.Order(orderedList);
        }
    }
}
