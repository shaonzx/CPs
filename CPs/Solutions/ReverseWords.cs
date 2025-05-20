using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPs.Solutions
{
    public class ReverseWords
    {
        public string Reverse(string s)
        {
            string[] words = s.Split(" ");
            string[] filteredWords = words.Where(x => !string.IsNullOrWhiteSpace(x)).ToArray();
            //Array.Reverse(filteredWords);
            int i = 0;
            int j = filteredWords.Length - 1;
            while(i < j)
            {
                string temp = filteredWords[i];
                filteredWords[i] = filteredWords[j];
                filteredWords[j] = temp;
                i++;
                j--;
            }
            return string.Join(" ", filteredWords);
        }
    }
}
