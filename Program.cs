using System;
using System.Collections;
using System.Linq;

namespace CodeChefProblems {
public class Program
{
	public static void Main()
	{
        int testCases = Convert.ToInt16(Console.ReadLine());
		int[] output = new int[testCases];
		for(int i = 0; i < testCases; i++){
			string input = Console.ReadLine();
			int[] iArray = input.Split(' ').Select(Int32.Parse).ToArray();
			bool one = (iArray[0] == iArray[2] && iArray[1] == iArray[3]) || (iArray[0] == iArray[3] && iArray[1] == iArray[2]);
			bool two = (iArray[0] == iArray[4] && iArray[1] == iArray[5]) || (iArray[0] == iArray[5] && iArray[1] == iArray[4]);

			if(one)
				output[i] = 1;
			else if(two)
				output[i] = 2;
			else
				output[i] = 0;
		}
		foreach(int st in output){
			Console.WriteLine(st);
		}
	}
} 
}