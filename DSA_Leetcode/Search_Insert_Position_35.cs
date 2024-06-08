namespace DSA_Leetcode
{
    internal class Search_Insert_Position_35
    {
        // https://leetcode.com/problems/search-insert-position/description/
        //Given a sorted array of distinct integers and a target value, return the index if the target is found.If not, return the index where it would be if it were inserted in order.
        //You must write an algorithm with O(log n) runtime complexity.

        public static int SearchInsert(int[] nums, int target)
        {
            if (target < nums[0])
                return 0;

            if (target > nums[^1])
                return nums.Length;

            int oldId = -3;

            for (int i = 0; i < nums.Length; i++)
            {
                int arrVal = nums[i];
                if (target >= arrVal)
                {
                    if (target == arrVal)
                    {
                        return i;
                    }

                    oldId = i;
                }
                else
                {
                    oldId++;
                    break;
                }
            }

            return oldId;
        }
    }
}
