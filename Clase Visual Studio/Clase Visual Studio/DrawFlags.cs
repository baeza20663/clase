using System;
using System.Collections.Generic;
using System.Text;

namespace Clase_Visual_Studio
{
    class DrawFlags
    {
        public static void JapanFlag()
        {


            int f;

            for (f = 0; f < 16; f++)
            {

                for (int c = 0; c < 51; c++)
                {
                    double distance;
                    distance = Geometry.GetDistance2D(f, c, 7, 25);

                    if (f == 0 || f == 15 || c == 0 || c == 50 || distance < 5)
                    {
                        System.Console.BackgroundColor = System.ConsoleColor.White;
                        System.Console.ForegroundColor = System.ConsoleColor.Red;
                        System.Console.Write("*");
                    }

                    else System.Console.Write(" ");


                    
                }
                System.Console.WriteLine();
                System.Console.ResetColor();

               
            }
        }
    }
}
    


