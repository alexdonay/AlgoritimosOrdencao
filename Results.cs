using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritimosOrdencao
{
    public class AlgoritimosResults
    {
        public int[] SortedArray { get; set; }
        public int Comparisons { get; set; }
        public int Swaps { get; set; }
        public override string ToString() {
            return string.Join(",", SortedArray);
        }
        public AlgoritimosResults()
        {
           

        }
        
    }
}
