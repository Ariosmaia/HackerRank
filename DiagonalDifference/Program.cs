using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;



class Solution
{

    // Complete the diagonalDifference function below.
    static int diagonalDifference(int[][] a)
    {
        int pDiagonal = 0;
        int sDiagonal = 0;
        int index = a.Length;

        for (int i = 0; i < index; i++)
        {
            Console.WriteLine(a[i].Length);
            int j = a.Length - i - 1;
            pDiagonal += a[i][i]; 
            sDiagonal += a[i][j];
            

        }
        int total = Math.Abs(pDiagonal - sDiagonal);
        return total;
        
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Digite as linhas");
        int n = Convert.ToInt32(Console.ReadLine());

        int[][] a = new int[n][];

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Digite 3 numeros");
            a[i] = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp));
        }
        
        
        int result = diagonalDifference(a);

        Console.WriteLine(result);

        
    }
}
