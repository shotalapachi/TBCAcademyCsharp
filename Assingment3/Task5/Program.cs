Console.WriteLine("Input min range");
int min = int.Parse(Console.ReadLine());
Console.WriteLine("Input max range");
int max = int.Parse(Console.ReadLine());
Random rnd = new Random();
int random = rnd.Next(min, max);
int guess;
int guesscount = 0;
do
{
    if (guesscount == 0)
        Console.WriteLine("start guessing");
    else Console.WriteLine("try again");
    guess = int.Parse(Console.ReadLine());
    guesscount++;
} while (random != guess);
Console.WriteLine("Congratulations you guessed correctly in " + guesscount + " tries");
