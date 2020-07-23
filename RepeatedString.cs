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

    // Complete the repeatedString function below.
    //given a string figure out how many times the char 'a' can show up given the string is repeated x amount of times.
    //for example:  string is aba and we want to repeat that string 10 times, how many times does 'a' appear.
    static long repeatedString(string s, long n)
    {
        long myValue = 0;

        foreach (char x in s)
        {
            if (x == 'a')
                myValue++;
        }
        //need to figure out how many times we can loop the string
        myValue = (n / s.Length) * myValue;

        //need to deal with any remainders
        for (int i = 0; i < n % s.Length; i++)
        {
            if (s[i] == 'a')
                myValue++;
        }


        return myValue;


    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        long n = Convert.ToInt64(Console.ReadLine());

        long result = repeatedString(s, n);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}