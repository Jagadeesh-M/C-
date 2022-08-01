using System;
using System.Collections;
using System.Linq;

namespace CodeChefProblems {
public class hungry_chef
{
	public static void Main_HungryChef()
	//https://www.codechef.com/submit/BURGERS2
	{
        int testCases = Convert.ToInt16(Console.ReadLine());
		string[] output = new string[testCases];
		for(int i = 0; i < testCases; i++) {
			string input = Console.ReadLine();
			Int64[] inputArray = input.Split(' ').Select(Int64.Parse).ToArray();
			if(inputArray[2] * inputArray[0] > inputArray[3]) //if cost of buying all normal burgers is more than bucks chef has
				{
					Console.WriteLine(-1);
				}
			else if(inputArray[2] * inputArray[1] <= inputArray[3]) //if cost of buying all premium burgers is less than bucks chef has, then buy all burgers of premium type
				{
					Console.WriteLine(0 + " " + inputArray[1]);
				}
			else
				{
					Int64 y = (inputArray[3] - inputArray[2] * inputArray[0])/(inputArray[1] - inputArray[0]);
					Int64 x = inputArray[2] - y;
					Console.WriteLine(x + " " + y);
				}
		}
	}
} 
}