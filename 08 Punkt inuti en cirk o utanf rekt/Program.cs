//08. Skriv ett uttryck som kontrollerar om en given
//punkt (x, y) ligger innanför cirkeln K((1, 1), 3) och
//utanför rektangeln R(top=1, left = -1, width = 6,
//height = 2)

using System.Drawing;



Point point = new Point();

Console.WriteLine("Punktens x- och y-kordinator:");
Console.Write("  x = ");
point.x = double.Parse(Console.ReadLine());
Console.Write("  y = ");
point.y = double.Parse(Console.ReadLine());


if (InsideCircle(point) && InsideRectangle(point))
{
    Console.WriteLine($"Punkten ({point.x}, {point.y}) ligger innuti cirkeln och innanför rektangeln");
}
else if (!InsideCircle(point) && !InsideRectangle(point))
{
    Console.WriteLine($"Punkten ({point.x}, {point.y}) ligger utanför cirkeln och utanför rektangeln");
}
else if (InsideCircle(point) && !InsideRectangle(point))
{
    Console.WriteLine($"Punkten ({point.x}, {point.y}) ligger innanför cirkeln och utanför rektangeln");
}
else
{
    Console.WriteLine($"Punkten ({point.x}, {point.y}) ligger utanför cirkeln och innuti rektangeln");
}

static bool InsideCircle(Point point)
{
    sbyte circleX = 1, circleY = 1, circleRadius = 3;

    point.x = point.x - circleX;
    point.y = point.y - circleY;

    if (point.x * point.x + point.y * point.y <= circleRadius * circleRadius)
    {
        return true;
    }
    else
    {
        return false;
    }
}

static bool InsideRectangle(Point point)
{
    sbyte rxLeft = -1, ryTop = 1, rxRight = 5, ryBottom = -1;
   if (point.x >= rxLeft && point.x <= rxRight &&
        point.y <= ryTop && point.y >= ryBottom)
    {
        return true;
    }
    else
    {
        return false;
    }
}

//Deklarerar en egen datatyp kallar den för Point( struct om de bara är data)
public struct Point
{
    public double x;
    public double y;
}