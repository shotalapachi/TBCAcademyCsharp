Console.WriteLine("Input N");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("enter array elements");
int[] ints = new int[n];

for (int i = 0; i < ints.Length; i++)
    ints[i] = int.Parse(Console.ReadLine());

int len = 1;
int index = 0;
int max = 0;
int maxindex = 0;

for (int i = 0; i < n - 1; i++)
{
    if (ints[i] < ints[i + 1])
    {
        if (len == 1) index = i;
        len++;
        if (len > max)
        {
            max = len;
            maxindex = index;
        }
    }
    else len = 1;
}
for (int i = maxindex; i < max + maxindex; i++)
    Console.Write(ints[i]+ " ");