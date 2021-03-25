/* 	
	Title: Implicitly Typed Local Variables
	Date: 2021/3/23
*/

void Main()
{
	// implicitly typed local variable declarations 
	// 隱含類別區域變數宣告
	var anInt = 1;
	var aString = "Testing";
	var listContact = new List<Contact>();
	var intArray = new int[] { 0, 1, 2, 3, 4 };

	Console.WriteLine("{0} {1} {2} {3}", anInt, aString, listContact, intArray);

	// the above are identical to the following declarations
	// 下列為上述已辨識的型別宣告
	int anIntOld = 1;
	string aStringOld = "Testing";
	List<Contact> listContactOld = new List<Contact>(); 
	int[] intArrayOld = new int[] { 0, 1, 2, 3, 4 };

	Console.WriteLine("{0} {1} {2} {3}", anIntOld, aStringOld, listContactOld, intArrayOld);

	// list is defined as type: List<Contact>,
	// it shows how object and collection
	// initialization work with the var style init. 
	// list被定義為List<Contact>型別,其展示使用var初始的物件與集合初始化設定.
	var list = new List<Contact> 
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
		Console.WriteLine("{0} {1}", item.LastName, item.DateOfBirth);
	}
}

class Contact
{
	public string LastName { get; set; }
	public DateTime DateOfBirth { get; set; }
}