using System;

namespace Matrix
{
    class Program
    {
        static void Main(string[] args)
        {

            int[,] arr = new int[3,2];
            int arrVal = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                Console.WriteLine("Enter arrays for raw "+i+1);
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arrVal = Int32.Parse(Console.ReadLine());
                     arr[i, j] = arrVal;
                    Console.Write(" ");
                }
                Console.WriteLine();
            }

            int[,] arrA = { { 1, 2, 3, 4 }, { 1, 3, 5, 7 }, { 2, 4, 6, 8 } };

            int[,] arrB = { { 7, 1 }, { 6, 4 }, { 2, 2 }, { 5, 5 } };

            int[,] arrC = new int[arrA.GetLength(0),arrB.GetLength(1)];
          

            int matrixVal = 0;

            int colCount = 0;
            
            for (int i = 0; i < arrA.GetLength(0); i++)
            {
                while (colCount < arrC.GetLength(1))
                {
                    for (int j = 0; j < arrB.GetLength(0); j++)
                    {
                        matrixVal += arrA[i, j] * arrB[j, colCount];
                    }
                    arrC[i, colCount] = matrixVal;
                    matrixVal = 0;
                    colCount += 1;
                }
                colCount = 0;
            }

            Console.WriteLine("Product");
            for (int i = 0; i < arrC.GetLength(0); i++)
            {
                for (int j = 0; j < arrC.GetLength(1); j++)
                {
                    Console.Write(arrC[i, j].ToString() + " ");
                }
                Console.WriteLine("");
            }


        }
    }
}
