using System;

namespace Demo.Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = new int[3];
            int[] array2 = new int[]{1,2,3};
            int[] array3 = new[] {1, 2, 3};
            int[] array4 = {1, 2, 3};
            Console.WriteLine("array2:");
            foreach (var i in array2)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            int[,] array5 = new int[4, 3];
            int[,] array6 = new int[,] {{1, 2, 3}, {1, 2, 3},{1,2,3},{1,2,3}};
            int[,] array7 = new[,] {{1, 2, 3}, {1, 2, 3}, {1, 2, 3}, {1, 2, 3}};
            int[,] array8 = {{1, 2, 3}, {1, 2, 3}, {1, 2, 3}, {1, 2, 3}};
            Console.WriteLine("array6:");
            foreach (var i in array6)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            int[,,] array9 = new int[5,4,3];
            int[,,] array10 = new int[,,]
            {
                {{1, 2, 3}, {1, 2, 3}, {1, 2, 3}, {1, 2, 3}}, 
                {{1, 2, 3}, {1, 2, 3}, {1, 2, 3}, {1, 2, 3}},
                {{1, 2, 3}, {1, 2, 3}, {1, 2, 3}, {1, 2, 3}}, 
                {{1, 2, 3}, {1, 2, 3}, {1, 2, 3}, {1, 2, 3}},
                {{1, 2, 3}, {1, 2, 3}, {1, 2, 3}, {1, 2, 3}}
            };
            int[,,] array11 = new[, ,]
            {
                {{1, 2, 3}, {1, 2, 3}, {1, 2, 3}, {1, 2, 3}},
                {{1, 2, 3}, {1, 2, 3}, {1, 2, 3}, {1, 2, 3}},
                {{1, 2, 3}, {1, 2, 3}, {1, 2, 3}, {1, 2, 3}},
                {{1, 2, 3}, {1, 2, 3}, {1, 2, 3}, {1, 2, 3}},
                {{1, 2, 3}, {1, 2, 3}, {1, 2, 3}, {1, 2, 3}}
            };
            int[,,] array12 =
            {
                {{1, 2, 3}, {1, 2, 3}, {1, 2, 3}, {1, 2, 3}},
                {{1, 2, 3}, {1, 2, 3}, {1, 2, 3}, {1, 2, 3}},
                {{1, 2, 3}, {1, 2, 3}, {1, 2, 3}, {1, 2, 3}},
                {{1, 2, 3}, {1, 2, 3}, {1, 2, 3}, {1, 2, 3}},
                {{1, 2, 3}, {1, 2, 3}, {1, 2, 3}, {1, 2, 3}}
            };
            Console.WriteLine("array10:");
            foreach (var i in array10)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
