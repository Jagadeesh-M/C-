using System;
using System.Collections;
using System.Linq;

namespace CodeChefProblems{
public class valid_minimum
//https://www.codechef.com/submit/VALIDMIN
{
	public static void Main_ValidMinimum()
	{
        int testCases = Convert.ToInt16(Console.ReadLine());
		string[] output = new string[testCases];
		for(int i = 0; i < testCases; i++) {
			string input = Console.ReadLine();
			int[] inputArray = input.Split(' ').Select(Int32.Parse).ToArray();
			Array.Sort(inputArray);
			output[i] = inputArray[0] == inputArray[1] ? "YES" : "NO";
		}

		foreach(string x in output) {
			Console.WriteLine(x);
		}
	}
} 
}