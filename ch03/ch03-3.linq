<Query Kind="Statements" />

/*
	Title:Into - Query Continuation
	Date: 2021/3/25
*/

int[] source = new int[] {0, 4, 2, 6, 3, 8, 3, 1};
var groupings = from element in source
				group element by element into groups
				select new {
					Key = groups.Key,
					Count = groups.Count()
				};

groupings.Dump();
