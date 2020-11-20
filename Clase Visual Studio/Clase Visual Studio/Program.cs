namespace Clase_Visual_Studio
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            x = 1;
            while (x > 0)
            {
                x = System.Convert.ToInt32(System.Console.ReadLine());
            
                EjerciciosExamen.Sumatorio(x);
            }
            System.Console.WriteLine("Se acabó");
            
        }
    }
}


        
        
