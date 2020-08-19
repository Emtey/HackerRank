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

    // Complete the countSwaps function below.
    static void countSwaps(int[] a)
    {
        int numSwaps = 0;
        int n = a.Count();

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n - 1; j++)
            {
                // Swap adjacent elements if they are in decreasing order
                if (a[j] > a[j + 1])
                {
                    int highValue = a[j];
                    int lowValue = a[j + 1];
                    a[j] = lowValue;
                    a[j + 1] = highValue;
                    numSwaps += 1;
                }
            }

        }

        Console.WriteLine("Array is sorted in {0} swaps.", numSwaps);
        Console.WriteLine("First Element: {0}", a.Min());
        Console.WriteLine("Last Element: {0}", a.Max());


    }

    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());

        int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp))
        ;
        countSwaps(a);
    }
}
