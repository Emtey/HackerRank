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

    // Complete the isValid function below.
    static string isValid(string s)
    {
        List<int> myCount = new List<int>();
        List<char> myString = new List<char>(s);
        char prevChar = ' ';

        //sort the string that was put into the list.
        myString.Sort();

        //we have a sorted array now, so we can go through it and count the 
        //individual occurances of each letter.
        for (int i = 0; i < myString.Count; i++)
        {
            if (myString[i] != prevChar)
            {
                myCount.Add(s.Split(myString[i]).Length - 1);
                prevChar = myString[i];
            }

        }

        //Console.WriteLine(string.Join(" ", myString));

        //Now myCount has a list of the amount of times a character appears in the string
        //Now we need to see if it is a valid string or not.

        //Here are the string conditions:
        //if they are all equal – it means that all characters occur exactly N times
        //and there is no removal needed

        //if 2 or more have less or more characters – there is no way to fix the 
        //string in just 1 removal

        //if exactly 1 char has a different count than all other characters – remove 
        //this char completely and S is fixed.

        myCount.Sort();
        //Console.WriteLine(string.Join(" ", myCount));
        bool isValid = false;

        //if the min == the max then we are done, no deletes needed.
        if (myCount.Max() == myCount.Min())
        {
            isValid = true;
        }
        //Only first value is different than all the others
        else if (myCount.Min() != myCount[1] && myCount[1] == myCount.Max())
        {
            //we know that the first value is the only thing different in 
            //myCount, so lets see how different it is. We first check
            //to see if subtracting it out will leave us with a valid 
            //string. Then we check to see if the difference between the max 
            //and min is less than 2 otherwise it fails
            if (myCount.Min() - 1 == 0)
                isValid = true;
            else if (myCount.Max() - myCount.Min() < 2)
                isValid = true;
        }
        //Everything is the same except for the last.
        //Same logic as above except with the last digit
        else if ((myCount.Min() == myCount[1]) &&
                (myCount.Min() == myCount[myCount.Count - 2]) &&
                (myCount.Max() != myCount[myCount.Count - 2]))
        {
            if (myCount.Max() - 1 == myCount.Min())
                isValid = true;
            else if (myCount.Max() - myCount.Min() < 2)
                isValid = true;
        }

        if (isValid)
            return "YES";
        else
            return "NO";
    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = isValid(s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}