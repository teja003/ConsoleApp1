using System.Transactions;
using System;

namespace ProblemSolving
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[,] arr = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            int col = 3;
            int row = 3;
            SpiralMatrix(arr, row, col);
            int[] stockArr = { 7, 1, 5, 3, 6, 4 };
            MaxProfit(stockArr);
            RotateMatrix(arr, row,col);
        }


        public static void RotateMatrix(int[,] mat, int row, int col)
        {
            List<List<int>> res = new();
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                List<int> r = new();
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    r.Add(mat[i, j]);
                }
                res.Add(r);
            }

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    (res[i][j], res[j][i]) = (res[j][i], res[i][j]);
                }
            }

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col / 2; j++)
                {
                    int firstIdx = j, secondIdx = col - 1 - j;
                    (res[i][firstIdx], res[i][secondIdx]) = (res[i][secondIdx], res[i][firstIdx]);
                }
            }

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write(res[i][j] + " ");
                }
                Console.WriteLine();
            }
        }

        public static void SpiralMatrix(int[,] arr, int row, int col)
        {
            int cr = 0;
            int cc = 0;
            while(cr<row && cc < col)
            {
                for(int i = cc; i<col; i++)
                {
                    Console.Write(arr[cr,i]+" ");
                }
                cr++;
                for(int i = cr; i < row; i++)
                {
                    Console.Write(arr[i,col-1]+" ");
                }
                col--;
                if (cr < row)
                {
                    for (int i = col - 1; i >= cc; i--)
                    {
                        Console.Write(arr[row - 1, i] + " ");
                    }
                    row--;
                }
                if (cc < col)
                {
                    for (int i = row - 1; i >= cr; i--)
                    {
                        Console.Write(arr[i, cc] + " ");
                    }
                    cc++;
                }
            }

        }

        public static void MaxProfit(int[] arr)
        {
            /*            You are given an array prices where prices[i] is the price of a given stock on the ith day.
                          You want to maximize your profit by choosing a single day to buy one stock and choosing a different day in the future to sell that stock.
                        Return the maximum profit you can achieve from this transaction.If you cannot achieve any profit, return 0.
                        Input: prices = [7, 1, 5, 3, 6, 4]
                        Output: 5
                        Explanation: Buy on day 2(price = 1) and sell on day 5(price = 6), profit = 6 - 1 = 5.
                        Note that buying on day 2 and selling on day 1 is not allowed because you must buy before you sell.
            */
            int max = 0;
            for(int i = 0; i < arr.Length-1; i++)
            {
                for(int j=i+1; j<arr.Length; j++)
                {
                    if (arr[j] - arr[i] > 0)
                    {
                        if (arr[j] - arr[i] > max)
                        {
                            max = arr[j] - arr[i];
                        }
                    }
                }
            }
            Console.WriteLine("The max profit is "+max);
        }
    }
}
