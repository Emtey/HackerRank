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

     /// <summary>
    /// Takes two Strings and checks to see if they share a
    /// commonality (at least one letter between them).
    /// </summary>
    /// <param name="s1"> first string </param>
    /// <param name="s2"> second string </param>
    /// <returns> Yes is shared commonality, NO if no shared commonality</returns>
    static string twoStrings(string s1, string s2)
    {
        string letters = "abcdefghijklmnopqrstuvwxyz";

        for (int i = 0; i < letters.Length; i++)
        {
            if (s1.Contains(letters[i]) && s2.Contains(letters[i]))
                return "YES";
        }
        return "NO";
    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int q = Convert.ToInt32(Console.ReadLine());

        for (int qItr = 0; qItr < q; qItr++)
        {
            string s1 = Console.ReadLine();

            string s2 = Console.ReadLine();

            string result = twoStrings(s1, s2);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}

