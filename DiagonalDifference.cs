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

    /*
     * Complete the 'diagonalDifference' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts 2D_INTEGER_ARRAY arr as parameter.
     */

    public static int diagonalDifference(List<List<int>> arr)
    {
        int myValue = 0;
        int x = 0;
        int y = arr[0].Count() - 1;

        //now we need to loop through the matrix
        //since we know that right Diagonal Value will be at {0,0}, {1,1}, {2,2} etc we can just do arr[x][x].
        //to get the left Diagonal Value we need to use the x value (starts at 0) and the y value (starts Count)
        //and move backwards and "up" a row each time.  So the first value is at {0, 2), then {1,1} then {2,0} for a 3 dimensional array.
        //Now the trick here is that we take the value(s) on each row and subtract them from each other, then subtract the result from myValue
        //then we run that through the absolute value function in the Math library and we have our absolute value.

        //We use this loop to control how many times we loop through the process.  Do not want to go out of bounds!
        for (int i = 0; i < arr.Count(); i++) 
        {            
            myValue = myValue - (arr[x][x] - arr[x++][y--]);
        }
           
        return Math.Abs(myValue);
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<List<int>> arr = new List<List<int>>();

        for (int i = 0; i < n; i++)
        {
            arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
        }

        int result = Result.diagonalDifference(arr);
        Console.WriteLine(result);

        //textWriter.WriteLine(result);

        //textWriter.Flush();
        //textWriter.Close();
    }
}
