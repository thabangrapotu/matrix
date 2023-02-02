using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;
using System.Globalization;
using Matrix;

namespace Matrix
{
    class Program
    {


        static void Main(string[] args)
        {
          
            Matrix.ProgramRef.SetConsoleWindowPosition(Matrix.ProgramRef.AnchorWindow.Fill);

        
            Console.Write("Matrix A Section\n- - - - -\n\n");
            Console.Write("Enter matrix A raw size and Press 'Enter' button to continue:\n");
            int rowA = int.Parse(Console.ReadLine());
            Console.Write("Enter matrix A column size and Press 'Enter' button to continue:\n");
            int colA = int.Parse(Console.ReadLine());
            decimal[,] arrA = new decimal[rowA, colA]; 

            int lenElement = 0;
            Console.WriteLine("\n ========= Moving to the Matrix A, raw {0} ============== ", 0.ToString());

            for (int i = 0; i < rowA; i++)
            {
                Console.WriteLine();
             
                for (int j = 0; j < colA; j++)
                {
                    Console.WriteLine("Enter Matrix A element at row {0} and column {1}: ", i.ToString(), j.ToString());
                    arrA[i, j] = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture.NumberFormat);

                    if (arrA[i,j].ToString().Length > lenElement)
                    {
                        lenElement = arrA[i, j].ToString().Length;
                    }



                }
                if (i < rowA - 1)
                {
                    Console.WriteLine("\n ========= Moving to the Matrix A, raw {0} ============== ",(i+1).ToString());
                }
            }


            //Get Matrix B
            Console.Write("\nMatrix B Section\n- - - - -\n");
            Console.Write("\nEnter matrix B raw size and Press 'Enter' button to continue:\n");
            int rowB = int.Parse(Console.ReadLine());
            Console.Write("Enter matrix B column size and Press 'Enter' button to continue:\n");
            int colB = int.Parse(Console.ReadLine());
            decimal[,] arrB = new decimal[rowB, colB];


            Console.WriteLine("\n========= Moving to the Matrix B, raw {0} ==============", 0.ToString());

            for (int i = 0; i < rowB; i++)
            {
                Console.WriteLine();
               
                for (int j = 0; j < colB; j++)
                {
                    Console.WriteLine("Enter Matrix B element at row {0} and column {1}: ", i.ToString(), j.ToString());
                    arrB[i, j] = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture.NumberFormat);


                    if (arrB[i, j].ToString().Length > lenElement)
                    {
                        lenElement = arrB[i, j].ToString().Length;
                    }


                }
                if (i < rowB - 1)
                {
                    Console.WriteLine("\n========= Moving to the Matrix B, raw {0} ==============",(i+1).ToString());
                }
            }

  
  
            //Printing Matrix product of Matrix A by B
            Console.WriteLine("The product of Matrix A by B = ");
            int greatRaws = arrA.GetLength(0) > arrB.GetLength(0) ? arrA.GetLength(0) : arrB.GetLength(0);

            
            for (int i = 0; i < greatRaws; i++)
            {

                int j = 0;
                if (i < arrA.GetLength(0))
                {
                    for (j= 0; j < arrA.GetLength(1); j++)
                    {
                        Console.Write(arrA[i, j] + new string(' ', lenElement - arrA[i,j].ToString().Length +1));
                    }
                }
                else
                {
                    Console.Write(new string(' ', lenElement*(arrA.GetLength(1))));
                }

                if (i == arrA.GetLength(0) / 2)
                {
                    Console.Write(new string(' ', lenElement - (arrA[i, j].ToString().Length + 1) / 4) + "By" + new string(' ', lenElement - (arrA[i, j].ToString().Length + 1) / 4));
                }
                else
                { 
                
                }
                if (i < arrB.GetLength(0))
                {

                    for (int k = 0; k < arrB.GetLength(1); k++)
                    {
                        if (k == 0)
                        {
                            Console.Write(arrB[i, k]);
                        }
                        else
                        {
                            Console.Write(new string(' ', lenElement - arrB[i, k].ToString().Length + 1) + arrB[i, k]);
                        }
                    }
                }
                else
                {
                    //Console.Write(new string(' ', lenElement * (arrB.GetLength(1))));
                    continue;
                }
                Console.WriteLine();
            }




            // double[,] arrA = { { 1, 2, 3, 4 }, { 1, 3, 5, 7 }, { 2, 4, 6, 8 } };

            //  double[,] arrB = { { 7, 1 }, { 6, 4 }, { 2, 2 }, { 5, 5 } };

            decimal[,] arrC = new decimal[arrA.GetLength(0), arrB.GetLength(1)];


            decimal matrixVal = 0;

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

            Console.WriteLine("The Product of A matrix\x2098" + rowA + " x " + colA + " by B matrix\x2098" + rowB + " x " + colB + " =");
            for (int i = 0; i < arrC.GetLength(0); i++)
            {
                for (int j = 0; j < arrC.GetLength(1); j++)
                {
                    Console.Write(arrC[i, j].ToString() + new string(' ',lenElement));
                }
                Console.WriteLine("");
            }


        }
    }
}
