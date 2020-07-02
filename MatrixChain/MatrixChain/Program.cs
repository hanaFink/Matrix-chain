using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixChain
{
    class Program
    {
        static void Main(string[] args)
        {

            int[,] matrix = new int[10, 10];


            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = i + j;
                }
            }
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j]);
                }
                Console.WriteLine();
            }


                Handler Color = new ColorFilter();
                Handler Cone = new ConeFilter();
                Handler Resolution = new ResolutionFilter();
                Handler Figure = new FigureFilter();

            

                 Color.HandleRequest(matrix);
                Color.setNext(Cone);
                Cone.setNext(Resolution);
                Resolution.setNext(Figure);
                Figure.setNext(null);

                Handler Resolution1 = new ResolutionFilter();
                Handler Figure1 = new FigureFilter();

                Resolution1.HandleRequest(matrix);
                Resolution1.setNext(Figure1);
                Figure1.setNext(null);

         
                    }
                }
    }

