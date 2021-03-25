<Query Kind="Program" />

void Main()
{
	List<Contact> contacts = Contact.SampleData();
	var q = from c in contacts
			where c.DateOfBirth.AddYears(55) > DateTime.Now
			orderby c.DateOfBirth descending
			select string.Format("{0} {1} b.{2}", c.FirstName, c.LastName, c.DateOfBirth.ToString("dd-MMM-yyyy"));
	
	foreach (string s in q)
		Console.WriteLine(s);
}

public class Contact
{
	public string FirstName { get; set; }
	public string LastName { get; set; }
	public string Email { get; set; }
	public string Phone { get; set; }
	public DateTime DateOfBirth { get; set; }
	public string State { get; set; }
	
	public static List<Contact> SampleData()
	{
		return new List<Contact>
		{
			new Contact 
			{ 
				FirstName = "Barney",
				LastName = "Gottshall",
				DateOfBirth = new DateTime(1945, 10, 19),
				Phone = "885 983 8858",
				State = "CA"
			}, 
			new Contact 
			{
				FirstName = "Armando",
				LastName = "Valdes",
				DateOfBirth = new DateTime(1973, 12, 09),
				Phone = "848 553 8487",
				State = "WA"
			},
			new Contact 
			{
				FirstName = "Adam",
				LastName = "Gauwain",
				DateOfBirth = new DateTime(1959, 10, 03),
				Phone = "115 999 1154",
				State = "AK"
			},
			new Contact 
			{
				FirstName = "Jeffery",
				LastName = "Deane",
				DateOfBirth = new DateTime(1950, 12, 16),
				Phone = "677 602 6774",
				State = "CA"
			},
			new Contact 
			{
				FirstName = "Collin",
				LastName = "Zeeman",
				DateOfBirth = new DateTime(1935, 2, 10),
				Phone = "603 303 6030",
				State = "FL"
			},
			new Contact 
			{
				FirstName = "Stewart",
				LastName = "Kagel",
				DateOfBirth = new DateTime(1950, 2, 20),
				Phone = "546 607 5462",
				State = "WA"
			},
			new Contact 
			{
				FirstName = "Chance",
				LastName = "Lard",
				DateOfBirth = new DateTime(1951, 10, 21),
				Phone = "278 918 2789",
				State = "WA"
			},
			new Contact 
			{
				FirstName = "Blaine",
				LastName = "Reifsteck",
				DateOfBirth = new DateTime(1946, 5, 18),
				Phone = "715 920 7157",
				State = "TX"
			},
			new Contact 
			{
				FirstName = "Mack",
				LastName = "Kamph",
				DateOfBirth = new DateTime(1977, 9, 17),
				Phone = "364 202 3644",
				State = "TX"
			},
			new Contact 
			{
				FirstName = "Ariel",
				LastName = "Hazelgrove",
				DateOfBirth = new DateTime(1922, 5, 23),
				Phone = "165 737 1656",
				State = "OR"
			}
		};
	}
}

public class CallLog
{
	public string Number { get; set; }
	public int Duration { get; set; }
	public bool Incoming { get; set; }
	public DateTime When { get; set; }
}
