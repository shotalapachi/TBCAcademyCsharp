using Task_1;

Matrix ints1 = new Matrix();
Matrix ints2 = new Matrix();
for (int i = 0; i < 2; i++)
{
    for (int j = 0; j < 2; j++)
    {
        Console.Write($"Enter matrix1[{i}, {j}]: ");
        ints1.ints[i, j] = int.Parse(Console.ReadLine());
    }
}

Matrix ints3 = ints1 + ints2;

Matrix.PrintMatrix(ints3);