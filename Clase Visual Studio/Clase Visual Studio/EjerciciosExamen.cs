using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clase_Visual_Studio
{
    class EjerciciosExamen
    {
        public static int Sumar2(int suma1, int suma2)
        {
            return suma1 + suma2;
        }
        public static double Reales2(double real1, double real2)
        {
            return real1 - real2;
        }
        public static double Menor2Reales(double real1, double real2)
        {
            if (real1 < real2)
                return real1;
            else
            if (real2 < real1)
                return real2;
            else
                return 0;
        }
        public static string AddCadenas(string str1, string str2, string str3)
        {
            return str1 + str2 + str3;
        }
        public static int Compare2Integer(int number1, int number2)
        {
            if (number1 < number2)
                return number2;
            else return number1;

        }



        public static int Compare2numbers(int number1, int number2)
        {
            if (number1 == number2) return 0;
            else
                if (number1 < number2) return -1;
            else return 1;
        }
        public static double Compare2Reals(double number1, double number2)
        {
            if (number1 < number2) return number2 * number2;
            else
                if (number1 > number2) return number1 * 2 + number2;
            else return 0;
        }
        public static void ShowError(int error)
        {
            switch (error)
            {
                case 0:
                    System.Console.WriteLine("Error Grave");
                    break;
                case 1:
                    System.Console.WriteLine("Error Moderado");
                    break;
                case 2:
                    System.Console.WriteLine("Error Leve");
                    break;

                default:
                    System.Console.WriteLine("Error Desconocido");
                    break;
            }
        }
        public static void Add3(int number)
        {
            int sumando;
            sumando = 0;
            System.Console.WriteLine("funcion (" + number + ")");

            while (true) // este ejercicio es mejor hacerlo con un for
            {
                System.Console.Write(sumando + ",");
                sumando = sumando + 3;
                if (sumando >= number) break;
            }

        }
        public static void Add1(int number)
        {

            for (int contador = 0; contador <= number; contador++)
            {
                System.Console.Write(contador);
                if (contador < number)
                {
                    System.Console.Write(",");

                }
                else System.Console.Write(".");

            }


        }
        public static void AsteriskLine(int number)
        {
            for (int contador = 0; contador < number; contador++)
            {
                System.Console.Write("*");

            }
        }
        public static void AsteriskPatreon(int number)
        {
            string bandera;
            bandera = "+";

            for (int contador = 0; contador < number; contador++)
            {
                System.Console.Write(bandera);

                if (bandera == "+")
                    bandera = "*";
                else
                    bandera = "+";

            }
        }
        public static void Symbols3(int number)
        {
            for (int contador = 0; contador < number; contador++)
            {
                int resto = contador % 4;
                switch (resto)
                {
                    case 0:
                        System.Console.Write("-");
                        break;

                    case 1:
                        System.Console.Write("+");
                        break;

                    case 2:

                        System.Console.Write("*");
                        break;

                    default:

                        System.Console.Write("/");
                        break;
                }
            }
        }
        public static void ConvertDecimalToBinary()
        {
            int contador;
            contador = 0;
            double dividendo;
            System.Console.Write("Introduce el número decimal a convertir a binario:");
            dividendo = System.Convert.ToInt32(System.Console.ReadLine());
            double resto;
            double cociente;
            string resultado;
            resultado = "";
            while (dividendo > 0)
            {
                resto = dividendo % 2;
                cociente = Math.Floor(dividendo / 2);
                System.Console.Write(resto);
                resultado = resultado + (resto);
                dividendo = cociente;
                contador++;
            }

            System.Console.WriteLine("");
            System.Console.WriteLine("El resultado es: " + "'" + resultado + "'");
            System.Console.WriteLine("Son " + contador + " dígitos");



            for (int contador3 = resultado.Length; contador3 > 0; contador3--)
            {

                System.Console.Write(resultado.Substring(contador3 - 1, 1));
                // contador3--;
            }
        }
        public static void PrintAsteriskMatrix()
        {
            int n;
            System.Console.Write("Introduce el número de columnas:");
            n = Convert.ToInt32(System.Console.ReadLine());

            for (int f = 0; f < 10; f++)
            {

                for (int c = 0; c < 15; c += 1)
                {
                    int suma = f + c;
                    if ((suma % 2 == 0))
                        System.Console.Write("+");

                    else System.Console.Write(" ");

                } // fin del contador de COLUMNAS c

                System.Console.WriteLine();
            }  // fin del contador de FILAS f              

        }

        public static void Ejercicio2231()
        {
            int n;
            for (n = 10; n < 21; n++)
            {
                System.Console.WriteLine("N vale:" + n);
            }
            
        }
        public static void Ejercicio2232()
        {
            int n;
            for (n = 1; n < 51; n = n+2)
            {
                System.Console.WriteLine("N vale:" + n);
            }

        }
        public static void Ejercicio22313()
        {
            int n;
            for (n = 100; n < 200; n++ )
            {
                if ((n%7) == 0 && (n%3) == 0)
                    System.Console.WriteLine("N vale:" + n);
            }

        }
        public static void Ejercicio2234()
        {
            int n;
            for (n = 0; n < 11; n++)
            {
                
                    System.Console.WriteLine("9x" + n + "=" + n*9);
            }

        }
        public static void Ejercicio2235()
        {
            int n;
            for (n = 1; n < 9; n++)
            {

                System.Console.WriteLine(n * 2);
            }

        }
        public static void Ejercicio2236()
        {
            int n;
            for (n = 15; n > 0; n--)
            {

                System.Console.WriteLine(n);
            }

        }
        public static void Ejercicio2241()
        {
            while (true)
            {
                System.Console.Write("Hola y ");
            }
        }
        public static void Ejercicio2242()
        {
            int contador = 1;

            while (true)
            {
                for (int c = 0; c < 500000000; c++) // temporizador para que aparezcan más lentos
                { 
                }

                
                System.Console.Write(contador + ",");
                contador++;
            }

        }
        public static void Ejercicio2251()
        {
            for (int d = 1; d < 5; d++)
            {


                for (int c = 1; c < 6; c++)
                {

                    System.Console.Write(c);

                }
                System.Console.Write("/");
            }
            

        }
        public static void Ejercicio2252()
        {
            for (int d = 1; d < 5; d++)
            {
                int c = 1;

                while (c < 6)
                {

                

                    System.Console.Write(c);
                    c++;
                }

                System.Console.Write("/");
            }


        }
        public static void Ejercicio2253()
        {
            for (int d = 10; d < 21; d++)
            {
                

                   
                    if (d%5 == 0 || d%7 == 0 || d%6 == 0) 
                    System.Console.WriteLine(d + " es múltiplo de 5,6 ó 7");
                   
            }
            System.Console.WriteLine();

        }
    }


    

}
