try
{
    Problem1_2.IShape triangle2 = new Problem1_2.Triangle("triangle", 5, 10);
    double triangle2Area = triangle2.GetArea();
    string triangle2Name = triangle2.GetName();
    Console.WriteLine($"Name={triangle2Name}, Area={triangle2Area}");

    Problem1_2.IShape isoTriangle2 = new Problem1_2.IsoscelesTriangle("isosceles triangle", 2, 10);
    double isoTriangle2Area = isoTriangle2.GetArea();
    string isoTriangle2Name = isoTriangle2.GetName();
    Console.WriteLine($"Name={isoTriangle2Name}, Area={isoTriangle2Area}");

    Problem1_2.IShape circle2 = new Problem1_2.Circle("circle", 5);
    double circle2Area = circle2.GetArea();
    string circle2Name = circle2.GetName();
    Console.WriteLine($"Name={circle2Name}, Area={circle2Area}");

    Problem1_2.IShape rect2 = new Problem1_2.Rectangle("rectangle", 2, 10);
    double rect2Area = rect2.GetArea();
    string rect2Name = rect2.GetName();
    Console.WriteLine($"Name={rect2Name}, Area={rect2Area}");

    Problem1_2.IShape square2 = new Problem1_2.Square("square", 2);
    double square2Area = square2.GetArea();
    string square2Name = square2.GetName();
    Console.WriteLine($"Name={square2Name}, Area={square2Area}");
}
catch (Exception)
{
    Console.WriteLine("Critical error: Value cannot be negative");
}