using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PostorderTask
{
    /*
     * This task is print a binary tree by postorder with 
     * a inorder and preorder string as input
     */

    class Program
    {
        static void Main(string[] args)
        {
            string inorder = "";
            string preorder = "";

            Console.Write("Preorder:");
            preorder = Console.ReadLine();
            Console.Write("Inorder:");
            inorder = Console.ReadLine();

            Console.Write("Postorder:");
            postorder(inorder,ref preorder);
            Thread.Sleep(10000);
        }

        static void postorder(string inorder, ref string preorder)
        {
            if (inorder.Length == 1)
            {
                Console.Write(inorder);
                preorder = preorder.Substring(1);
            }
            else if (inorder.Length != 0  && inorder.Length != 0)
            {
                int index_root = inorder.IndexOf(preorder[0]);
                preorder = preorder.Substring(1);
                postorder(inorder.Substring(0, index_root), ref preorder);
                postorder(inorder.Substring(index_root + 1), ref preorder);
                Console.Write(inorder[index_root]);
            }
        }
    }

}
