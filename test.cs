Console.WriteLine("Write width and height: ");
int width = int.Parse((Console.ReadLine()));
int height = int.Parse((Console.ReadLine()));
Triangle triangle =new Triangle(width,height);
double triArea= triangle.Area();
Console.WriteLine(triArea);