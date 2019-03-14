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
            int[] num = { 5, 2, 4, 6, 1, 3 };
            var p = IS.Insertion_sort(num);

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
    }
}
