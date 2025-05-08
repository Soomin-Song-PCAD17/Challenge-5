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
            Console.WriteLine("1. Given a non-empty array of integers nums, every element appears twice except for one. Find that single one.\n\nExample 1:\n\nInput: nums = [2,2,1]\n\nOutput: 1\n\nExample 2:\n\nInput: nums = [4,1,2,1,2]\n\nOutput: 4\n\nExample 3:\n\nInput: nums = [1]\n\nOutput: 1");
            Demo1();
            break;
        case '2':
            Console.WriteLine("2. Given an array nums containing n distinct numbers in the range [0, n], return the only number in the range that is missing from the array.\n\nExample 1:\n\nInput: nums = [3,0,1]\n\nOutput: 2\n\nExplanation: n = 3 since there are 3 numbers, so all numbers are in the range [0,3]. 2 is the missing number in the range since it does not appear in nums.\n\nExample 2:\n\nInput: nums = [0,1]\n\nOutput: 2\n\nExplanation: n = 2 since there are 2 numbers, so all numbers are in the range [0,2]. 2 is the missing number in the range since it does not appear in nums.\n\nExample 3:\n\nInput: nums = [9,6,4,2,3,5,7,0,1]\n\nOutput: 8\n\nExplanation: n = 9 since there are 9 numbers, so all numbers are in the range [0,9]. 8 is the missing number in the range since it does not appear in nums.");
            Demo2();
            break;
    }
}
void Demo1()
{
    Console.ReadKey();
    Console.Clear();
}
void Demo2()
{
    Console.ReadKey();
    Console.Clear();
}