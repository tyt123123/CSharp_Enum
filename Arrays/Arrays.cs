using System;

namespace Arrays
{
    internal class Arrays

    {
        public static void Main(string[] args)
        {
            int[] arr = new int[5];
            int[] arr2;
            int[] arr3 = new int[5] { 1, 2, 3, 4, 5 };
            int[] arr4 = new int[] { 1, 2, 3, 4, };
            int[] arr5 = { 1, 2, 3, 4 };
            int length = arr.Length;
            int elementCount = arr3[1];
            arr3[0] = arr4[3];
            foreach (var VARIABLE in args)
            {
                Console.WriteLine(VARIABLE);
            }

            int[,] Array = new int[1, 1];
            int[,] Array2;
            int[,] Array3 = { { 1, 2, 3, 4 } };
            int[,] Array4 = new int[2, 2] { { 1, 2 }, { 1, 2 } };
            //交错数组,数组的数组
            
            int[][] ARRAY = new int[2][];
            int[][] ARRAY2 = new int[2][] { 
                new int[] { 1, 2 }, 
                new int[] { 1, 2, 3 } };
            //数组初始化后不能直接添加元素，不能直接删除数组，
            Con();
        }

       static void Con()
        {
            Console.WriteLine("函数");
        }
    }
}