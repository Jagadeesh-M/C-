using System;
using System.Collections;
using System.Linq;

namespace CodeChefProblems{
public class fairpass
//https://www.codechef.com/submit/FAIRPASS
{
	public static void Main_FairPass()
	{
        int testCases = Convert.ToInt16(Console.ReadLine());
		string[] output = new string[testCases];
		for(int i = 0; i < testCases; i++) {
			string input = Console.ReadLine();
			int[] inputArray = input.Split(' ').Select(Int32.Parse).ToArray();
			output[i] = inputArray[0] < inputArray[1] ? "YES" : "NO";
		}

		foreach(string x in output) {
			Console.WriteLine(x);
		}
	}
} 
}