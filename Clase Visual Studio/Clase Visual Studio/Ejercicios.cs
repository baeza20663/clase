﻿namespace Clase_Visual_Studio
{
    class Ejercicios
    {
        // ejercicio: Haz una función que imprima por pantalla 
        // los números desde el 0 hasta el 99
        public static void Ejercicio1()
        {
            int x;
            x = 0;
            
           while (x < 100)
            {
                System.Console.Write(x + "-");
                x = x + 1;
            }
        }
        public static void GetMultiResult(double mult1, double mult2)
        {
            double total;
            if (mult1 == 0) System.Console.WriteLine("Multiplicar por CERO da CERO");
            else
                if (mult2 == 0)
                System.Console.WriteLine("Multiplicar por CERO da CERO");
            else
            {


                total = mult1 * mult2;
                        System.Console.WriteLine("Resultado de la multiplicación es :" + total);
            }
        }
    }
}
