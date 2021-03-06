﻿using System.CodeDom.Compiler;
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

    // Complete the maximumToys function below.
    //Guy wants to maximize bang for buck and wants to buy as many toys
    //as his budget will allow.  Array is a list of prices for toys, and 
    //k is his budget.  
    static int maximumToys(int[] prices, int k)
    {
        int numberToys = 0;
        int newTotal = 0;

        //sort the array to make sure it goes from least to greatest.
        Array.Sort(prices);

        //loop through the prices
        foreach (int price in prices)
        {
            if (newTotal + price <= k)
            {
                newTotal += price;
                numberToys++;
            }
            else //if we exceed k just stop looking at this point
                break;
        }
        return numberToys;

    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] nk = Console.ReadLine().Split(' ');

        int n = Convert.ToInt32(nk[0]);

        int k = Convert.ToInt32(nk[1]);

        int[] prices = Array.ConvertAll(Console.ReadLine().Split(' '), pricesTemp => Convert.ToInt32(pricesTemp))
        ;
        int result = maximumToys(prices, k);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
