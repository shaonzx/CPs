using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPs.Solutions
{
    public class MergeStringsAlternately
    {
        public string Regular(string word1, string word2)
        {
            var carry = "";
            char[] arr1, arr2;
            int length1 = word1.Length;
            int length2 = word2.Length;
            int loopLen = 0;
            if (length1 > length2)
            {
                loopLen = length2;
                arr1 = word1.Substring(0, length2).ToCharArray();
                arr2 = word2.ToCharArray();
                carry = word1.Substring(word2.Length, length1-length2);
            }
            else if (length2 > length1)
            {
                loopLen = length1;
                arr1 = word1.ToCharArray();
                arr2 = word2.Substring(0, length1).ToCharArray();
                carry = word2.Substring(word1.Length, length2 - length1);
            }
            else
            {
                loopLen = length2;
                arr1 = word1.ToCharArray();
                arr2 = word2.ToCharArray();
            }

            StringBuilder result = new StringBuilder();
            for (int i = 0; i < loopLen; i++)
            {
                result = result.Append(arr1[i]).Append(arr2[i]);
            }
            return result.Append(carry).ToString();
        }

    }
}
