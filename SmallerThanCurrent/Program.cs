using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallerThanCurrent
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 8, 1, 2, 2, 3 };

            int[] output = SmallerNumbersThanCurrent(nums);
        }

        public static int[] SmallerNumbersThanCurrent(int[] nums)
        {
            List<int> array = nums.ToList();
            array.Sort();

            int[] output = new int[nums.Length];

            for (int i=0;i<nums.Length;i++)
            {
                output[i] = array.IndexOf(nums[i]);
            }

            return output;
            
        }

        
    }   
}
