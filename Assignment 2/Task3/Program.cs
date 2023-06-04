Console.WriteLine("Please input your birth date");
string sYear = Console.ReadLine();
int iYear = int.Parse(sYear);
int iZodiac = iYear % 12;
switch (iZodiac)
{
    case 0:
        Console.WriteLine("Chinese zodiac sign of the year you are born in is Monkey");
        break;
    case 1:
        Console.WriteLine("Chinese zodiac sign of the year you are born in is Rooster");
        break;
    case 2:
        Console.WriteLine("Chinese zodiac sign of the year you are born in is Dog");
        break;
    case 3:
        Console.WriteLine("Chinese zodiac sign of the year you are born in is Pig");
        break;
    case 4:
        Console.WriteLine("Chinese zodiac sign of the year you are born in is Rat");
        break;
    case 5:
        Console.WriteLine("Chinese zodiac sign of the year you are born in is Ox");
        break;
    case 6:
        Console.WriteLine("Chinese zodiac sign of the year you are born in is Tiger");
        break;
    case 7:
        Console.WriteLine("Chinese zodiac sign of the year you are born in is Rabbit");
        break;
    case 8:
        Console.WriteLine("Chinese zodiac sign of the year you are born in is Dragon");
        break;
    case 9:
        Console.WriteLine("Chinese zodiac sign of the year you are born in is Snake");
        break;
    case 10:
        Console.WriteLine("Chinese zodiac sign of the year you are born in is Horse");
        break;
    case 11: Console.WriteLine("Chinese zodiac sign of the year you are born in is Goat");
        break;
}