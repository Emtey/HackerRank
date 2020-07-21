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
    //Compare two Lists of the same size if a[i] > b[i] then add to the aWins count.
    //if b[i] > a[i] then bWins
    //otherwise noone wins and move to next item in List.

    // Complete the compareTriplets function below.
    static List<int> compareTriplets(List<int> a, List<int> b)
    {
        List<int> myList = new List<int>();
        int aWins = 0;
        int bWins = 0;

        for (int i = 0; i < a.Count; i++)
        {
            if (a[i] > b[i])
            {
                aWins = aWins + 1;
            }
            else if (a[i] < b[i])
            {
                bWins = bWins + 1;
            }
        }
        myList.Add(aWins);
        myList.Add(bWins);
        return myList;


    }

    static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        //List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

        //List<int> b = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(bTemp => Convert.ToInt32(bTemp)).ToList();
        List<int> a = new List<int>();
        a.Add(5);
        a.Add(6);
        a.Add(7);

        List<int> b = new List<int>();
        b.Add(3);
        b.Add(6);
        b.Add(10);
        List<int> result = compareTriplets(a, b);

        Console.WriteLine(String.Join(" ", result));
        //textWriter.WriteLine(String.Join(" ", result));

        //textWriter.Flush();
        //textWriter.Close();
    }
}
