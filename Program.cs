// See https://aka.ms/new-console-template for more information
using System;

class Program
{
	static void Main()
	{
		string s = Console.ReadLine();
		string t = Console.ReadLine();
		Console.WriteLine(StringsXor(s, t));
	}

	static string StringsXor(string s, string t)
	{
		char[] result = new char[s.Length];
		for (int i = 0; i < s.Length; i++)
		{
			result[i] = s[i] == t[i] ? '0' : '1';
		}
		return new string(result);
	}
}