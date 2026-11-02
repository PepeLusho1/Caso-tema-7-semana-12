using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caso_tema_7_semana_12
{
    internal class Program
    {
        static public void numeros_naturales()
        {
            Console.Write("Ingresar numero de N: ");
            int N = int.Parse(Console.ReadLine());
            int S = 0;
            for (int C = 1; C <= N; C++)

            {
                S = S + C;
            }
            Console.WriteLine("La suma es: " + S);
        }
        static public int sumaNN_con_recursividad(int N)
        {
            if (N == 0)
            {
                return 0;
            }
            return N + sumaNN_con_recursividad(N-1);
        }
        static public int sumaNP_con_recursividad(int N)
        {
            if (N == 0)
            {
                return 0;
            }
            return N + sumaNP_con_recursividad(N - 2);
        }
        static public int factorial(int N)
        {
            if (N == 1)
            {
                return 1;
            }
            return N * factorial(N - 1);
        }
        static public int exponente(int a, int ex)
        {
            if (ex == 1)
            {
                return a;
            }
            return a * exponente(a, ex - 1);
        }
        static public void conteo_regresivo(int N)
        {
            if (N < 0)
            {
                return;
            }
            Console.WriteLine(N);
            conteo_regresivo(N - 1);
        }
        static public int suma_arreglos(int[] numeros, int indice)
        {
            if (indice >= numeros.Length)
            {
                return 0;
            }
            return numeros[indice] + suma_arreglos(numeros, indice+1);
        }
        static void Main(string[] args)
        {
            int opc = 0;
            bool valor = true;
            while (valor)
            {
                Console.Clear();
                Console.WriteLine
                    ("*********************************");
                Console.WriteLine("\t\tMenu de opciones");
                Console.WriteLine
                    ("*********************************");
                Console.WriteLine("[1] Suma de N numeros naturales");
                Console.WriteLine("[2] Suma de N numeros naturales con recursividad");
                Console.WriteLine("[3] Suma de N numeros pares con recursividad");
                Console.WriteLine("[4] Factorial");
                Console.WriteLine("[5] Potencia");
                Console.WriteLine("[6] Conteo progresivo");
                Console.WriteLine("[7] Arreglos");
                Console.WriteLine("[8] Salir");
                Console.WriteLine
                    ("**********************************");
                opc = int.Parse(Console.ReadLine());
                switch (opc)
                {
                    case 1:
                        numeros_naturales();
                        int S = int.Parse(Console.ReadLine());
                        Console.WriteLine("La suma es: " + S);
                        break;
                    case 2:
                        Console.Write("Ingresar el numero N: ");
                        int N = int.Parse(Console.ReadLine());
                        Console.WriteLine("La suma es: " + sumaNN_con_recursividad(N));
                        break;
                    case 3:
                        Console.WriteLine("Ingresar el numero N: ");
                        int N1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("La suma de pares es: " + sumaNP_con_recursividad(N1));
                        break;
                    case 4:
                        Console.WriteLine("Ingresar el numero: ");
                        int N2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("El factorial es: " + factorial(N2));
                        break;
                    case 5:
                        Console.WriteLine("Ingresar base: ");
                        int a = int.Parse(Console.ReadLine());
                        Console.Write("Ingresar exponente: ");
                        int ex = int.Parse(Console.ReadLine());
                        Console.WriteLine(a + "^" + ex + "=" + exponente(a, ex));
                        break;
                    case 6:
                        int N3;
                        N3 = int.Parse(Console.ReadLine());
                        conteo_regresivo(N3);
                        break;
                    case 7:
                        int[] numeros = {10, 15, 20, 25, 30};
                        Console.WriteLine("la suma del arreglo es: " + suma_arreglos(numeros, 0));
                        break;
                    case 8:
                        valor = false;
                        Console.WriteLine("Saliendo del programa...!!");
                        break;
                    default:
                        Console.WriteLine("Opcion no valida..!");
                        break;
                }
            }
            Console.ReadKey();
        }
    } 
}
