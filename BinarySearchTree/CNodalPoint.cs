using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchTree
{
    class CNodalPoint
    {
        private double m_value;
        private CNodalPoint m_right;
        private CNodalPoint m_left;

        public double Value
        {
            get { return m_value; }
            set { m_value = value; }
        }

        public CNodalPoint Left
        {
            get { return m_left; }
            set { m_left = value; }
        }

        public CNodalPoint Right
        {
            get { return m_right; }
            set { m_right = value; }
        }
    }
}
