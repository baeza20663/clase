static void Main(string[] args)
        {
            int num = 3;
            if(EsPrimo(num))
            {
                //Es un número primo
            }
            else
            {
                //No es un número primo
            }
        }
        static bool EsPrimo(int numero)
        {
            for (int i = 2; i < numero; i++)
            {
                if((numero % i) == 0)
                {
                    // No es primo :(
                    return false;
                }
            }
            // Es primo :)
            return true;
        }
