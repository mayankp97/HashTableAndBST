using System;

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
            var sentence = "To be or not to be";
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
            Console.WriteLine("Frequency of Word \"be\" is : {0}", map.Get("be"));
        }
    }
}
