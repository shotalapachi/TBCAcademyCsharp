Console.WriteLine("Input any number");
string sNumber = Console.ReadLine();
int iNumber = int.Parse(sNumber);
for (int j = 2; j < iNumber; j++)
{
    if (iNumber % j == 0)
    {
        Console.WriteLine(iNumber+" aris shedgenili");
        return;
    }
}
Console.WriteLine(iNumber+ " aris martivi");