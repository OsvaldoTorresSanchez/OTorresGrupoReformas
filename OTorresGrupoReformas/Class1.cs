using System;
using System.Collections.Generic;
using System.Data;
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

        public static void Calculadora()
        {
            while (true)
            {
                Console.WriteLine("Calculadora básica");
                Console.WriteLine("\n 1. Suma");
                Console.WriteLine("\n 2. Resta");
                Console.WriteLine("\n 3. Multiplicación");
                Console.WriteLine("\n 4. División");
                Console.WriteLine("\n 5. Salir");


                int opcion;
                opcion = int.Parse(Console.ReadLine());

                Console.Write("Por favor digite un número entero positivo: ");
                int num1 = int.Parse(Console.ReadLine());

                Console.Write("Por favor digite un segundo número entero positivo: ");
                int num2 = int.Parse(Console.ReadLine());

                double resultado = 0;

                switch (opcion)
                {
                    case 1: // Suma
                        resultado = num1 + num2;
                        break;
                    case 2: // Resta
                        resultado = num1 - num2;
                        break;
                    case 3: // Multiplicación
                        resultado = num1 * num2;
                        break;
                    case 4: // División
                        if (num2 != 0)
                        {
                            resultado = num1 / num2;
                        }
                        else
                        {
                            Console.WriteLine("No se puede dividir por cero.");
                            continue;
                        }
                        break;
                    default:
                        Console.WriteLine("\n No es una opcion validad");
                        break;
                }

                Console.WriteLine("El resultado es: " + resultado);
            }
        }

        public static void Piramide()
        {

            Console.Write("Por favor digite un número entero positivo: ");
            int nivel = int.Parse(Console.ReadLine());

            for (int i = 1; i <= nivel; i++)
            {
                // Imprimir espacios en blanco (alineación a la derecha)
                for (int j = 1; j <= nivel - i; j++)
                {
                    Console.Write(" ");
                }

                // Imprimir asteriscos
                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    Console.Write("*");
                }

                Console.WriteLine(); // Salto de línea para la siguiente fila
            }
        }

        public static void TablasMultiplicar()
        {
            Console.Write("Ingresa la tabla de multiplicar que quieres tener :");
            int numero = int.Parse(Console.ReadLine());

            Console.WriteLine("Tablas de multiplicar del :" + numero);

            for (int i = 1; i <= 10; i++)
            {
                int resultado = numero * i;

                Console.WriteLine(numero + "x" + i + "=" + resultado);
            }
        }

        public static void NumeroParesNones()
        {
            Console.WriteLine("Elija qué desea mostrar:");

            Console.WriteLine("1. Primeros 100 números pares ");

            Console.WriteLine("2. Primeros 100 números impares");

            int opcion = int.Parse(Console.ReadLine());

            if (opcion == 1)
            {
                Console.WriteLine("Primeros 100 números pares:");
                for (int i = 2; i <= 100 * 2; i += 2)
                {
                    Console.Write(i + " ");
                }
            }
            else
            {
                Console.WriteLine("Primeros 100 números impares:");

                for (int i = 1; i <= 100 * 2; i += 2)
                {
                    Console.WriteLine(i + " ");
                }
            }
        }

        public static void FormulaGeneral()
        {
            Console.WriteLine("Resolución de una ecuación de segundo grado  con la formula geral (-b +-raiz b^2 -4ac)/2a");

            Console.Write("Ingrese el coeficiente A: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el coeficiente B: ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el coeficiente C: ");
            int c = int.Parse(Console.ReadLine());

            //Hacer primero la raiz que esta dentro 
            double resultado = b * b - 4 * a * c;

            if (resultado > 0)
            {
                // Math.Sqrt es para sacar la raiz
                double x1 = (-b + Math.Sqrt(resultado)) / (2 * a);

                double x2 = (-b - Math.Sqrt(resultado)) / (2 * a);
                Console.WriteLine("Las solucion de x1 = " + x1 + " y de x2 = " + x2);
            }

        }

        public static void TablaTienda()
        {

            // Crear un nuevo DataTable con dos columnas
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("TiendaID", typeof(int));
            dataTable.Columns.Add("Tienda", typeof(string));

            int IdTienda = 1; // Iniciar con el ID en 1

            Console.WriteLine("Ingrese el nombre de la tienda o escribe la palabra 'exit' para salir :");

            while (true)
            {
                Console.Write("Nombre de la tienda: ");
                string nombre = Console.ReadLine();

                if (nombre.ToLower() == "exit")
                {
                    break;
                }

                DataRow row = dataTable.NewRow();
                row["TiendaID"] = IdTienda;
                row["Tienda"] = nombre;
                dataTable.Rows.Add(row);
                IdTienda++; // Incrementar el ID 
            }

            Console.WriteLine("Tabla de Tiendas:");
            Console.WriteLine("ID   Nombre");
            DataRow[] tiendas = dataTable.Select();
            foreach (var tienda in tiendas)
            {
                //El numero -4 es valor de los espacion en cadenas 
                Console.WriteLine($"{tienda["TiendaID"],-4} {tienda["Tienda"]}");
            }
        }

    }
}
