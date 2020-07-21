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

    // Complete the migratoryBirds function below.
    static int migratoryBirds(List<int> arr)
    {
        int myValue = 0;
        int max = 0;

        //sort the array
        arr.Sort();

        //create a list we can populate.
        int[] myList = new int[5];

        //now loop through the list adding up the distinct values
        foreach (int birds in arr)
        {
            switch (birds)
            {
                case 1:
                    myList[0]++;
                    break;
                case 2:
                    myList[1]++;
                    break;
                case 3:
                    myList[2]++;
                    break;
                case 4:
                    myList[3]++;
                    break;
                case 5:
                    myList[4]++;
                    break;
                default:
                    break;
            }
        }
       
        for (int i = 0; i < myList.Length; i++)
        {
     
            if (myList[i] > max)
            {
                max = myList[i];
                myValue = i + 1;
            }
            
        }   

        return myValue;
    }
    /*Input:
     * 6
     * 1 4 4 4 5 3
     * Output: 4
     * 
     * Input:
     * 11
     * 1 2 3 4 5 4 3 2 1 3 4
     * Output: 3
     */

    static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
        Console.WriteLine("Enter the number of entries:");
        int arrCount = Convert.ToInt32(Console.ReadLine().Trim());
        Console.WriteLine("Enter the birds numbers: ");
        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        int result = migratoryBirds(arr);

         Console.WriteLine(result);
        //textWriter.WriteLine(result);

        //textWriter.Flush();
        //textWriter.Close();
    }
}

