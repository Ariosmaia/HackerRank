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

    // Complete the solve function below.
    static int[] Solve(int[] a, int[] b)
    {
        int countA = 0;
        int countB = 0;
        

        for (int i = 0; i < 3; i++)
        {
            if (a[i] > b[i])
            {
                countA++;

            }
            else if (a[i] < b[i])
            {
                countB++;
                
            }

            
        }
        int[] resultado = { countA, countB };
        return resultado;

    }

    static void Main(string[] args)
    {
       

        int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp))
        ;

        int[] b = Array.ConvertAll(Console.ReadLine().Split(' '), bTemp => Convert.ToInt32(bTemp))
        ;


        int[] result = Solve(a, b);

        Console.WriteLine(string.Join(" ", result));

        
    }
}
