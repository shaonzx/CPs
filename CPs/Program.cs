using CPs.Solutions;


#region Two Sum

/*var nums = new [] { 2, 7, 11, 15};
int target = 9;
TwoSum ts = new TwoSum();
var result = ts.Optimized(nums, target);
foreach (int i in result)
{
    Console.WriteLine(i);
}*/

#endregion

#region Merge Strings Alternately

string word1 = "ab", word2 = "pqrs";
var result = new MergeStringsAlternately().Regular(word1, word2);
Console.WriteLine(result);

#endregion

Console.ReadKey();
