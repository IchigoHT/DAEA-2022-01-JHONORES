using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {   //Suma
        static int Suma(int a, int b)
        {
            return a + b;
        }
        //Resta
        static int Resta(int a, int b)
        {
            return a - b;
        }
        //Multiplicacion
        static int Multiplicacion(int a, int b)
        {
            return a * b;
        }

        //Division
        static dynamic Division(double a, double b)
        {
            if (b == 0)
            {
                return "No se puede dividir con 0 siendo divisor  ";
            }
            double div = 0;

            div = (a / b);
            return div;
        }

        // F° a C°
        static int F(int c)
        {
            return (5 * (c - 32) / 9);
        }

        // C° a F°
        static int C(int f)
        {
            return ((9 * f) / 5) + 32;
        }

        //numeros primos
        static void Nprimos()
        {
            //variable que contiene el numero que se está probando
            int n = 2;
            //variable que contiene el total de numeros primos encontrados
            int total = 1;

            //iterar mientras el total de numeros primos no se mayor a 100
            while (total <= 10)
            {

                //variable que indica si un numero es primo o no
                bool esPrimo = true;

                //se divide el numero (n) entre todos los numeros anterios a el
                //si el modulo de la division es 0 significa que el numero no es primo
                //y se marca la variable esPrimo = false y se termina el ciclo for
                for (int i = 2; i < n; i++)
                {
                    if (n % i == 0)
                    {
                        esPrimo = false;
                        break;
                    }

                }

                //si despues de ejecutar el ciclo for la variable esPrimo sigue
                //teniendo un valor true entonces se imprime el numero y se incrementa
                // el contador de numeros encontrados total++
                if (esPrimo)
                {
                    Console.WriteLine(n);
                    total++;
                }
                //se incrementa para evaluar el siguiente número
                n++;
            }
        }
        static void Raiz()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("La raiz cuadrada de {0} es :{1}", i, Math.Sqrt(i));
            }
        }

        static void Main(string[] args)
        {
            Console.Title = "Procedimientos y funciones";
            string opcion;
            do
            {
                Console.Clear();
                Console.WriteLine("[1] Suma de dos números");
                Console.WriteLine("[2] Imprimir la raíz cuadrada de los 10 primeros números enteros");
                Console.WriteLine("[3] Resta de dos números");
                Console.WriteLine("[4] Multiplicacion de dos números");
                Console.WriteLine("[5] Division de dos números");
                Console.WriteLine("[6] Conversion de temperatura C° a F°");
                Console.WriteLine("[7] Conversion de temperatura F° a C°");
                Console.WriteLine("[8] Los 10 primeros numeros primos");
                Console.WriteLine("[0] Salir");
                Console.WriteLine("Ingrese una opción y presione ENTER");
                opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "1":
                        Console.WriteLine("Ingrese el primer número");
                        int a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        int b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La suma de {0} y {1} = {2}", a, b, Suma(a, b));
                        Console.ReadKey();
                        break;
                    case "2":
                        Console.WriteLine("Calculando...");
                        Raiz();
                        Console.ReadKey();
                        break;
                    case "3":
                        Console.WriteLine("Ingrese el primer número");
                        int a3 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        int b3 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La resta de {0} y {1} = {2}", a3, b3, Resta(a3, b3));
                        Console.ReadKey();
                        break;
                    case "4":
                        Console.WriteLine("Ingrese el primer número");
                        int a4 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        int b4 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La Multiplicacion de {0} y {1} = {2}", a4, b4, Multiplicacion(a4, b4));
                        Console.ReadKey();
                        break;
                    case "5":
                        Console.WriteLine("Ingrese el primer número");
                        int a5 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        int b5 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La Division de {0} y {1} = {2}", a5, b5, Division(a5, b5));
                        Console.ReadKey();
                        break;
                    case "6":
                        Console.WriteLine("Ingrese la temperatura en Celsios para convertirla a Fahrenheit");
                        int c6 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("{0} Celsios son {1} Fahrenheit", c6, C(c6));
                        Console.ReadKey();
                        break;
                    case "7":
                        Console.WriteLine("Ingrese la temperatura en Fahrenheit para convertirla a Celsios");
                        int f6 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("{0} Fahrenheit son {1} Celsios", f6, F(f6));
                        Console.ReadKey();
                        break;
                    case "8":
                        Console.WriteLine("Calculando...");
                        Nprimos();
                        Console.ReadKey();
                        break;


                }
            } while (!opcion.Equals("0"));

        }
        /*
        static void Main(string[] args)
        {
         Console.WriteLine("Programa lab 01");
         Raiz();
         Console.ReadKey();
         Console.ReadKey();
         }
        */
    }
}

