using System;

namespace Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write the first matrix raw size and when done Press 'Enter': ");
            int rowA = int.Parse(Console.ReadLine());
            Console.Write("Write the first matrix column size and when done Press 'Enter': ");
            int colA = int.Parse(Console.ReadLine());
            int[,] arr = new int[rowA, colA];
            
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                Console.Write("Enter arrays elements for raw n.o "+(i+1).ToString()+ " with "+arr.GetLength(1)+" number of elements. Use spacebar to seperate the raw elements. \nYou may Enter row elements now and ");
                Console.Write("Press Enter if done: ");

                string[] arrValues = Console.ReadLine().Split(" ");
                int j = 0;
                for (j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i,j] = Int32.Parse(arrValues[j]);
                   
                }
               // Console.WriteLine();
                if(arrValues.Length > j)
                {
                    Console.WriteLine("You've entered more than expected row "+i+ " elements, therefore the following delimited elements will be removed from row " +i+" :");
                    for(int jk = j; jk < arrValues.Length; jk++)
                    {
                        Console.Write(arrValues[jk] + " ");

                    }
                    Console.WriteLine();

                }
            }
            Console.WriteLine();
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i,j]+" ");
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
