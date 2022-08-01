using System;
using System.Collections;
using System.Linq;

namespace CodeChefProblems{
public class on_off_bulb
//https://www.codechef.com/submit/ON_OFF
{
	public static void Main_OnOffBulb()
	{
        int testCases = Convert.ToInt16(Console.ReadLine());
        BitArray output = new BitArray(testCases);
        int numOfSwitches;
        string initStageOfSwitches,finalStageOfSwitches;
        for(int i = 0; i < testCases; i++){
            
            numOfSwitches = Convert.ToInt16(Console.ReadLine());
            
            initStageOfSwitches = Console.ReadLine();
            finalStageOfSwitches = Console.ReadLine();
            
            BitArray b_initStageOfSwitches;
            BitArray b_finalStageOfSwitches;
            BitArray b_output;

            b_initStageOfSwitches = new BitArray(initStageOfSwitches.Select(c => c == '1').ToArray());
            b_finalStageOfSwitches = new BitArray(finalStageOfSwitches.Select(c => c == '1').ToArray());
            b_output = b_initStageOfSwitches.Xor(b_finalStageOfSwitches);

            int numberOfSwitchChanges = 0;
            for (int j = 0; j < b_output.Count; j++)
            {
                if(b_output[j] == true)
                    numberOfSwitchChanges++;
            }
            output[i] = (numberOfSwitchChanges%2 == 0) ? true : false;
        }

        foreach(bool x in output)
            Console.WriteLine((x == true) ? 1 : 0);
	}
}
}