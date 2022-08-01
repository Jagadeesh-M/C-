using System;
using System.Collections;
using System.Linq;

namespace CodeChefProblems{
public class age_limit
//https://www.codechef.com/submit/AGELIMIT
{
	public static void Main_AgeLimit()
	{
        int testCases = Convert.ToInt16(Console.ReadLine());
        string input;
        string[] output = new string[testCases];
        int[] inputArray = new int[3];
        for(int i = 0; i < testCases; i++){
            input = Console.ReadLine();
            inputArray = input.Split(' ').Select(Int32.Parse).ToArray();
            output[i] = inputArray[2] >= inputArray[0] && inputArray[2] < inputArray[1] ? "YES": "NO";
        }

        foreach(string x in output)
            Console.WriteLine(x);
	}
}
}