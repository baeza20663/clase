namespace Clase_Visual_Studio
{
    class EjerciciosBis
    {
        // ejercicio2: Haz una función que imprima por pantalla 
        // los números desde el 0 hasta el 99
        public static void Ejercicio2()
        {
            int i;
            i = 0;

            while (i < 100)
            {
                System.Console.Write(i + "-");
                i++;
            }
        }
        public static void Ejercicio3()
        {
            int i;
            int x;
            i = 0;
            x = 0;

            while (i < 100)
            {
                System.Console.Write(x + ",");
                x = x + 2;
                i++;
            }
        }
        public static void Ejercicio4()
        {
            int i;
            i = 0;

            while (i < 100)
            {
                System.Console.Write((i * 3) + 1 + ",");

                i++;

            }
        }
        public static void Ejercicio5()
        {
            int i;
            i = 0;

            while (i < 100)
            {
                System.Console.Write((i * i) + ",");
                i++;
            }
        }
        public static void Ejercicio6()
        {
            int i;
            i = 0;

            while (i < 100)
            {
                System.Console.Write(i + " ");
                i++;
                System.Console.Write(-i + " ");
                i++;
            }
        }
        

    }
}