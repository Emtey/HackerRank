using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution
{

    // Complete the luckBalance function below.
    //VERY POORLY written question.  So basically this person likes to lose
    //and so has created a matrix to try to figure out how many points they can
    //get for losing.  The k value dictates how many they can lose if the contest
    //is important, which is denoted as 1 in the contests[x][1] location of the
    //matrix.
    static int luckBalance(int k, int[][] contests)
    {
        int totalLuck = 0;
        int ContestCount = 0;
        List<int> tempList = new List<int>();

        //If contests[i][1] == 0 contest is unimportant, they plan
        //on losing these no matter what, so add it to the totalLuck counter.
        //If it is important, update ContestCount and the value to the tempList
        //updating the totalLuck counter as well.  So totalLuck is the sum of
        //all the contests if they choose to lose them all and ContestCount
        //is the sum of all the contests that are important.
        //tempList contains the values that they might need to remove some of
        //if they have to win some contests.
        for (int i = 0; i < contests.Length; i++)
        {
            if (contests[i][1] == 0)
                totalLuck += contests[i][0];
            else
            {
                ContestCount++;
                tempList.Add(contests[i][0]);
                totalLuck += contests[i][0];
            }
        }

        //If our contestCount is greater than k, meaning we have more cases to win 
        //than we are allowed, we have to strip some off so we get down to the
        //k value.  Since we want to win the ones with the lowest penalty, 
        //sort the List then remove the first however many depending on
        //ContestCount - k (which is the amount we have to win).
        if (ContestCount > k)
        {
            tempList.Sort();
            //Console.WriteLine(string.Join(" ", tempList));
            int n = ContestCount - k;
            Console.WriteLine("n: {0}", n);
            for (int j = 0; j < n; j++)
            {
                //we mulitply by two because the value is already in totalLuck so
                //we need to remove it twice to decrease totalLuck to where it needs
                //to be.  
                //For example if we have 5 + 2 + 1 + 8 + 10 + 5 = 31
                //But they need to lose the lowest value so 5 + 2 + 8 + 10 + 5 - 1 = 29 
                totalLuck -= 2 * tempList[j];
            }
        }

        return totalLuck;


    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] nk = Console.ReadLine().Split(' ');

        int n = Convert.ToInt32(nk[0]);

        int k = Convert.ToInt32(nk[1]);

        int[][] contests = new int[n][];

        for (int i = 0; i < n; i++)
        {
            contests[i] = Array.ConvertAll(Console.ReadLine().Split(' '), contestsTemp => Convert.ToInt32(contestsTemp));
        }

        int result = luckBalance(k, contests);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}