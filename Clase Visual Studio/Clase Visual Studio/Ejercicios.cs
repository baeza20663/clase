namespace Clase_Visual_Studio
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
    }
}
