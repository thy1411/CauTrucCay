using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CauTrucCay
{
    class TNode
    {
        public int Info;
        public TNode Left;
        public TNode Right;
        public TNode(int x)
        {
            Info = x;
            Left = null;
            Right = null;
        }
    }
    //Định nghĩa cay nhị phân
    class SearchBinaryTree
    {
        public TNode Root;
        public SearchBinaryTree()
        {
            Root = null;
        }
        //Thao tác duyệt cây
        public void NLR(TNode root) //duyệt theo thứ tự trước
        {
            if (root != null)
            {
                Console.Write($"{root.Info}     ->      ");
                NLR(root.Left);
                NLR(root.Right);
            }
        }
        public void LNR(TNode root) //duyệt theo thứ tự giữa
        {
            if (root != null)
            {
                LNR(root.Left);
                Console.Write($"{root.Info}     ->      ");
                LNR(root.Right);
            }
        }
        public void LRN(TNode root) //duyệt theo thứ tự sau
        {
            if (root != null)
            {
                LRN(root.Left);
                LRN(root.Right);
                Console.Write($"{root.Info}     ->      ");
            }
        }
        //Thao tác thêm vào cây nhị phân tìm kiếm
        public void ThemNode(ref TNode root, int x)
        {
            if (root == null)
            {
                TNode p = new TNode(x);
                root = p;
            }
            else if (root.Info > x)
                ThemNode(ref root.Left, x);
            else if (root.Info < x)
                ThemNode(ref root.Right, x);
        }
        //Phương thức tạo cây
        public void TaoCay()
        {
            Console.Write("Cho biet so nut trong cay: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.Write("Nhap gia tri node thu " + i + ": ");
                int x = int.Parse(Console.ReadLine());
                ThemNode(ref Root, x);
            } 
                
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string chon = "y";
            while (true)
            {
                SearchBinaryTree tree = new SearchBinaryTree();
                tree.TaoCay();
                Console.WriteLine("Ket qua duyet cay: ");
                Console.Write("NLR: ");
                tree.NLR(tree.Root);
                Console.WriteLine();

                Console.Write("LNR: ");
                tree.LNR(tree.Root);
                Console.WriteLine();

                Console.Write("LRN: ");
                tree.LRN(tree.Root);
                Console.WriteLine();

                Console.Write("Ban co muon tiep tuc? (y/n)");
                chon = Console.ReadLine();
                Console.Clear();

                if (chon == "n")
                    break;
            }
        }
    }
}
