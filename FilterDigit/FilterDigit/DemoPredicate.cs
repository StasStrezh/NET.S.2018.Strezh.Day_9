using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilterDigit
{
    /// <summary>
    /// Interface realisation
    /// </summary>
    public class DemoPredicate : IPredicate
    {
        private int digit;
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="digit"></param>
        public DemoPredicate(int digit)
        {
            if(digit < 0 || digit > 9)
            {
                throw new ArgumentNullException();
            }

            this.digit = digit;
        }

        /// <summary>
        /// Whether our number consists of specified digit or not
        /// </summary>
        /// <param name="number"></param>
        /// <returns>True if yes, else false</returns>
        bool IPredicate.Predicate(int number)
        {
            if(number < 0)
                number = -number;

            while(number > 0)
            {
                if (number % 10 == digit)
                    return true;
                number /= 10;
            }
            return false;
        }
    }
}
