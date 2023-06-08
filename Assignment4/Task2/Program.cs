Console.WriteLine("Input size of array");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("write " + n + " elements of the array");
string[] strings = new string[n];
for (int i = 0; i < n; i++)
    strings[i] = Console.ReadLine();
Console.WriteLine("Input size of the seond array");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("write " + m + " elements of the array");
int[] ints = new int[m];
for (int i = 0; i < m; i++)
    ints[i] = int.Parse(Console.ReadLine());
object[] objects = new object[m + n];
int k = 0;
for (int i = 0; i < m + n; i++)
{
    if (i % 2 == 0 && k<n || k>=m)
    {
        objects[i] = strings[k];
    }
    else
    {
        objects[i] = ints[k];
        k++;
    }
}
foreach (object o in objects)
{ Console.Write(o.ToString()); }