using System;
using System.Collections;
using System.Linq;

namespace CodeChefProblems{
public class lunch_time
//https://www.codechef.com/submit/LTIME
{
	public static void Main_LunchTime()
	{
        int testCases = Convert.ToInt16(Console.ReadLine());
		string[] output = new string[testCases];
		for(int i = 0; i < testCases; i++) {
			int input = Convert.ToInt16(Console.ReadLine());
			switch(input)
			{
				case 1:
				case 2:
				case 3:
				case 4:
					output[i] = "YES";
					break;
				default:
					output[i] = "NO";
					break;
			}
		}

		foreach(string x in output) {
			Console.WriteLine(x);
		}
	}
} 
}