Console.WriteLine("Input N");
int n = int.Parse(Console.ReadLine());
int[] ints = new int[n];
int sorted = 0;
for (int i  = 0; i < n; i++)
    ints[i] = int.Parse(Console.ReadLine());
while (true)
{
    for (int i = 0; i < n-1; i++)
    {
        if (ints[i] > ints[i + 1])
        {
            int tmp = ints[i];
            ints[i] = ints[i+1];
            ints[i+1] = tmp;
        }
        else sorted++;
    }
    if (sorted == n-1)
    { break; }
    else sorted = 0;
}
for (int i = 0; i < n; i++)
{
    Console.Write(ints[i] + " ");
}