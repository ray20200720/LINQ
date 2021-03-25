/* 	
	Title: 物件初始化設定
	Date: 2021/3/23
*/

void Main()
{
	// old initialization syntax => multiple statements
	Contact contactOld = new Contact();
	contactOld.LastName = "Magennis";
	contactOld.DateOfBirth = new DateTime(1973, 12, 09);
	Console.WriteLine("{0}  ({1})", contactOld.LastName, contactOld.DateOfBirth);
	
	// new initialization syntax => single statement
	Contact contactNew = new Contact 
	{
		LastName = "Magennis",
		DateOfBirth = new DateTime(1973, 12, 09)
	};
	Console.WriteLine("{0}  ({1})", contactNew.LastName, contactNew.DateOfBirth);
}

class Contact
{
	public string LastName { get; set; }
	public DateTime DateOfBirth { get; set; }
}