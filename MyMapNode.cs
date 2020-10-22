﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HashTableAndBST
{
    public class MyMapNode<K,V>
    {
        private readonly int size;
        private readonly LinkedList<KeyValue<K, V>>[] items;
        public MyMapNode(int size)
        {
            this.size = size;
            this.items = new LinkedList<KeyValue<K, V>>[size];
        }

        public void Add(K key, V value)
        {
            int position = GetArrayPosition(key);
            var linkedList = GetLinkedList(position);
            var item = new KeyValue<K, V>() { Key = key, Value = value };
            linkedList.AddLast(item);
        }
        public V Get(K key)
        {
            int position = GetArrayPosition(key);
            var linkedList = GetLinkedList(position);
            foreach (var item in linkedList)
            {
                if (item.Key.Equals(key))
                {
                    return item.Value;
                }
            }
            return default(V);
        }

        public void Set(K key, V value)
        {
            int position = GetArrayPosition(key);
            var linkedList = GetLinkedList(position);
            KeyValue<K, V> temp = new KeyValue<K, V>();
            foreach (var item in linkedList)
                if (item.Key.Equals(key))
                {
                    temp = item;
                    
                }
            temp.Value = value;

        }
        public void Remove(K key)
        {
            int position = GetArrayPosition(key);
            var linkedList = GetLinkedList(position);
            bool itemFound = false;
            var foundItem = default(KeyValue<K, V>);
            foreach (var item in linkedList)
            {
                if (item.Key.Equals(key))
                {
                    itemFound = true;
                    foundItem = item;
                }
            }
            if (itemFound)
            {
                linkedList.Remove(foundItem);
            }
        }

        protected int GetArrayPosition(K key)
        {
            var position = key.GetHashCode() % size;
            return Math.Abs(position);
        }
        protected LinkedList<KeyValue<K, V>> GetLinkedList(int position)
        {
            var linkedList = items[position];
            if (linkedList == null)
            {
                linkedList = new LinkedList<KeyValue<K, V>>();
                items[position] = linkedList;
            }
            return linkedList;
        }
    }
    public class KeyValue<K, V>
    {
        public K Key { get; set; }
        public V Value { get; set; }
    }
}
