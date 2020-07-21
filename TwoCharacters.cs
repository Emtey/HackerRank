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

    // Complete the alternate function below.
    static int alternate(string s)
    {
        #region Variables
        int maxLength = 0;
        string myString = "";
        #endregion


        foreach (char c in s)
        {
            //remove all the first c that we encounter and see if the string works
            foreach (char x in s)
            {
                if ( x != c)
                {
                    myString += x;
                   
                }
            }
            //Console.WriteLine(myString);
            //now see if the string contains what we are looking for


            if (maxLength < myString.Length)
                maxLength = myString.Length;
            myString = ""; //reset myString
        }

        
        return maxLength;
    }

    static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        //int l = Convert.ToInt32(Console.ReadLine().Trim());

        string s = Console.ReadLine();

        int result = alternate(s);

        Console.WriteLine(result);
        //textWriter.WriteLine(result);

        //textWriter.Flush();
        //textWriter.Close();
    }
}
