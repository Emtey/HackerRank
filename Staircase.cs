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

    // Complete the staircase function below.
    //the out put should look like this for n = 6
    //     #
    //    ##
    //   ###
    //  ####
    // #####
    //######
    static void staircase(int n)
    {
        char[] myArray = new char[n];
        char myPound = '#';
        char mySpace = ' ';


        for (int i = 0; i < n; i++)
        {
            int howManySpaces = n - (i + 1);
                                  
            //loop though the array adding spaces from the first position in the array
            for (int x = 0; x < howManySpaces; x++)
            {
                myArray[x] = mySpace;
            }

            //loop through the array adding pound signs from the position where the spaces ended.
            for (int x = howManySpaces; x < n; x++)
            {
                myArray[x] = myPound;
            }

            Console.WriteLine(myArray);



        }



    }

    static void Main(string[] args)
    {
        Console.WriteLine("Please enter an integer: ");
        int n = Convert.ToInt32(Console.ReadLine());

        staircase(n);
    }
}
