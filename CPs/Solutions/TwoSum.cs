namespace CPs.Solutions
{
    public class TwoSum
    {
        public int[] Regular(int[] nums, int target)
        {
            if (nums.Length == 2) return new []{0,1};

            for (int i = 0; i < nums.Length-1; i++)
            {
                var remaining = target - nums[i];
                for (int j = i+1; j < nums.Length; j++)
                {
                    if (nums[j] == remaining)
                    {
                        return new[] { i, j };
                    }
                }
            }

            return nums;
        }

        public int[] Optimized(int[] nums, int target)
        {
            if (nums.Length == 2) return new[] { 0, 1 };

            /*
             * here value is the key, and index is the value
             * in order to avoid firstOrDefault and ContainsValue (O(n) operations).
             * Instead we should use ContainsKey (O(n) operation)
             */
            Dictionary<int, int> maps = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int remaining = target - nums[i];

                if (maps.ContainsKey(remaining))
                {
                    return new[] { i, maps[remaining] };
                }

                if (!maps.ContainsKey(nums[i]))
                {
                    maps.Add(nums[i], i);
                }
            }
            return nums;
        }
    }
}
