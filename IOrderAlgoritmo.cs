using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlgoritimosOrdencao.algoritimos;

namespace AlgoritimosOrdencao
{
    public interface IOrderAlgoritmo
    {
        string Name {get;}
        string complexidadepiorcaso { get; }
        string complexidadecasomedio { get; }
        string complexidademelhorcaso { get; }
        string complexidadeespacos { get; } 

        AlgoritimosResults Order(int[] unOrderList);
    }
}
