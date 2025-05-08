char selection = '0';
while (selection != 'q')
{
    Console.WriteLine("1. Given a non-empty array of integers nums, every element appears twice except for one. Find that single one.\n2. Given an array nums containing n distinct numbers in the range [0, n], return the only number in the range that is missing from the array.\nq: quit");
    Console.Write("Selection: ");
    selection = Console.ReadKey().KeyChar;
    Console.Clear();
    switch (selection)
    {
        case '1':
            Console.WriteLine("1. Given a non-empty array of integers nums, every element appears twice except for one. Find that single one.\n\nExample 1:\nInput: nums = [2,2,1]\nOutput: 1\n\nExample 2:\nInput: nums = [4,1,2,1,2]\nOutput: 4\n\nExample 3:\nInput: nums = [1]\nOutput: 1\n\n");
            Demo1([2, 2, 1]);
            Demo1([4, 1, 2, 1, 2]);
            Demo1([1]);
            Demo1([1,1,2,2,3,3,4,4,5,5,6,6,7,7,8,8,9,9,10,11,11]);
            Console.ReadKey();
            Console.Clear();
            break;
        case '2':
            Console.WriteLine("2. Given an array nums containing n distinct numbers in the range [0, n], return the only number in the range that is missing from the array.\n\nExample 1:\nInput: nums = [3,0,1]\nOutput: 2\nExplanation: n = 3 since there are 3 numbers, so all numbers are in the range [0,3]. 2 is the missing number in the range since it does not appear in nums.\n\nExample 2:\nInput: nums = [0,1]\nOutput: 2\nExplanation: n = 2 since there are 2 numbers, so all numbers are in the range [0,2]. 2 is the missing number in the range since it does not appear in nums.\n\nExample 3:\nInput: nums = [9,6,4,2,3,5,7,0,1]\nOutput: 8\nExplanation: n = 9 since there are 9 numbers, so all numbers are in the range [0,9]. 8 is the missing number in the range since it does not appear in nums.\n\n");
            Demo2([3, 0, 1]);
            Demo2([0, 1]);
            Demo2([9, 6, 4, 2, 3, 5, 7, 0, 1]);
            Demo2([0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 13, 14, 15, 16, 17, 18, 19, 20, 21]);
            Console.ReadKey();
            Console.Clear();
            break;
    }
}
void Demo1(int[] nums)
{
    Console.WriteLine($"Input: nums = [{string.Join(", ",nums)}]");
    Console.WriteLine($"Output: {FindLonelyNumber(nums)}");
    Console.WriteLine();
}
int FindLonelyNumber(int[] nums)
{
    // sort, then use binary search
    // in sorted arrays, twin elements are found at indices 2n and 2n+1
    // if 2n and 2n+1 hold different values, then lonely number is to the left
    // if 2n and 2n+1 hold the same values, then lonely number is to the right
    if (nums.Length == 1) {  return nums[0]; }

    Array.Sort(nums);
    int leftN = 0;
    if (nums[2*leftN] != nums[2*leftN + 1]) { return nums[2*leftN]; }
    int rightN = (nums.Length - 3)/2;
    if (nums[2*rightN]==nums[2*rightN + 1]) { return nums[2*rightN+2]; }

    while( leftN+1 < rightN )
    {
        int cursorN = (leftN + rightN) / 2;
        if (nums[2*cursorN] == nums[2*cursorN + 1]) { leftN = cursorN; }
        else { rightN = cursorN; }
    }
    return nums[2*rightN];
}

void Demo2(int[] nums)
{
    Console.WriteLine($"Input: nums = [{string.Join(", ", nums)}]");
    Console.WriteLine($"Output: {FindMissingNumber(nums)}");
    Console.WriteLine();
}

int FindMissingNumber(int[] nums)
{
    // sort, then binary search
    // if index==nums[index], then missing number is to right
    // if index!=nums[index], then missing number is to left
    Array.Sort(nums);

    if (nums[0] != 0) { return 0; }
    int left = 0;
    if (nums[nums.Length - 1] != nums.Length) { return nums.Length; }
    int right = nums.Length - 1;
    int cursor = (left + right) / 2;

    while (left+1 < right)
    {
        cursor = (left + right) / 2;
        if (nums[cursor] == cursor) { left = cursor; }
        else { right = cursor; }
    }
    return cursor+1;
}