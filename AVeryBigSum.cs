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

    // Complete the aVeryBigSum function below.
    static long aVeryBigSum(long[] ar)
    {
        long value = 0;
        foreach (long myArValue in ar)
        {
            value += myArValue;
        }

        return value;

    }

    static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        //int arCount = Convert.ToInt32(Console.ReadLine());
        int arCount = 5;

        //long[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt64(arTemp));
        long[] ar = { 10000015, 10000025, 10000035, 10000045, 10000055 };
        long result = aVeryBigSum(ar);

        Console.WriteLine("The values in the array are: ");
        for (int i = 0; i < arCount; i++)
        {
            Console.WriteLine(ar[i]);
        }
        Console.WriteLine("\nSummed value: " + result);

        //textWriter.Flush();
        //textWriter.Close();
    }
}
