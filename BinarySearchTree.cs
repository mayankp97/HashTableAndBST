﻿using System;
using System.Collections.Generic;
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
                if (data.CompareTo(root.data) < 0)
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
