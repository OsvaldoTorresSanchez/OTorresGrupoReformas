using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Class1
    {

        public static int Factorial()
        {
            Console.Write("Por favor digite un número entero positivo: ");
            int num = int.Parse(Console.ReadLine());

            int fact = 1;
            for (int i = 1; i <= num; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine("\nEl Factorial de " + num + " es: " + fact);
            return fact;
        }

        public static int Matriz()
        {
            int[,,] students1 = new int[2, 3, 4];

            //Matriz 1
            students1[0, 0, 0] = 1;
            students1[0, 0, 1] = 2;
            students1[0, 0, 2] = 3;

            students1[0, 1, 0] = 4;
            students1[0, 1, 1] = 5;
            students1[0, 1, 2] = 6;

            students1[0, 2, 0] = 7;
            students1[0, 2, 1] = 8;
            students1[0, 2, 2] = 9;

            int[,,] students = new int[2, 3, 4];

            //Matriz 2
            students[1, 0, 0] = 1;
            students[1, 0, 1] = 1;
            students[1, 0, 2] = 1;

            students[1, 1, 0] = 5;
            students[1, 1, 1] = 6;
            students[1, 1, 2] = 1;

            students[1, 2, 0] = 7;
            students[1, 2, 1] = 8;
            students[1, 2, 2] = 1;

            for (int x = 0; x < 2; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    for (int z = 0; z < 3; z++)
                    {

                        int resultado = students1[x, y, z] + students[x, y, z];
                        Console.Write($"{resultado}");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }

            return 0;
        }

        public static int[,] SumarMatrices()
        {

            int[,] matriz1 =
            { {1, 2, 3},{4, 5, 6}, {7, 8, 9} };

            int[,] matriz2 =
            { {1, 1, 1},{5, 6, 1},{7, 8, 1} };

            int filasMatriz1 = matriz1.GetLength(0);
            int filasMatriz2 = matriz1.GetLength(1);

            int[,] resultado = new int[filasMatriz1, filasMatriz2];

            for (int i = 0; i < filasMatriz1; i++)
            {
                for (int j = 0; j < filasMatriz2; j++)
                {
                    resultado[i, j] = matriz1[i, j] + matriz2[i, j];
                }
            }
            return resultado;
        }
    }
}
