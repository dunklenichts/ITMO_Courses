/* Ввести целочисленные координаты трех вершин прямоугольника, стороны которого параллельны координатным осям. 
 * Найти координаты его четвертой вершины. Если пользователь введёт координаты точек так, 
 * что нельзя получить прямоугольник со сторонами, параллельными координатным осям, вывести соответствующее сообщение */

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter x1: ");
        int x1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter x2: ");
        int x2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter x3: ");
        int x3 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter y1: ");
        int y1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter y2: ");
        int y2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter y3: ");
        int y3 = Convert.ToInt32(Console.ReadLine());

        int x4;
        int y4;

        if (x1 == x2 & x1 == x3)
        {
            Console.WriteLine("Not parallel");
            Environment.Exit(0);
        }

        if (x1 == x2)
        {
            if (y1 == y2 & y1 == y3)
            {
                Console.WriteLine("Not parallel");
                Environment.Exit(0);
            }
            if (y2 == y3 || y1 == y3)
            {
                x4 = x3;
                y4 = y1;
                Console.WriteLine("x4 = {0}, x4 = {1}", x4, y4);
                Environment.Exit(0);
            }
            if (y1 != y2 || y1 != y3 || y2 != y3)
            {
                Console.WriteLine("Not parallel");
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Not parallel");
                Environment.Exit(0);
            }
        }

        if (x1 == x3)
        {
            if (y1 == y2 & y1 == y3)
            {
                Console.WriteLine("Not parallel");
                Environment.Exit(0);
            }
            if (y1 == y2 || y3 == y2)
            {
                x4 = x2;
                y4 = y3;
                Console.WriteLine("x4 = {0}, x4 = {1}", x4, y4);
                Environment.Exit(0);
            }
            if (y1 != y2 || y1 != y3 || y2 != y3)
            {
                Console.WriteLine("Not parallel");
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Not parallel");
                Environment.Exit(0);
            }
        }

        if (x2 == x3)
        {
            if (y1 == y2 & y1 == y3)
            {
                Console.WriteLine("Not parallel");
                Environment.Exit(0);
            }
            if (y3 == y1 || y2 == y1)
            {
                x4 = x1;
                y4 = y2;
                Console.WriteLine("x4 = {0}, x4 = {1}", x4, y4);
                Environment.Exit(0);
            }
            if (y1 != y2 || y1 != y3 || y2 != y3)
            {
                Console.WriteLine("Not parallel");
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Not parallel");
                Environment.Exit(0);
            }
        }

        if (x1 != x2 || x1 != x3 || x2 != x3)
        {
            Console.WriteLine("Not parallel");
            Environment.Exit(0);
        }
    }
}
