Console.WriteLine("Sheiyvanet temperatura");
string sTemp = Console.ReadLine();
int iTemp = int.Parse(sTemp);
if (iTemp < 0)
    Console.WriteLine("yinavs");
else if (iTemp >= 0 && iTemp <= 30)
    Console.WriteLine("kargi amindia");
else Console.WriteLine("cxela");