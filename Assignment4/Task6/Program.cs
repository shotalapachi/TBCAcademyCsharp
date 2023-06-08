Console.WriteLine("Enter first matrce dimentions");
int x = int.Parse(Console.ReadLine());
int y = int.Parse(Console.ReadLine());
Console.WriteLine("Enter second matrice dimentions");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
if (a != y)
    Console.WriteLine("Matrices can't be multiplied");
else
{
    Console.WriteLine("Enter first matrice elements");
    int[,] m1 = new int[x, y];
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            m1[i, j] = int.Parse(Console.ReadLine());
        }
    }
    Console.WriteLine("Enter second matrice elements");
    int[,] m2 = new int[a, b];
    for (int i = 0; i < a; i++)
    {
        for (int j = 0; j < b; j++)
        {
            m2[i, j] = int.Parse(Console.ReadLine());
        }
    }
    int[,] m3 = new int[x, b];
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < b; j++)
        {
            m3[i, j] = 0;
            for (int k = 0; k < y; k++)
            {
                m3[i, j] += m1[i, k] * m2[k, j];
            }
        }
    }
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < b; j++)
        { 
            Console.Write(m3[i, j] + " "); 
        }
        Console.WriteLine();
    }
}