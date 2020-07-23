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

    // Complete the minimumAbsoluteDifference function below.
    //Given an array of integers, find and print the minimum absolute difference between any two elements in the array.
    static int minimumAbsoluteDifference(int[] arr)
    {
        Array.Sort(arr);
        int min = Math.Abs(arr[0] - arr[1]);

        for (int i = 1; i < arr.Length - 1; i++)
        {
            if (Math.Abs(arr[i] - arr[i + 1]) < min)
                min = Math.Abs(arr[i] - arr[i + 1]);
        }

        return min;
    }



    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;
        int result = minimumAbsoluteDifference(arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}

