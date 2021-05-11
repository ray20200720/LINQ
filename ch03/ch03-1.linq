<Query Kind="Statements" />

/*
	Title: CH03-1 Query Syntax Style Options
	Date: 2021/3/24

*/

//Extension method format
int[] nums = new int[] {0, 4, 2, 6, 3, 8, 3, 1};

var result1 = nums.Where(n => n < 5).OrderBy(n => n);

result1.Dump();

//with line-breaks added for clarity
var result2 = nums
			.Where(n => n < 5)
			.OrderBy(n => n);
			
result2.Dump();

//Query Expression format
var result = from n in nums
			where n < 5
			orderby n
			select n;
			
result.Dump();

//Query Dot syntax
var resultWithDistinct = (from n in nums
			where n < 5
			orderby n
			select n).Distinct();
			
resultWithDistinct.Dump();