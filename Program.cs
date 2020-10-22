﻿using System;

namespace HashTableAndBST
{
    class Program
    {
        static void Main(string[] args)
        {
            HashTableDemo();
        }

        public static void HashTableDemo()
        {
            Console.WriteLine("Welcome to Hash Table Demo");
            var sentence = "Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations";
            string[] words = sentence.Split(' ');
            var map = new MyMapNode<string, int>(10);
            foreach(var word in words)
            {
                if (map.Get(word) == 0)
                    map.Add(word, 1);
                else
                {
                    var freq = map.Get(word) + 1;
                    map.Set(word, freq);
                }
            }
            Console.WriteLine("Frequency of Word \"paranoid\" is : {0}", map.Get("paranoid"));
        }
    }
}
