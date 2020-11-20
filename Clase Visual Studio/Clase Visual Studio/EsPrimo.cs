class Primo
{
        static bool sPrimo(int numero)
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
}