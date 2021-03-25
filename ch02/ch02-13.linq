<Query Kind="Program" />

void Main()
{
	List<Contact> contacts = Contact.SampleData();
	List<CallLog> callLog = CallLog.SampleData();
	
	var q = from call in callLog
		where call.Incoming == true
		group call by call.Number into g
		join contact in contacts on g.Key equals contact.Phone
		orderby contact.FirstName, contact.LastName
		select new { contact.FirstName, contact.LastName, Count = g.Count(), Avg = g.Average(c => c.Duration), Total = g.Sum(c => c.Duration) };
	
	
	foreach(var call in q)
	{
		Console.WriteLine("{0} {1} - Calls: {2}, Time:{3} mins, Avg:{4} mins", call.FirstName, call.LastName, call.Count, call.Total, Math.Round(call.Avg, 2));
	}
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
	
	public static List<CallLog> SampleData()
	{
		return new List<CallLog>
		{ 
			new CallLog
			{
				Number = "885 983 8858",
				Duration = 2,
				Incoming = true,
				When = new DateTime(2006, 8, 07, 8, 12, 00)
			}, 
			new CallLog
			{
				Number = "165 737 1656",
				Duration = 15,
				Incoming = true,
				When = new DateTime(2006, 8, 07, 9, 23, 00)
			},
			new CallLog
			{
				Number = "364 202 3644",
				Duration = 1,
				Incoming = false,
				When = new DateTime(2006, 8, 07, 10, 05, 00)
			},
			new CallLog
			{
				Number = "603 303 6030",
				Duration = 2,
				Incoming = false,
				When = new DateTime(2006, 8, 07, 10, 35, 00)
			},
			new CallLog
			{
				Number = "546 607 5462",
				Duration = 4,
				Incoming = true,
				When = new DateTime(2006, 8, 07, 11, 15, 00)
			},
			new CallLog
			{
				Number = "885 983 8858",
				Duration = 15,
				Incoming = false,
				When = new DateTime(2006, 8, 07, 13, 12, 00)
			},
			new CallLog
			{
				Number = "885 983 8858",
				Duration = 3,
				Incoming = true,
				When = new DateTime(2006, 8, 07, 13, 47, 00)
			},
			new CallLog
			{
				Number = "546 607 5462",
				Duration = 1,
				Incoming = false,
				When = new DateTime(2006, 8, 07, 20, 34, 00)
			},
			new CallLog
			{
				Number = "546 607 5462",
				Duration = 3,
				Incoming = false,
				When = new DateTime(2006, 8, 08, 10, 10, 00)
			},
			new CallLog
			{
				Number = "603 303 6030",
				Duration = 23,
				Incoming = false,
				When = new DateTime(2006, 8, 08, 10, 40, 00)
			},
			new CallLog
			{
				Number = "848 553 8487",
				Duration = 3,
				Incoming = false,
				When = new DateTime(2006, 8, 08, 14, 00, 00)
			},
			new CallLog
			{
				Number = "848 553 8487",
				Duration = 7,
				Incoming = true,
				When = new DateTime(2006, 8, 08, 14, 37, 00)
			},
			new CallLog
			{
				Number = "278 918 2789",
				Duration = 6,
				Incoming = true,
				When = new DateTime(2006, 8, 08, 15, 23, 00)
			},
			new CallLog
			{
				Number = "364 202 3644",
				Duration = 20,
				Incoming = true,
				When = new DateTime(2006, 8, 08, 17, 12, 00)
			}
		};
	}
}
