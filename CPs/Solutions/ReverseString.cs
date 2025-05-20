using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPs.Solutions
{
    public class ReverseString
    {
        public void Reverse(char[] s)
        {
            int i = 0;
            int j = s.Length - 1;
            while (i < j) 
            {
                char temp = s[i];
                s[i] = s[j];
                s[j] = temp;
                i++;
                j--;
            }
        }
    }
}
