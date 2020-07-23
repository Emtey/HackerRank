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

    // Complete the makeAnagram function below.
    static int makeAnagram(string a, string b)
    {
        int deleteCount = 0;
        int totalLength = a.Length + b.Length;

        //Convert the strings into Lists so we can perform the Remove function on it
        List<char> strA = new List<char>(a);
        List<char> strB = new List<char>(b);

        for (int i = 0; i < a.Length; i++)
        {
            //if we find a match, then we want to update our count then delete it
            //in the second string so if we have a duplicate in the first string we dont
            //keep looking at the same value in the second.
            if (strB.Contains(strA[i]))
            {
                deleteCount++;
                strB.Remove(strA[i]);
            }
        }

        //Since we know we have to remove it from two tables and we only counted it
        //once, multiply by 2 and subtract by the total length of both strings.
        return (totalLength - (deleteCount * 2));


    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string a = Console.ReadLine();

        string b = Console.ReadLine();

        int res = makeAnagram(a, b);

        textWriter.WriteLine(res);

        textWriter.Flush();
        textWriter.Close();
    }
}