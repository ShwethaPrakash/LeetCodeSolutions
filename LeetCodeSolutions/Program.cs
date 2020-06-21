using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 2, 5, 1, 3, 4, 7 };
            int[] mixNums = Shuffle(nums, 3);

            Console.Read();
        }

        public static int[] Shuffle(int[] nums, int n)
        {

            int[] mixnums = new int[nums.Length];
            var pivot = nums.Length / 2;

            for(int i=0,j=0;i<nums.Length;i++,j++)
            {
                if(j==pivot)
                {
                    break;
                }
                mixnums[i++] = nums[j];
                mixnums[i] = nums[j + pivot];
            }

            return mixnums;
        }
    }
}
