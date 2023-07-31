using Task_2;

Triangle t1 = new Triangle(3, 4, 5);
Triangle t2 = new Triangle(6, 8, 10);
Triangle t3 = t1 + t2;
Console.WriteLine(t1.Area() + " " + t2.Area());
Console.WriteLine(t3.Area());
//Triangle triangle = new Triangle(3, 4, 30);
Console.WriteLine("Input a, b, c: (sides of triangle)");
double a = double.Parse(Console.ReadLine());
double b = double.Parse(Console.ReadLine());
double c = double.Parse(Console.ReadLine());
Triangle triangle = new Triangle(a, b, c);