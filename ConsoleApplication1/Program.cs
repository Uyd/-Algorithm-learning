using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            var IS = new Seqencing();
            int[] number = { 5, 2, 4, 6, 1, 3 };
            //var p = IS.Insertion_sort(number);//插入
            var p = IS.Bubble_sort(number);//冒泡
            //输出
            foreach (var r in p)
            {
                Console.Write(r + " ");
            }
            Console.ReadKey();
        }
    }

    /// <summary>
    /// 排序算法
    /// </summary>
    public class Seqencing
    {
        /// <summary>
        /// 插入排序
        /// </summary>
        public int[] Insertion_sort(int[] n)
        {
            var j = 0;
            for (var i = 1; i < 6; i++)
            {
                int key = n[i];
                j = i - 1;
                while (j >= 0 && n[j] > key)
                {
                    n[j + 1] = n[j];
                    j = j - 1;
                }
                n[j + 1] = key;
            }
            return n;
        }

        /// <summary>
        /// 冒泡排序
        /// </summary>
        public int[] Bubble_sort(int[] n)
        {
            for (int pass = n.Length; pass >= 0; pass--)
            {
                for (int i = 0; i < pass - 1; i++)
                {
                    if (n[i] > n[i + 1])
                    {
                        //交换元素
                        int temp = n[i];
                        n[i] = n[i + 1];
                        n[i + 1] = temp;
                    }
                }
            }
            return n;
        }

        //增加一个标记来改进该算法，排序过程中，没有进行交换操作则排序完成，结束算法
        //int swapped = 1;
        //    for (int pass = n.Length; pass >= 0 && swapped == 1; pass--)
        //    {
        //        swapped = 0;
        //        for (int i = 0; i < pass - 1; i++)
        //        {
        //            if (n[i] > n[i + 1])
        //            {
        //                //交换元素
        //                int temp = n[i];
        //                n[i] = n[i + 1];
        //                n[i + 1] = temp;
        //                swapped = 1;
        //            }
                    
        //        }
        //    }
        //    return n;
        //}
    }
}
