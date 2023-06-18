Console.WriteLine("Input N (number of integers to calculate)");
int N = int.Parse(Console.ReadLine());
int sum = 0;
for (int i = 0; i < N; i++)
{
    int x = int.Parse(Console.ReadLine());
    sum += x;
}
Console.WriteLine("jami = "+ sum);
Console.WriteLine("sashualo = " + (float)sum / N);