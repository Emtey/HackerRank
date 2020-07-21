
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

namespace SockMerchant
{
    class SockMerchant
    {
        /*This was a daily challenge from Hackerrank.com.
         * Here is the entire challenge:
         * John works at a clothing store. He has a large pile of socks that he must pair by color for sale. 
         * Given an array of integers representing the color of each sock, determine how many pairs of socks with matching colors there are.
         * For example, there are n = 7 socks with colors ar = {1, 2, 1, 2, 1, 2, 3} . There is one pair of color 1 and one of color 2. 
         * There are three odd socks left, one of each color. The number of pairs is 2 . 
         */
        static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
            //Console.WriteLine("Please enter the amount of numbers for the array. (between 1 and 99).");
            //int n = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Please enter numbers for the integer you entered above.");
            //int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));

            //TestCase 1
            //int n = 7;
            //int[] ar = { 1, 2, 1, 2, 1, 2, 3 };


            //TestCase 2
            int n = 9;
            int[] ar = { 10, 20, 20, 10, 10, 30, 50, 10, 20 };
            int result = sockMerchant(n, ar);

            Console.WriteLine("The Numbers in the array are: ");
            foreach (int myValue in ar)
                Console.Write(myValue + " ");

            Console.WriteLine("\nThe number of pairs of is: " + result);
            //textWriter.WriteLine(result);

            //textWriter.Flush();
            //textWriter.Close();
        }

        // Complete the sockMerchant function below.
        static int sockMerchant(int n, int[] ar)
        {

            int matchCounter = 0;

            //so we need to determine if we have already examined this number before
            //we do this by adding the number to an arrayList
            ArrayList myArrayList = new ArrayList();
            myArrayList.Add(0);  //need a value in here for the first pass through

            //loop through the array looking for matches
            for (int i = 0; i < ar.Length; i++)
            {
                int currentArValue = ar[i];

                //check the arrayList to see if it contains the current value we are 
                //looking at, if it doesnt then add it, if it does then we know we have 
                //already counted it and we dont have to do anything with it
                if (!myArrayList.Contains(currentArValue))
                {
                    //add the value to the ArrayList;
                    myArrayList.Add(currentArValue);
                }
            }

            //Go through the arrays looking for matches
            foreach (int myValue in myArrayList)
            {
                int tempCounter = 0;
                int tempMatchCounter = 0;
                for (int i = 0; i < ar.Length; i++)
                {
                    if (myValue == ar[i])
                    {
                        tempCounter++;
                    }
                }
                tempMatchCounter = tempCounter / 2;
                matchCounter += tempMatchCounter;

                tempCounter = 0;
                tempMatchCounter = 0;
            }

            return matchCounter;

        }
    }
}
