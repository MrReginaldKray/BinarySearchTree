using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchTree
{
    class CTree
    {
        public CNodalPoint Insert(CNodalPoint root, double val)
        {
            if (root == null)
            {
                root = new CNodalPoint();
                root.Value = val;
            }
            else if (val < root.Value)
            {
                root.Left = Insert(root.Left, val);
            }
            else
            {
                root.Right = Insert(root.Right, val);
            }

            return root;
        }

        public void Traverse(CNodalPoint root)
        {
            if (root == null)
            {
                return;
            }

            Traverse(root.Left);
            Traverse(root.Right);
        }
    }
}
