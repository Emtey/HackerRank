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

    // Complete the countingValleys function below.
    static int countingValleys(int n, string s)
    {
        int myValleyCounter = 0;
        int seaLevel = 0;

        foreach (char c in s.ToUpper())
        {
            
            if (c.Equals('U'))
                seaLevel++;
            else if (c.Equals('D'))
                seaLevel--;

            if (seaLevel == 0 && c.Equals('U'))
                myValleyCounter++;

        }

        return myValleyCounter;

    }
    /*Input:
     * 8
     * UDDDUDUU
     * Ouput: 1
     * 
     * Input: 
     * 12
     * DDUUDDUDUUUD
     * Output: 2
     */ 

    static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        Console.WriteLine("Enter the amount of Ups and Downs:");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter your U and D's:");
        string s = Console.ReadLine();

        int result = countingValleys(n, s);

        Console.WriteLine(result);

        //textWriter.Flush();
        //textWriter.Close();
    }
}
