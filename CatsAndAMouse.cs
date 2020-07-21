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

    // Complete the catAndMouse function below.
    static string catAndMouse(int x, int y, int z)
    {
        string mouse = "Mouse C";
        string catA = "Cat A";
        string catB = "Cat B";

        int catALoc = Math.Abs(x - z);
        int catBLoc = Math.Abs(y - z);

        if (catALoc < catBLoc)
        {
            return catA;
        }
        else if (catALoc > catBLoc)
        {
            return catB;
        }
        else
        {
            return mouse;
        }


    }

    /*Input:
     * 2
     * 1 2 3
     * 1 3 2
     * Output: Cat B
     *         Mouse C
     */ 
    static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int q = Convert.ToInt32(Console.ReadLine());

        for (int qItr = 0; qItr < q; qItr++)
        {
            string[] xyz = Console.ReadLine().Split(' ');

            int x = Convert.ToInt32(xyz[0]);

            int y = Convert.ToInt32(xyz[1]);

            int z = Convert.ToInt32(xyz[2]);

            string result = catAndMouse(x, y, z);
            Console.WriteLine(result);
            //textWriter.WriteLine(result);
        }

        //textWriter.Flush();
        //textWriter.Close();
    }
}

