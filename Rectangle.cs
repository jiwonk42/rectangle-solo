using System;

class Rectangle
{
  public int Width;
  public int Length;

  public bool IsRectangle()
  {
    if (Width != Length)
    {
      return true;
    }
    else
    {
      return false;
    }
  }
}

public class Program
{
  public static void Main()
  {
    Rectangle rectangle = new Rectangle();

    Console.WriteLine("Width?");
    int width = int.Parse(Console.ReadLine());
    rectangle.Width = width;

    Console.WriteLine("Length?");
    int length = int.Parse(Console.ReadLine());
    rectangle.Length = length;

    Console.WriteLine(rectangle.IsRectangle());

  }
}
