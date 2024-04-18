using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritimosOrdencao
{
   
    public class Dados
    {
        public int[] listaOrdenada { get; private set; }
        public int[] listaNaoOrdenada { get; private set; }
        public int[] listaInversamenteOrdenada { get; private set; }
        public Dados() { }
        public Dados(int quant)
        {
            listaOrdenada = new int[quant];
            listaNaoOrdenada=new int[quant];
            listaInversamenteOrdenada = new int[quant];

            for (int i = 0; i < quant; i++)
            {
                listaOrdenada[i] = i;
                listaNaoOrdenada[i] = i;
                listaInversamenteOrdenada[i] = i;
            }
            this.listaInversamenteOrdenada = listaInversamenteOrdenada.Reverse().ToArray();
            Random rand = new Random();
            List<int> numerosAleatorios = Enumerable.Range(0, quant).OrderBy(x => rand.Next()).ToList();
            listaNaoOrdenada = numerosAleatorios.ToArray();

        }
    }
}
