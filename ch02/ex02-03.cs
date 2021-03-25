/*
	Title: 集合初始化設定
	Date: 2021/3/23
*/

void Main()
{
	// old initialization syntax => multiple statements
	List<string> stringsOld = new List<string>();
	stringsOld.Add("string 1");
	stringsOld.Add("string 2");

	foreach (var item in stringsOld)
	{
		Console.WriteLine("{0}", item);
	}
	
	// new initialization syntax => single statement
	List<string> stringsNew = new List<string> 
	{
		"new string 1",
		"new string 2"
	};

	foreach (var item in stringsNew)
	{
		Console.WriteLine("{0}", item);
	}

	// combining object and collection initialization
	// create a list of contacts and add two records. 
	List<Contact> list = new List<Contact>
	{
		new Contact 
		{
			LastName = "Magennis",
			DateOfBirth = new DateTime(1973, 12, 09)
		},
		new Contact 
		{
			LastName = "Doherty",
			DateOfBirth = new DateTime(1978, 1, 05)
		}
	};

	foreach (var item in list)
	{
		Console.WriteLine("{0} ({1})", item.LastName, item.DateOfBirth);
	}
}

class Contact
{
	public string LastName { get; set; }
	public DateTime DateOfBirth { get; set; }
}
