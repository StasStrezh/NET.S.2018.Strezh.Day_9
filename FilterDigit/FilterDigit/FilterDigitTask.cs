using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilterDigit
{
    /// <summary>
    /// Filter class
    /// </summary>
    class FilterDigitTask
    {
        /// <summary>
        /// Method that gets array, filter it and return new array of filtered symbols
        /// </summary>
        /// <param name="array"></param>
        /// <param name="predicate"></param>
        /// <returns>Filtered array</returns>
        public static int[] FilterDigit(int[] array, IPredicate predicate)
        {
            if(array is null)
            {
                throw new ArgumentNullException();
            }
            if(predicate is null)
            {
                throw new ArgumentNullException();
            }

            List<int> buff = new List<int>();
            for(int i = 0; i<array.Length; i++)
            {
                if(predicate.Predicate(array[i]))
                {
                    buff.Add(array[i]);
                }
            }
            return buff.ToArray<int>();
        }
    }
}
