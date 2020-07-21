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


/*
 * Given five positive integers, find the minimum and maximum values that can be calculated by summing exactly four of the five integers. 
 * Then print the respective minimum and maximum values as a single line of two space-separated long integers.
 * For example,  arr = { 1, 3, 5, 7, 9}. Our minimum sum is 1 + 3 + 5 + 7 = 16 and our maximum sum is 3 + 5 + 7 + 9 = 24. 
 * We would print:
 * 
 * 16 24
*/

class Solution
{

    // Complete the miniMaxSum function below.
    static void miniMaxSum(int[] arr)
    {
        long minSum = 0;
        long maxSum = 0;
        long myValue = 0;   

        //Sort the array to get the lowest value in the arr[0] postion and the highest value
        //in the arr[arr.length] position.
        Array.Sort(arr);

        //now sum the whole array.
        foreach (long myInt in arr)
        {
            myValue += myInt;
        }
        //subtract the highest value
        minSum = myValue - arr[arr.Length - 1];
        //subtract the lowest value
        maxSum = myValue - arr[0];
        
        Console.WriteLine("{0} {1}", minSum, maxSum);
    }

    static void Main(string[] args)
    {
        //int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
        int[] arr = { 1, 3, 5, 7, 9 };
        //int[] arr = { 5, 5, 5, 5, 5 };
        //int[] arr = { 1, 1, 2, 3, 4, 5 };
        //int[] arr = { 5, 3, 15, 4, 268, 270 };

        miniMaxSum(arr);
    }
}

