using BasicPrograms.Interfaces;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BasicPrograms.HakerRank;

//"Have the function FoodDistribution(arr) read the array of numbers stored in arr which will represent the hunger level of different people ranging from 0 to 5 (0 meaning not hungry at all, 5 meaning very hungry). You will also have N sandwiches to give out which will range from 1 to 20. The format of the array will be [N, h1, h2, h3, ...] where N represents the number of sandwiches you have and the rest of the array will represent the hunger levels of different people. Your goal is to minimize the hunger difference between each pair of people in the array using the sandwiches you have available.

//For example: if arr is [5, 3, 1, 2, 1], this means you have 5 sandwiches to give out. You can distribute them in the following order to the people: 2, 0, 1, 0. Giving these sandwiches to the people their hunger levels now become: [1, 1, 1, 1]. The difference between each pair of people is now 0, the total is also 0, so your program should return 0. Note: You may not have to give out all, or even any, of your sandwiches to produce a minimized difference.


//Another example: if arr is [4, 5, 2, 3, 1, 0] then you can distribute the sandwiches in the following order: [3, 0, 1, 0, 0] which makes all the hunger levels the following: [2, 2, 2, 1, 0]. The differences between each pair of people is now: 0, 0, 1, 1 and so your program should return the final minimized difference of 2."
public class GreedyDistibution
{
    public static int FoodDistribution(int[] arr)
    {
        //no element return
        if (arr.Length == 0)
        {
            return 0;
        }
        //separate hunder and sandwitches
        int sandwitches = arr[0];
        int[] hunger = arr.Skip(1).ToArray();

        while (sandwitches > 0)
        {
            //adjacents difference
            var diffs = new List<int>();
            for (int i = 0; i < hunger.Length - 1; i++)
            {
                //diffs.Add(hunger[i] - hunger[i + 1] > 0 ? hunger[i] - hunger[i + 1] : 0);
                diffs.Add(Math.Abs(hunger[i] - hunger[i + 1]));
            }

            //diff sum cannot be zero
            if (diffs.Sum() == 0)
            {
                break;
            }

            //finf max diff and its position
            int maxdiff = diffs.Max();
            int maxdiffindex = diffs.IndexOf(maxdiff);

            //reduce max diff
            if (hunger[maxdiffindex] > hunger[maxdiffindex + 1])
            {
                if (hunger[maxdiffindex] > 0)
                {
                    hunger[maxdiffindex]--;
                    sandwitches--;
                }
            }
            else
            {
                if (hunger[maxdiffindex + 1] > 0)
                {
                    hunger[maxdiffindex + 1]--;
                    sandwitches--;
                }
            }
        }

        //total adjacent difference
        int totalDiff = 0;
        for (int i = 0; i < hunger.Length - 1; i++)
        {
            totalDiff += Math.Abs(hunger[i] - hunger[i + 1]);
            //totalDiff += hunger[i] - hunger[i + 1] > 0 ? hunger[i] - hunger[i + 1] : 0;
        }

        return totalDiff;

    }
}
