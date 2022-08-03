using System;
using System.Collections;
using System.Linq;

namespace CodeChefProblems {
public class slow_solution
//https://www.codechef.com/submit/SLOWSOLN
{
	public static void Main_SlowSolution()
	{
        int testCases = Convert.ToInt16(Console.ReadLine());
		double[] output = new double[testCases];
		for(int i = 0; i < testCases; i++){
			string input = Console.ReadLine();
			int[] iArray = input.Split(' ').Select(Int32.Parse).ToArray();
			int quotient,remainder;
			quotient = iArray[2] / iArray[1];
			remainder = iArray[2] % iArray[1];

			if(quotient < iArray[0])
			{
				output[i] = (quotient * (Math.Pow(iArray[1],2))) + Math.Pow(remainder,2);
			}
			else{
				output[i] = iArray[0] * (Math.Pow(iArray[1],2));
			}

		
		}
		foreach(int st in output){
			Console.WriteLine(st);
		}
	}
} 
}