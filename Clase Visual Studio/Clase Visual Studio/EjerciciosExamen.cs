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
    }

}
