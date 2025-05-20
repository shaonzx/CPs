using CPs.Solutions;


#region Two Sum

/*var nums = new[] { 7, 2, 11, 15 };
int target = 9;
TwoSum ts = new TwoSum();
var result = ts.Optimized(nums, target);
foreach (int i in result)
{
    Console.WriteLine(i);
}*/

#endregion

#region Merge Strings Alternately

/*string word1 = "ab", word2 = "pqrs";
var result = new MergeStringsAlternately().Regular(word1, word2);
Console.WriteLine(result);*/

#endregion

#region Greatest Common Divisor of Strings

/*string word1 = "ABCDEF", word2 = "ABC";
var result = new GreatestCommonDivisorOfStrings().GcdOfStrings(word1, word2);
Console.WriteLine(result);*/

#endregion

#region Reverse String

/*char[] s = ['h', 'e', 'l', 'l', 'o'];
new ReverseString().Reverse(s);*/

#endregion

#region reverse words

/*string revStr = "  hello world  ";
var result = new ReverseWords().Reverse(revStr);
Console.WriteLine(result);*/

#endregion

#region reverse integers (Unsolved)

int x = -1234;
var result = new ReverseIntegers().Reverse(x);
Console.WriteLine(result);

#endregion



Console.ReadKey();
