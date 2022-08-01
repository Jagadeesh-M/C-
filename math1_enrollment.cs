using System;
using System.Collections;
using System.Linq;

namespace CodeChefProblems{
public class math1_enrollment
//https://www.codechef.com/submit/M1ENROL
{
	public static void Main_Math1Enrollment()
	{
        int testCases = Convert.ToInt16(Console.ReadLine());
		int[] output = new int[testCases];
		for(int i = 0; i < testCases; i++) {
			string input = Console.ReadLine();
			int[] inputArray = input.Split(' ').Select(Int32.Parse).ToArray();
			output[i] = inputArray[0] < inputArray[1] ? inputArray[1] - inputArray[0] : 0;
		}

		foreach(int x in output) {
			Console.WriteLine(x);
		}
	}
} 
}