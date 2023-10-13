using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Bienvenido Usuario");

            int opcion;
            Console.WriteLine("\n ¿Qué deseas realizar?");
            Console.WriteLine("\n 1. Factorial");
            Console.WriteLine("\n 2. Matriz");
            //Console.WriteLine("\n 3. Actualizar");
            //Console.WriteLine("\n 4. Eliminar");
            //Console.WriteLine("\n 5. Carga masiva .txt");
            //Console.WriteLine("\n 6. Carga masiva .Excel");

            opcion = int.Parse(Console.ReadLine());
            //int x;
            switch (opcion)
            {
                case 1:

                    //PL.Usuario.GetAll();

                    BL.Class1.Factorial();

                    break;

                case 2:

                    Console.Write("Las matrices son las siguientes: \n\n");
                    BL.Class1.Matriz();

                    //int[,] matriz1 = 
                    //{
                    //    {1, 2, 3},
                    //    {4, 5, 6},
                    //    {7, 8, 9}
                    //};

                    //int[,] matriz2 = 
                    //{
                    //    {1, 1, 1},
                    //    {5, 6, 1},
                    //    {7, 8, 1}
                    //};

                    int[,] resultado = BL.Class1.SumarMatrices( );

                    Console.WriteLine("Resultado de la suma de las matricez es:");

                    for (int i = 0; i < resultado.GetLength(0); i++)
                    {
                        for (int j = 0; j < resultado.GetLength(1); j++)
                        {
                            Console.Write(resultado[i, j] + " ");
                        }
                        Console.WriteLine();
                    }
                    break;

                //case 3:

                //    break;

                default:
                    Console.WriteLine("\n No es una opcion validad");
                    break;

            }
            Console.ReadKey();
        }
    }
}
