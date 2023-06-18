
char[] CreateArray()
{
    Console.WriteLine("Input your array size");
    int ArraySize = int.Parse(Console.ReadLine());
    char[] Array = new char[ArraySize];
    Console.WriteLine("Input " + ArraySize + " elements");
    for (int i = 0; i < ArraySize; i++)
        Array[i] = char.Parse(Console.ReadLine());
    return Array;
}

int CharCount(char[] Array, char Char)
{
    int Count = 0;
    for (int i = 0; i < Array.Length; i++)
    {
        if (Array[i] == Char)
        {
            Count++;
        }
    }
    return Count;
}

void PrintResults()
{
    Console.WriteLine("Input any char");
    char Char = char.Parse(Console.ReadLine());
    Console.WriteLine(CharCount(CreateArray(), Char));
}

PrintResults();