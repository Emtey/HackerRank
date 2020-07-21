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

class RansomNote
{

    // Complete the checkMagazine function below.
    static void checkMagazine(string[] magazine, string[] note)
    {
        bool createNote = true;

        for (int i = 0; i < note.Length; i++)
        {
            //get the position of where the matches lie in the array
            int pos = Array.IndexOf(magazine, note[i]);

            //if greater than -1 we have a match, otherwise the word wasnt found
            if (pos > -1)
            {
                //clear the word out of magazine so we dont use it again.
                //Array.Clear(magazine, pos, 1);
                magazine[pos] = "";
            }
            else
            {
                createNote = false;
                break;
            }

        }

        if (createNote)
            Console.WriteLine("Yes");
        else
            Console.WriteLine("No");

    }

    /*test case:
     6 4
     give me one grand today night
     give one grand today
     */

    static void Main(string[] args)
    {
        string[] mn = Console.ReadLine().Split(' ');

        int m = Convert.ToInt32(mn[0]);

        int n = Convert.ToInt32(mn[1]);

        string[] magazine = Console.ReadLine().Split(' ');

        string[] note = Console.ReadLine().Split(' ');

        checkMagazine(magazine, note);
    }
}
