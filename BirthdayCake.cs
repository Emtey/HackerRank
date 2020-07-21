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

    //m = consecutive sqares in array, d is the total value
    // Complete the birthday function below.
    static int birthday(List<int> s, int d, int m)
    {
        
        int myValue = 0;

       //since we know that s.Count - m + 1 is the last digit we need to consider as we cant have shorter than m pieces
       //we just loop up to that point.
        for (int i = 0; i < s.Count - m + 1; i++)
        {
            int mySum = 0;

            //Now loop again for the amount of squares we want starting from the position we are in.
            for (int j = 0; j < m; j++)
            {
                mySum = mySum + s[i + j];
            }
            if (mySum == d)
            {
                myValue++;
            }

        }

        return myValue;
    }


static void Main(string[] args)
{
    //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
    Console.WriteLine("enter the number of values you are going to enter:");
    int n = Convert.ToInt32(Console.ReadLine().Trim());
    Console.WriteLine("Enter your values:");
    List<int> s = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(sTemp => Convert.ToInt32(sTemp)).ToList();
    Console.WriteLine("Enter the M and D values: ");
    string[] dm = Console.ReadLine().TrimEnd().Split(' ');

    int d = Convert.ToInt32(dm[0]);

    int m = Convert.ToInt32(dm[1]);

    int result = birthday(s, d, m);

    Console.WriteLine(result);
    //textWriter.WriteLine(result);

    //textWriter.Flush();
    //textWriter.Close();
}
}

