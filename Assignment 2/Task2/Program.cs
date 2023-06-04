using System.Runtime.InteropServices;

Console.WriteLine("Type name to chose action");
Console.WriteLine("Choose from: rock, paper, scissors");
string sInput = Console.ReadLine();

int iChoiceuser;

if (sInput == "rock")
    iChoiceuser = 0;
else if (sInput == "paper")
    iChoiceuser = 1;
else if (sInput == "scissors")
    iChoiceuser = 2;
else {
    Console.WriteLine("Double check spelling of the word and try again");
    return;
}


var rand = new Random();
int iChoicepc = rand.Next(0, 3);
// 0 = rock 1 = paper 2 = scissors
switch (iChoicepc)
{
    case 0:
        Console.WriteLine("PC chose rock");
        break;
    case 1:
        Console.WriteLine("PC chose paper");
        break;
    default:
        Console.WriteLine("PC chose scissors");
        break;
}

if (iChoiceuser == iChoicepc)
    Console.WriteLine("It is a draw");

else if (iChoiceuser == 0 && iChoicepc == 2 || iChoiceuser > iChoicepc)
    Console.WriteLine("You win!!");
else
{
    Console.WriteLine("You loose");
}
