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

    // Complete the aVeryBigSum function below.
    //static long aVeryBigSum(long[] ar, int arCount)
    //{
    //    long[] soma = new long[arCount];
    //    long totalSoma = 0;

    //    for (int i = 0; i < 5; i++)
    //    {

    //        totalSoma += soma[i] + ar[i];
            
    //    }

    //    return totalSoma;
    //}

    static void Main(string[] args)
    {

        //int arCount = Convert.ToInt32(Console.ReadLine());

        //long[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt64(arTemp))
        //;
        //long result = aVeryBigSum(ar, arCount);

        //Console.WriteLine(result);

        var finalSum = 0L;
        var n = int.Parse(Console.ReadLine());
        var ar_temp = Console.ReadLine().Split(' ');
        var ar = Array.ConvertAll(ar_temp, long.Parse);

        for (int i = 0; i < n; i++)
            finalSum += ar[i];

        Console.WriteLine(finalSum);


    }

}
