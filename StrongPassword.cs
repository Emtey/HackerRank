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

    // Complete the minimumNumber function below.
    static int minimumNumber(int n, string password)
    {
        // Return the minimum number of characters to make the password strong
        int myValue = 0;
        string specialChars = "!@#$%^&*()-+";
        bool digitPresent = false;
        bool alphaUpperPresent = false;
        bool alphaLowerPresent = false;
        bool specialPresent = false;

        foreach (char c in password)
        {
            if (char.IsDigit(c))
                digitPresent = true;
            if (char.IsLetter(c) && char.IsUpper(c))
                alphaUpperPresent = true;
            if (char.IsLetter(c) && char.IsLower(c))
                alphaLowerPresent = true;
            foreach (char x in specialChars)
            {
                if (x == c)
                {
                    specialPresent = true;
                }
            }
        }

        if (!digitPresent)
            myValue++;
        if (!alphaUpperPresent)
            myValue++;
        if (!alphaLowerPresent)
            myValue++;
        if (!specialPresent)
            myValue++;

        if (password.Length < 6 && myValue + password.Length < 6)
        {
            int fillLength = 6 - password.Length;
            int numToAdd = fillLength - myValue;
            myValue = myValue + numToAdd;
          
        }
        return myValue;

    }

    static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        string password = Console.ReadLine();

        int answer = minimumNumber(n, password);

        Console.WriteLine(answer);

        //textWriter.WriteLine(answer);

        //textWriter.Flush();
        //textWriter.Close();
    }
}
