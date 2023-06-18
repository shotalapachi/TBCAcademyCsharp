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
    if (guess == random)
    {
        Console.WriteLine("Congratulations you guessed correctly in " + guesscount + " tries");
        Console.WriteLine("Do you want to play again y/n?");
        if (Console.ReadLine() == "y")
        {
            Console.WriteLine("Input min range");
            min = int.Parse(Console.ReadLine());
            Console.WriteLine("Input max range");
            max = int.Parse(Console.ReadLine());
            random = rnd.Next(min, max);
            guesscount = 0;

        }
        else Environment.Exit(0);
    }
} while (true);
