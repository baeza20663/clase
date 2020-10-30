namespace Clase_Visual_Studio
{
    class EjerciciosExamen
    {
        public static int Sumar2(int suma1, int suma2)
        {
            return suma1 + suma2;
        }
        public static double Reales2(double real1,double real2)
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
        public static string AddCadenas(string str1, string str2,string str3)
        {
           return str1 + str2 + str3;
        }
        // public static string Compare2Integer(int number1, int number2)
        
                 // if (number1 < number2) 
                 // return a < b;
        
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

            while (true)
            {
                System.Console.Write(sumando + ",");
                sumando = sumando + 3;
                if (sumando >= number) break;
            }

        }
        public static void Add1(int number)
        {
                        
            for (int contador = 0; contador <= number ; contador++ )
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

    }

}
