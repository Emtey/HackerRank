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

class Result
{
    public static List<int> gradingStudents(List<int> grades)
    {
        for (int i = 0; i < grades.Count; i++)
        {
            //if grades is less than 38 we do nothing with it, just post it.
            if (grades[i] >= 38)
            {
                //the modulo operator will return the remainder of 
                //grades / 5, then we subtract it from 5 and if that
                //result is less than 3 then we round up, otherwise we just 
                //leave the value alone in the grades list.
                if (5 - grades[i] % 5 < 3)
                {
                    //overwrite the value in the grades list with the new value.
                    grades[i] = (grades[i] + (5 - grades[i] % 5));
                }
            }
        }
        return grades;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
        Console.WriteLine("Please enter the amount of grades you wish to enter:");
        int gradesCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> grades = new List<int>();
        Console.WriteLine("Enter your grades:");

        for (int i = 0; i < gradesCount; i++)
        {
            int gradesItem = Convert.ToInt32(Console.ReadLine().Trim());
            grades.Add(gradesItem);
        }
        Console.WriteLine("\nFinal Grades are:");
        List<int> result = Result.gradingStudents(grades);
        Console.WriteLine(String.Join("\n",result));

        //textWriter.WriteLine(String.Join("\n", result));

        //textWriter.Flush();
        //textWriter.Close();
    }
}
