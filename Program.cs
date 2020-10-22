using System;

namespace HashTableAndBST
{
    class Program
    {
        static void Main(string[] args)
        {
            //HashTableDemo();
            BinarySearchTreeDemo();
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
            Console.WriteLine("Before Removal : ");
            Console.WriteLine("Frequency of word \"avoidable\" is : {0}", map.Get("avoidable"));
            map.Remove("avoidable");
            Console.WriteLine("After Removal : ");
            Console.WriteLine("Frequency of word \"avoidable\" is : {0}", map.Get("avoidable"));
        }

        public static void BinarySearchTreeDemo()
        {
            Console.WriteLine("Welcome to BInary Search Tree Demo!");

            var bst = new BinarySearchTree<int>();
            bst.Add(56);
            bst.Add(30);
            bst.Add(70);
            bst.Display(bst.root);

        }
    }
}
