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

    // Complete the alternatingCharacters function below.
    //Given a string of A's and B's delete characters until only alternating characters remain.
    //for example:
    //  ABAABBA
    //  resutling string: ABABA with 2 deletes.
    static int alternatingCharacters(string s)
    {
        int deleteCount = 0;

        for (int i = 0; i < s.Length - 1; i++)
        {
            if (s[i] == s[i + 1])
                deleteCount++;
        }
        return deleteCount;
    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int q = Convert.ToInt32(Console.ReadLine());

        for (int qItr = 0; qItr < q; qItr++)
        {
            string s = Console.ReadLine();

            int result = alternatingCharacters(s);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}