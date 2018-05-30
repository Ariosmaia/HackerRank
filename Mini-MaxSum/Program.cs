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

    // Complete the miniMaxSum function below.
    static void miniMaxSum(int[] arr)
    {
        var soma = 0L;
        var minimo = long.MaxValue; //Valor maximo possivel
        var maximo = 0L; 

        for (int i = 0; i < arr.Length; i++)
        {
            soma += arr[i];// 0 => 0 + 1=1 | 1 => 1 + 2=3 | 2 => 3 + 3=6 | 3 => 6 + 4=10 | 4 => 10 + 5=15
            if (arr[i] < minimo) // 1 menor valor maximo=t | 2 menor 1=f | 3 menor 1=f | 4 menor 1=f | 5 menor 1=f
                minimo = arr[i]; // 1

            if (arr[i] > maximo)// 1 maior 0=t | 2 maior 1=t  | 3 maior 2=t | 4 maior 3=t | 5 maior 4=t
                maximo = arr[i];// 1 | 2 | 3 | 4 | 5

           
        }

        Console.WriteLine($"{soma - maximo} {soma - minimo}"); // 15 - 5 = 10  ||  15 - 1 = 14 

    }

    static void Main(string[] args)
    {
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
            ;
        miniMaxSum(arr);
    }
}