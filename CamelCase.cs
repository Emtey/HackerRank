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

    // Complete the camelcase function below.
    static int camelcase(string s)
    {

        int wordCount = 1;

        if (s.Length > 0)
        {
            foreach (char c in s)
            {
                if (char.IsUpper(c))
                {
                    wordCount++;
                }
            }
        }
        else
        {
            wordCount = 0;
        }
        return wordCount;


    }
    /*Input:
     * saveTheDateForAParty
     * Output: 6
     */ 

    static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        int result = camelcase(s);

        Console.WriteLine(result);
        //textWriter.WriteLine(result);

        //textWriter.Flush();
        //textWriter.Close();
    }
}

