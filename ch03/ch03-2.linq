<Query Kind="Statements" />

/*
	Title:Let - Create a Local Variable
	Date: 2021/3/25
*/

//Math.Pow(n, 2) = n*n
//Math.Pow(n, 3) = n*n*n
var n = Math.Pow(2,2);
n.Dump();


int[] source = new int[] {0, 4, 2, 6, 3, 8, 3, 1};

var variance =  from element in source
				let average = source.Average()
				select Math.Pow((element - average), 2);

variance.Dump();
	
//verify
var result = Math.Pow((0-3.375),2); //(-3.375)*(-3.375) = 11.390625
result.Dump();

var variance2 = source.Select(element => new { element = element, average = source.Average() })
				.Select(temp0 => Math.Pow(((double)temp0.element - temp0.average), 2));

variance2.Dump();


	