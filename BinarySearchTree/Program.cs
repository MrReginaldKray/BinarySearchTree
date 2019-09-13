using System;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            CNodalPoint root = null;
            CTree tree = new CTree();

            int SIZE = 2000000;
            double[] a = new double[SIZE];

            Console.WriteLine("Generating random array with {0} values...", SIZE);

            Random random = new Random();

            Stopwatch watch = Stopwatch.StartNew();

            for (int i = 0; i < SIZE; i++)
            {
                a[i] = random.NextDouble() * 10000.00;
            }

            watch.Stop();

            Console.WriteLine("Done. Took {0} seconds\n", (double)watch.ElapsedMilliseconds / 1000.0);

            Console.WriteLine("Filling the tree with {0} nodes...", SIZE);

            watch = Stopwatch.StartNew();

            for (int i = 0; i < SIZE; i++)
            {
                root = tree.Insert(root, a[i]);
            }

            watch.Stop();

            Console.WriteLine("Done. Took {0} seconds\n", (double)watch.ElapsedMilliseconds / 1000.0);

            Console.WriteLine("Traversing all {0} nodes in tree...", SIZE);

            watch = Stopwatch.StartNew();

            tree.Traverse(root);

            watch.Stop();

            Console.WriteLine("Done. Took {0} seconds", (double)watch.ElapsedMilliseconds / 1000.0);
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
