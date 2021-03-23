void Main()
{
	Console.WriteLine("- Simple Anonymous Type -");	
	var item = new { Name = "Car", Price = 9989.00 };
	
	Console.WriteLine("Type: {0}, Name: {1}, Price: {2}", item.GetType().ToString(), item.Name, item.Price);	
	
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
}

// Define other methods and classes here
