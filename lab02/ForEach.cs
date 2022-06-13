using System;

namespace lab02
{
    class ForEach
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now;
            Random rand = new Random((int)now.Millisecond);
            int[] Arr = new int[10];
            for ( int i = 0; i < Arr.Length; ++i)
            {
                Arr[i] = rand.Next() % 100;
            }
            int Total = 0;
            Console.Write("Array values are ");
            foreach ( int val in Arr)
                {
                Total += val;
                Console.Write(val + " ");
            }
            Console.WriteLine("\nAnd the average is {0,0:F1}", (double)Total / (double)Arr.Length);
            Console.ReadLine();
        }
    }
}
