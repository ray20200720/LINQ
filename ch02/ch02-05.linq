<Query Kind="Program" />

/* 	
	Title: Anonymous Types
	Date: 2021/3/23
*/

void Main()
{
	// simple anonymous type declaration
	Console.WriteLine("- Simple Anonymous Type -");	
	var item = new { Name = "Car", Price = 9989.00 };
	
	Console.WriteLine("Type: {0}, Name: {1}, Price: {2}", item.GetType().ToString(), item.Name, item.Price);	
	
	// declaring and working with array of anonymous types
	Console.WriteLine();
	Console.WriteLine("- Iterating Anonymous Type Array -");
	var list = new [] {
		new { 	LastName = "Magennis",
				DateOfBirth = new DateTime(1973, 12, 09)
		}, 
		new {	LastName = "Doherty",
				DateOfBirth = new DateTime(1978, 1, 05)
		}
	};
	
	foreach (var x in list) {
		Console.WriteLine("{0}  ({1})", x.LastName, x.DateOfBirth);
	}

	// compiler optimization - from the C# specification:
	// within the same program, two anonymous object
	// initializers that specify a sequence of properties of
	// the same names and compile-time types in the same order
	// will produce instances of the same anonymous type.
	var p1 = new { Name = "Lawnmower", Price = 495.00 };
	var p2 = new { Name = "Shovel", Price = 26.95 };
	Console.WriteLine("{0} {1} {2}", p1, p2, p1 == p2);
	
	p1 = p2;  // valid: the same anonymous type.
	Console.WriteLine("{0} {1} {2}", p1, p2, p1 == p2);
}

class Contact
{
	public string LastName { get; set; }
	public DateTime DateOfBirth { get; set; }
}
