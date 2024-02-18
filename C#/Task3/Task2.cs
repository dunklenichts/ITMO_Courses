/* На числовой оси расположены три точки: A, B, C. Определить, какая из двух последних точек (B или C) 
 * расположена ближе к A, и вывести эту точку и ее расстояние от точки A. Если пользователь введёт 
 * координаты B и C так, что они будут равноотстоящими от А, совпадать с А или между собой - выдать 
 * соответствующее сообщение */

class Program
{
    static void Main(string[] args)
    {
        int A = Convert.ToInt32(Console.ReadLine());
        int B = Convert.ToInt32(Console.ReadLine());
        int C = Convert.ToInt32(Console.ReadLine());

        int distanceToPointB = Math.Abs(B - A);
        int distanceToPointC = Math.Abs(C - A);

        if (distanceToPointB < distanceToPointC)
        {
            int closerDistancePoint = distanceToPointB;
            Console.WriteLine("The closest point to A is B with coordinates {0}, distance = {1}", B, distanceToPointB);
        }
        if (distanceToPointB > distanceToPointC)
        {
            int closerDistancePoint = distanceToPointC;
            Console.WriteLine("The closest point to A is C with coordinates {0}, distance = {1}", C, distanceToPointC);
        }
        else
        {
            Console.WriteLine("None of the points is close to point A");
        }
    }
}
