namespace Desktop.Permutations
{
    public class Program
    {
        public static void Main()
	{
		int[] nums = new int[3] {10,20,30};
		int i = nums.Length;
		permutations(nums, 0, i-1);
	}
	public static void permutations(int [] nums, int i, int j)
	{	
		
		if(i == j)
		{
		  Console.WriteLine();
			Console.Write("[");
		  for (int k= 0; k < nums.Length; k++)
       	 	{
            Console.Write(nums[k]);
            if (k < nums.Length - 1) 
			{
                Console.Write(",");
            }
			
		  }
			Console.Write("]");	
		}
		else
		{
			for (int x= i; x<= j; x++)
			{
				nums = swap(nums, i, x);
				permutations(nums, i+1 ,j);
				nums = swap(nums, i, x);
			}
		}
	
		
	
	
	}
	public static int [] swap(int [] nums, int i, int j)
		{	
			if (i == j) {return nums;}
			else
			{
				int temp = nums[i];
				nums[i] = nums[j];
				nums[j] = temp;
				return nums;
			}
			
		}
    }
}