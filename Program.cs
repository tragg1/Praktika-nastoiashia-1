namespace Practika1
{
    class Point
    {
        public double X;
        public double Y;
        public double Z;

        
        public Point()
        {
            X = 0;
            Y = 0;
            Z = 0;
        }

       
        public Point(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

       
        public void MoveBy(double dx, double dy, double dz)
        {
            X += dx;
            Y += dy;
            Z += dz;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите X: ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите Y: ");
            double y = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите Z: ");
            double z = Convert.ToDouble(Console.ReadLine());

            Point p1 = new Point(x, y, z);

            Console.Write("Введите dx: ");
            double dx = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите dy: ");
            double dy = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите dz: ");
            double dz = Convert.ToDouble(Console.ReadLine());

            p1.MoveBy(dx, dy, dz);

            Console.WriteLine($"Первая точка: X={p1.X}, Y={p1.Y}, Z={p1.Z}");

            
            Point p2 = new Point(1, 2, 3);
            p2.MoveBy(4, 5, 6);

            Console.WriteLine($"Вторая точка: X={p2.X}, Y={p2.Y}, Z={p2.Z}");

            Console.ReadLine();
        }
    }
}
