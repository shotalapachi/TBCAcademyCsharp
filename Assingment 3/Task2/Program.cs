Console.WriteLine("Input any number");
string sNumber = Console.ReadLine();
int iNumber = int.Parse(sNumber);
int iCount = 0;
for (int j = 1; j <= iNumber; j++)
{
    if (iNumber % j == 0)
    {
        iCount++;
    }
}
Console.WriteLine(iNumber + "-s aqvs "+iCount +" gamyofi");