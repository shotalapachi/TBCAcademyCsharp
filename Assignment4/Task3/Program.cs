Console.WriteLine("Input array size");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Input array elements");
int[] ints = new int[n];
for  (int i = 0; i < n; i++)
{
    ints[i] = int.Parse(Console.ReadLine());
}
Console.WriteLine("Input second array size");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Input array elements");
int[] ints2 = new int[m];
for (int i = 0;i < m; i++)
    ints2[i] = int.Parse(Console.ReadLine());

int[] ints3 = ints.Concat(ints2).ToArray();
Array.Sort(ints3);
Console.WriteLine("Type ASC or DESC to sort merged arrays");
string input = Console.ReadLine();
if (input.ToUpper()=="ASC")
    foreach (int i in ints3)
        Console.Write(i.ToString()+ " ");
else
{
    Array.Reverse(ints3);
    foreach(int i in ints3 ) Console.Write(i.ToString() + " ");
}
