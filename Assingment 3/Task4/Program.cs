Console.WriteLine("Input any number");
int n = int.Parse(Console.ReadLine());
int fullwidth = n * 2 - 1;
int pyramidwidth = 1;
int emptywidth = (fullwidth - 1) / 2;
for (int i = 1; i <= n; i++)
{

    for (int k = 1; k <= emptywidth; k++) { Console.Write(" "); }
    for (int k = 1; k <= pyramidwidth; k++) { Console.Write("*"); }
    for (int k = 1; k <= emptywidth; k++) { Console.Write(" "); }

    Console.WriteLine();
    pyramidwidth += 2;
    emptywidth -= 1;
}