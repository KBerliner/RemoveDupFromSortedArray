public class Solution{
    public int[] Solve(int[] nums)
    {
        List<int> newArray = [];

        foreach (int i in nums)
        {
            if (!newArray.Contains(i))
            {
                newArray.Add(i);
            }
        }

        return [.. newArray];
    }
}
