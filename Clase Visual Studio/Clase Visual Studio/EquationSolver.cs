namespace Clase_Visual_Studio
{
    class EquationSolver
    {
        public static double SolveEquation2(double a, double b, double c)
        {
            double aux, root, solution;

            aux = b * b - 4.0 * a * c;
            root = System.Math.Sqrt(aux);
            solution = (-b + root) / (2.0 * a);
            return solution;
        }

        public static double SolveEquation1(double a, double b)
        {
            double x;

            x = -b / a;
            return x;
        }
    }
}
