using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HashTableAndBST
{
    class BinarySearchTree<T> where T : IComparable
    {
        public MyBinaryNode<T> root;

        public MyBinaryNode<T> Parent;


        public BinarySearchTree()
        {
            root = null;
            Parent = null;
        }

        public void Add(T data)
        {
            if(root == null)
            {
                root = new MyBinaryNode<T>(data);
            }
            else
            {
                var node = new MyBinaryNode<T>(data);
                var temp = Parent;
                if (data.CompareTo(Parent.data) < 0)
                {
                    if (temp.leftChild == null)
                        temp.leftChild = node;
                    else
                    {
                        Parent = temp.leftChild;
                        Add(data);
                    }
                }
                else
                {
                    if (temp.RightChild == null)
                        temp.RightChild = node;
                    else
                    {
                        Parent = temp.RightChild;
                        Add(data);
                    }
                }
            }
            Parent = root;
        }
        public int Size()
        {
            var temp = root;
            var maxSize = 0;
            var stk = new Stack<MyBinaryNode<T>>();
            

            while(temp != null || stk.Count != 0)
            {
                var size = 0;
                while(temp != null)
                {
                    stk.Push(temp);
                    temp = temp.leftChild;
                    size++;
                }
                temp = stk.Pop();
                
                temp = temp.RightChild;
                maxSize = maxSize < size ? size : maxSize;

            }
            return maxSize-1;
        }

        public void Search(T data)
        {
            if (Parent.data.CompareTo(data) == 0)
            {
                Console.WriteLine("Found");
                return;
            }
            if(Parent.data.CompareTo(data) < 0)
            {
                Parent = Parent.RightChild;
                Search(data);
                
            }
            else
            {
                Parent = Parent.leftChild;
                Search(data);
            }
        }
        public void Display(MyBinaryNode<T> parent)
        {
            Console.WriteLine("Parent : {0}", parent.data);
            if (parent.leftChild != null)
            {
                Console.WriteLine("Left :" + parent.leftChild.data);
            }
            if (parent.RightChild != null)
                Console.WriteLine("Right :" + parent.RightChild.data);
            if (parent.leftChild != null)
            {
                Display(parent.leftChild);
            }
            if (parent.RightChild != null)
            {
                Display(parent.RightChild);
            }
        }
    }
}
