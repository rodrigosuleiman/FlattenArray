using System;
using System.Collections;
using System.Collections.Generic;

namespace CitrusByte
{
    public static class FlattenArrayTest
    {
        /// <summary>
        //Arrays of integers into a flat array of integers.e.g. [[1, 2,[3]],4] -> [1,2,3,4]. 
        /// </summary>
        public static int[] Flatten(ArrayList arr)
        {
            List<int> result = new List<int>();
            try
            {
                Recursive(arr, ref result);
            }
            catch
            {
                result.Clear();
            }
            return result.ToArray();
        }

        /// <summary>
        /// Recursive method to flatten
        /// </summary>
        private static void Recursive(ArrayList arr, ref List<int> ret)
        {
            if (ret == null)
            {
                ret = new List<int>();
            }

            for (int i = 0; i < arr.Count; ++i)
            {
                if (arr[i] is ArrayList)
                {
                    Recursive(arr[i] as ArrayList, ref ret);
                }
                else if (arr[i] is int)
                {
                    ret.Add((int)arr[i]);
                }
                else
                {
                    throw new Exception("Cannot be flatten");
                }
            }
        }
    }
}
