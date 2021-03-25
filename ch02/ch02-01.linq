<Query Kind="Program" />

void Main()
{
	
	string password = "ClearTextPassword";
	string hashedPassword = password.GetSHA1Hash();
}

// Define other methods and classes here
static class MyStringExtensions
{
	static string CreateHyperline(this string text, string url)
	{
		return String.Format("<a href=' {0}' >{1}</a>", url, text);
	}
	
	static string GetSHA1Hash(this string text)
	{
		if(string.IsNullOrEmpty(text)) return null;
		SHA1Managed sha1 = new SHA1Managed();
		
		byte[] bytes = sha1.ComputeHash(new UnicodeEncoding().GetBytes(text));
		
		return Convert.ToBase64String(bytes);
	}
}