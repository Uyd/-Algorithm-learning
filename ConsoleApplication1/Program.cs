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
            var one = new Insertion_sort();
            int[] num = { 5, 2, 4, 6, 1, 3 };
            var p = one.test(num);

            //输出
            foreach (var r in p)
            {
                Console.Write(r + " ");
            }
            Console.ReadKey();
        }
    }

    /// <summary>
    /// 插入排序
    /// </summary>
    public class Insertion_sort
    {
        public int[] test(int[] n)
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
