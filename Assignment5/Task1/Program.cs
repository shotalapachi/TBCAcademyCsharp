
int SumOfDigitsOnIndex(int[] array, int index)
{
    int sum = 0;
    int x = array[index];
    while (x > 0)
    {
        sum += x % 10;
        x /= 10;
    }
    return sum;
}

int index = 0;
int arrsize;

Console.WriteLine("Input your array size");
arrsize = int.Parse(Console.ReadLine());

int[] userarr = new int[arrsize];

for (int i = 0;i < arrsize;i++)
{
    Console.WriteLine("intput "+i+"index value");
    userarr[i] = int.Parse(Console.ReadLine());
}
Console.WriteLine("Choose index from 0-" + (arrsize - 1));
index = int.Parse(Console.ReadLine());
    
Console.WriteLine(SumOfDigitsOnIndex(userarr, index));
