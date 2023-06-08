using System.Numerics;

Console.WriteLine("Choose matrix size:");
Console.WriteLine("1. 2x2");
Console.WriteLine("2. 3x3");

int choice = int.Parse(Console.ReadLine());
int deter = 0;
int[,] matrix;

if (choice == 1)
{
    int msize = 2;

    Console.WriteLine("Enter elements..");
    matrix = new int[msize, msize];

    for (int i = 0; i < msize; i++)
    {
        for (int j = 0; j < msize; j++)
        {
            Console.WriteLine("[" + i + "][" + j + "]");
            matrix[i, j] = int.Parse(Console.ReadLine());
        }
    }
    deter = matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];
}
else
{
    int msize = 3;
    matrix = new int[msize, msize];

    Console.WriteLine("Enter elements..");

    for (int i = 0; i < msize; i++)
    {
        for (int j = 0; j < msize; j++)
        {
            Console.WriteLine("[" + i + "][" + j + "]");
            matrix[i, j] = int.Parse(Console.ReadLine());
        }
    }
    int a = (matrix[1, 1] * matrix[2, 2] - matrix[1, 2] * matrix[2, 1]);
    int b = (matrix[1, 0] * matrix[2, 2] - matrix[1, 2] * matrix[2, 0]);
    int c = (matrix[1, 0] * matrix[2, 1] - matrix[1, 1] * matrix[2, 0]);
    deter = matrix[0, 0] * a - matrix[0, 1] * b + matrix[0, 2] * c;

}
Console.WriteLine("you entered matrix: ");
for (int i = 0; i < choice + 1; i++)
{
    for (int j = 0; j < choice + 1; j++)
    {
        Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine("Determinant is: " + deter);