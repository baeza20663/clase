namespace Clase_Visual_Studio
{
    class Geometry
    {
        public static double GetVector2DLength(double x, double y)
        {
            double aux;
            double length;

            aux = x * x + y * y;
            length = System.Math.Sqrt(aux);
            return length;
        }

    }
    class Geometry3d
    {
        public static double GetVector3DLength(double x2, double y2, double z2)
        {
            double aux;
            double length;

            aux = x2 * x2 + y2 * y2 + z2 * z2;
            length = System.Math.Sqrt(aux);
            return length;
        }
    }
    class GeometryCircle
    {
        public static double GetCircle(double r)
        {
            double aux;
            double area;

            aux = r * r;
            area = System.Math.PI * aux;
            return area;
        }
    }
    class GeometrySquare
    {
        public static double GetSquare(double base2, double height2)
        {
            double area2;

            area2 = base2 * height2;
            return area2;
        }
    }
    class GeometryElipse
    {
        public static double GetElipse(double radiomenor, double radiomayor)
        {
            double area3;
            area3 = radiomenor * radiomayor * System.Math.PI;
            return area3;
        }
        
    }
}