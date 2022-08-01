using System;
using System.Collections;
using System.Linq;

namespace CodeChefProblems {
public class easy_pronunciation
//https://www.codechef.com/submit/EZSPEAK
{
	public static void Main_EasyPronunciation()
	{
		char[] vowels = new char[5];
		vowels[0] = 'a';
		vowels[1] = 'e';
		vowels[2] = 'i';
		vowels[3] = 'o';
		vowels[4] = 'u';
        int testCases = Convert.ToInt16(Console.ReadLine());
		string[] output = new string[testCases];
		for(int i = 0; i < testCases; i++) {
			int numOfChars = Convert.ToInt16(Console.ReadLine());
			string str = Console.ReadLine();
			int countOfConsonants = 0;
			foreach(char c in str)
			{
				if(vowels.Contains(c))
				{
					countOfConsonants = 0;
				}
				else
				{
					countOfConsonants++;
				}
				
				if(countOfConsonants >= 4)
					break;
			}
			output[i] = countOfConsonants < 4 ? "YES" : "NO";
		}

		foreach(string st in output){
			Console.WriteLine(st);
		}
	}
} 
}