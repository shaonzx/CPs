using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPs.Solutions
{
    public class ReverseIntegers
    {
        public int Reverse(int x)
        {
            Stack<int> numbers = new Stack<int>();
            while (x != 0)
            {
                numbers.Push(x % 10);
                x = x / 10;                
            }
            int result = 0;
            int multiplier = 1;
            var positiveOverflow = int.MaxValue / 10;
            var nagativeOverflow = int.MinValue / 10;
            while (numbers.Count() != 0)
            {                
                result = result + numbers.Pop() * multiplier;
                if (result > positiveOverflow || result < nagativeOverflow)
                {
                    return 0;
                }
                multiplier *= 10;
            }
            return result;
        }
    }
}
