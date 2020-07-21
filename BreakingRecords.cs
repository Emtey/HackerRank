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

    // Complete the breakingRecords function below.
    static int[] breakingRecords(int[] scores)
    {

        int highScore = scores[0];
        int lowScore = scores[0];
        int highScoreCounter = 0;
        int lowScoreCounter = 0;

        foreach (int score in scores)
        {
            if (highScore < score)
            {
                highScoreCounter++;
                highScore = score;
            }
            if (lowScore > score)
            {
                lowScoreCounter++;
                lowScore = score;
            }
        }
        int[] myScores = { highScoreCounter, lowScoreCounter };
        return myScores;

    }
    //input:
    // 10
    // 3 4 21 36 10 28 35 5 24 42
    //Output : 4 0

    static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
        Console.WriteLine("Enter the amount of scores you wish to enter: ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the scores, separated by spaces:");

        int[] scores = Array.ConvertAll(Console.ReadLine().Split(' '), scoresTemp => Convert.ToInt32(scoresTemp));
        int[] result = breakingRecords(scores);
        Console.WriteLine(string.Join(" ", result));
        //textWriter.WriteLine(string.Join(" ", result));

        //textWriter.Flush();
        //textWriter.Close();
    }
}
