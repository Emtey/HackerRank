using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution
{

    /*
     * A simple program that takes a time input and converts it to 24 hour clock
     */
    static string timeConversion(string s)
    {
        DateTime dt = DateTime.Parse(s);
        return (dt.ToString("HH:mm:ss"));

    }


    static void Main(string[] args)
    {
        //TextWriter tw = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
        Console.WriteLine("Please enter a time in hh:mm:ssAM or hh:mm:ssPM format.");

        string s = Console.ReadLine();

        string result = timeConversion(s);

        Console.WriteLine(result);

        //tw.WriteLine(result);

        //tw.Flush();
        //tw.Close();
    }
}
