using System;
using System.Collections.Generic;
using System.Text;

namespace HashTableAndBST
{
    public class MyBinaryNode<T> where T : IComparable
    {
        public T data;
        public MyBinaryNode<T> leftChild;
        public MyBinaryNode<T> RightChild;

        public MyBinaryNode(T data)
        {
            this.data = data;
            leftChild = null;
            RightChild = null;
        }
    }
}
