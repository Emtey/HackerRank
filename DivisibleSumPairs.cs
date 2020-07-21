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

    // Complete the divisibleSumPairs function below.
    static int divisibleSumPairs(int n, int k, int[] ar)
    {
        int myValue = 0;
        //sort the array
        Array.Sort(ar);

        //We are looking for pairs so we dont need to consider the last entry
        //in the array.
        for (int i = 0; i < ar.Length - 1; i++)
        {
            for (int j = i + 1; j < ar.Length; j++)
            {
                if ((ar[i] + ar[j]) % k == 0)
                {
                    myValue++;
                }
            }

        }

        return myValue;

    }

    /*Input:
     * 6 3
     * 1 3 2 6 1 2
     * Ouput: 5
     */

    static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] nk = Console.ReadLine().Split(' ');

        int n = Convert.ToInt32(nk[0]);

        int k = Convert.ToInt32(nk[1]);

        int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));
        int result = divisibleSumPairs(n, k, ar);

        Console.WriteLine(result);

        //textWriter.WriteLine(result);

        //textWriter.Flush();
        //textWriter.Close();
    }
}
