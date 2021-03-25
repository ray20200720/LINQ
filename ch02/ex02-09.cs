/* 	
	Title: Simple LINQ query over an array of integers—see Output 2-3
	Date: 2021/3/23
*/

void Main()
{
	int[] nums = new int[] { 0, 4, 2, 6, 3, 8, 3, 1 };

	var result = from n in nums
					where n < 5
					orderby n
					select n;
	foreach (int i in result)
	{
		Console.WriteLine(i);	
	}					
	
}

