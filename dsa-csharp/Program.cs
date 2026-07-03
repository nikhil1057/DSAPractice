// DSA Practice - C#

int[] TwoSum(int[] nums, int target)
{
    var seen = new Dictionary<int, int>();
    for (int i = 0; i < nums.Length; i++)
    {
        int complement = target - nums[i];
        if (seen.TryGetValue(complement, out int index))
            return [index, i];
        seen[nums[i]] = i;
    }
    return [];
}

var result = TwoSum([2, 7, 11, 15], 9);
Console.WriteLine($"[{string.Join(", ", result)}]");
