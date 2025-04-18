using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPs.Solutions
{
    internal class GreatestCommonDivisorOfStrings
    {
        public string GcdOfStrings(string str1, string str2)
        {
            if (str1.Length == str2.Length)
            {
                if (str1.Equals(str2))
                {
                    return str1;
                }
                return "";
            }

            string devisor = "", devident = "";
            if (str1.Length > str2.Length)
            {
                devident = str1;
                devisor = str2;
            }
            else
            {
                devident = str2;
                devisor = str1;
            }

            int gcdLen = GcdLength(devident.Length, devisor.Length);

            var possibleGcd = devisor.Substring(0, gcdLen);

            if (string.IsNullOrEmpty(str1.Replace(possibleGcd, "")) && string.IsNullOrEmpty(str2.Replace(possibleGcd, "")))
            {
                return possibleGcd;
            }

            return "";
        }

        private int GcdLength(int devidentLength, int devisorLength)
        {
            while (devisorLength > 0)
            {
                int temp = devisorLength;
                devisorLength = devidentLength % devisorLength;
                devidentLength = temp;
            }
            return devidentLength;
        }
    }
}
