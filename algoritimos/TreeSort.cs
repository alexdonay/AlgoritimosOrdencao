using System;

namespace AlgoritimosOrdencao.algoritimos
{
    public class TreeSort : IOrderAlgoritmo
    {
        public string Name { get => "Tree Sort"; }
        public string complexidadepiorcaso { get => "O(n^2)"; }
        public string complexidadecasomedio { get => "O(n log n)"; }
        public string complexidademelhorcaso { get => "O(n log n)"; }
        public string complexidadeespacos { get => "O(n)"; }

        public AlgoritimosResults Order(int[] unOrderList)
        {
            AlgoritimosResults results = new AlgoritimosResults();

            // Construir a árvore binária de pesquisa
            BinaryTree tree = new BinaryTree();
            foreach (int item in unOrderList)
            {
                tree.Insert(item);
            }

            // Preencher a lista ordenada usando a travessia in-order da árvore
            results.SortedArray = tree.InOrderTraversal();

            // O número de comparações é o número total de elementos na árvore
            results.Comparisons = unOrderList.Length;

            // Não há trocas explícitas em Tree Sort, então swaps é 0
            results.Swaps = 0;

            return results;
        }
    }

    public class BinaryTree
    {
        private class TreeNode
        {
            public int Value { get; set; }
            public TreeNode Left { get; set; }
            public TreeNode Right { get; set; }

            public TreeNode(int value)
            {
                Value = value;
            }
        }

        private TreeNode root;

        public void Insert(int value)
        {
            root = InsertRec(root, value);
        }

        private TreeNode InsertRec(TreeNode node, int value)
        {
            if (node == null)
            {
                node = new TreeNode(value);
                return node;
            }

            if (value < node.Value)
            {
                node.Left = InsertRec(node.Left, value);
            }
            else if (value > node.Value)
            {
                node.Right = InsertRec(node.Right, value);
            }

            return node;
        }

        public int[] InOrderTraversal()
        {
            List<int> result = new List<int>();
            InOrderTraversalRec(root, result);
            return result.ToArray();
        }

        private void InOrderTraversalRec(TreeNode node, List<int> result)
        {
            if (node != null)
            {
                InOrderTraversalRec(node.Left, result);
                result.Add(node.Value);
                InOrderTraversalRec(node.Right, result);
            }
        }
    }
}
