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

    // Complete the jumpingOnClouds function below.

    //moving through an array of 1's and 0's.  0's are ok to land on, while must be avoided.
    //you can only jump 2 spaces maximum
    static int jumpingOnClouds(int[] c)
    {
        int count = 0;
        int i = 0;
        while (i < c.Length - 1)
        {
            if (i + 2 < c.Length && c[i + 2] != 1)
            {
                count++;
                i = i + 2;
            }
            else
            {
                count++;
                i++;
            }
        }
        return count;

    }
    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[] c = Array.ConvertAll(Console.ReadLine().Split(' '), cTemp => Convert.ToInt32(cTemp))
        ;
        int result = jumpingOnClouds(c);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}

