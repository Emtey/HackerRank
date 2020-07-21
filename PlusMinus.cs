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

    // Goes through an array and determines how many values are greater than, 
    //less than, or equal to zero.  Then displays that in a decimal format.
    static void plusMinus(int[] arr)
    {
        float divisor = arr.Length;
        float greaterThanZero = 0;
        float lessThanZero = 0;
        float equalZero = 0;

        foreach (int myInt in arr)
        {
            if (myInt > 0)
                greaterThanZero++;
            else if (myInt < 0)
                lessThanZero++;
            else if (myInt == 0)
                equalZero++;
        }

        Console.WriteLine(String.Format("{0:0.0000000}", greaterThanZero / divisor));
        Console.WriteLine(String.Format("{0:0.0000000}", lessThanZero / divisor));
        Console.WriteLine(String.Format("{0:0.0000000}", equalZero / divisor));
    }

    static void Main(string[] args)
    {
        //int n = Convert.ToInt32(Console.ReadLine());

        //int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
        int[] arr = { -4, 3, -9, 0, 4, 1 };
        plusMinus(arr);
    }
}
