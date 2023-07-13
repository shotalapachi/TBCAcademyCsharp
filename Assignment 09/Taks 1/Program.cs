using System.ComponentModel;
using Taks_1;

Console.WriteLine("List of vehicle categories and their types");
PrintEnums.PrintChildEnums<Military>();
Console.WriteLine();
PrintEnums.PrintChildEnums<Commerce>();
Console.WriteLine();
PrintEnums.PrintChildEnums<Public>();
Console.WriteLine();
PrintEnums.PrintChildEnums<Sport>();
Console.WriteLine();

Console.WriteLine("Input category name that you want to choose");
string choice = Console.ReadLine().ToLower();

MilitaryVehicle militaryVehicle = new MilitaryVehicle("Didgori", "Armored vehicle", Vehicles.Military, 150, 1000, true, true, Military.Transport);
CommerceVehicle commerceVehicle = new CommerceVehicle("Mercedes", "Sedan", Vehicles.Commerce, 200, 1000, 5, 10, Commerce.Sedan);
PublicVehicle publicVehicle = new PublicVehicle("Ford", "Bus", Vehicles.Public, 100, 1000, 50, true, Public.Bus);
SportVehicle sportVehicle = new SportVehicle("Ferrari", "F1", Vehicles.Sport, 300, 1000, 1, true, Sport.F1);

switch (choice)
{
    case "military":
        ChooseMilitaryVehicleType();
        break;
    case "commerce":
        ChooseCommerceVehicleType();
        break;
    case "public":
        ChoosePublicVehicleType();
        break;
    case "sport":
        ChooseSportVehicleType();
        break;
    default: 
        Console.WriteLine("Wrong input");
        break;
}

void ChooseMilitaryVehicleType()
{
    Console.WriteLine("Input vehicle type that you want to choose or type print to show category example");
    string choice = Console.ReadLine().ToLower();
    switch (choice)
    {
        case "transport":
            CreateMilitaryVehicle(Military.Transport);
            break;
        case "fighting":
            CreateMilitaryVehicle(Military.Fighting);
            break;
        case "tank":
            CreateMilitaryVehicle(Military.Tank);
            break;
        case "workload":
            CreateMilitaryVehicle(Military.Workload);
            break;
        case "print":
            foreach (PropertyDescriptor descriptor in TypeDescriptor.GetProperties(militaryVehicle))
            {
                string name = descriptor.Name;
                object value = descriptor.GetValue(militaryVehicle);
                Console.WriteLine("{0}={1}", name, value);
            }
            break;
        default: 
            Console.WriteLine("Wrong input");
            break;
    }
}

void ChooseCommerceVehicleType()
{
    Console.WriteLine("Input vehicle type that you want to choose or type print to show category example");
    string choice = Console.ReadLine().ToLower();
    switch (choice)
    {
        case "sedan":
            CreateCommerceVehicle(Commerce.Sedan);
            break;
        case "hatchback":
            CreateCommerceVehicle(Commerce.Hatchback);
            break;
        case "cabriolet":
            CreateCommerceVehicle(Commerce.Cabriolet);
            break;
        case "picup":
            CreateCommerceVehicle(Commerce.Picup);
            break;
        case "suv":
            CreateCommerceVehicle(Commerce.SUV);
            break;
        case "van":
            CreateCommerceVehicle(Commerce.Van);
            break;
        case "print":
            foreach (PropertyDescriptor descriptor in TypeDescriptor.GetProperties(commerceVehicle))
            {
                string name = descriptor.Name;
                object value = descriptor.GetValue(commerceVehicle);
                Console.WriteLine("{0}={1}", name, value);
            }
            break;
        default: 
            Console.WriteLine("Wrong input");
            break;
    }
}
void ChoosePublicVehicleType()
{
    Console.WriteLine("Input vehicle type that you want to choose or type print to show category example");
    string choice = Console.ReadLine().ToLower();
    switch (choice)
    {
        case "bus":
            CreatePublicVehicle(Public.Bus);
            break;
        case "train":
            CreatePublicVehicle(Public.Train);
            break;
        case "subway":
            CreatePublicVehicle(Public.Subway);
            break;
        case "tramway":
            CreatePublicVehicle(Public.Tramway);
            break;
        case "print":
            foreach (PropertyDescriptor descriptor in TypeDescriptor.GetProperties(publicVehicle))
            {
                string name = descriptor.Name;
                object value = descriptor.GetValue(publicVehicle);
                Console.WriteLine("{0}={1}", name, value);
            }
            break;
        default: 
            Console.WriteLine("Wrong input");
            break;
    }
}
void ChooseSportVehicleType()
{
    Console.WriteLine("Input vehicle type that you want to choose or type print to show category example");
    string choice = Console.ReadLine().ToLower();
    switch (choice)
    {
        case "drag":
            CreateSportVehicle(Sport.Drag);
            break;
        case "f1":
            CreateSportVehicle(Sport.F1);
            break;
        case "rallying":
            CreateSportVehicle(Sport.Rallying);
            break;
        case "offroad":
            CreateSportVehicle(Sport.Offroad);
            break;
        case "print":
            foreach (PropertyDescriptor descriptor in TypeDescriptor.GetProperties(sportVehicle))
            {
                string name = descriptor.Name;
                object value = descriptor.GetValue(sportVehicle);
                Console.WriteLine("{0}={1}", name, value);
            }
            break;
        default:
            Console.WriteLine("Wrong input");
            break;
    }
}

void CreateMilitaryVehicle(Military type)
{
    Console.WriteLine("Input vehicle name");
    string name = Console.ReadLine();
    Console.WriteLine("Input vehicle description");
    string description = Console.ReadLine();
    Console.WriteLine("Input vehicle top speed");
    int topSpeed = int.Parse(Console.ReadLine());
    Vehicles category = Vehicles.Military;
    Console.WriteLine("Input vehicle distance traveled");
    int distanceTraveled = int.Parse(Console.ReadLine());
    Console.WriteLine("Input if vehicle is armed");
    bool isArmed = bool.Parse(Console.ReadLine());
    Console.WriteLine("Input if vehicle is armored");
    bool isArmored = bool.Parse(Console.ReadLine());
    MilitaryVehicle Mvehicle = new(name, description, category, topSpeed, distanceTraveled, isArmed, isArmored, type);
}

void CreateCommerceVehicle(Commerce type)
{
    Console.WriteLine("Input vehicle name");
    string name = Console.ReadLine();
    Console.WriteLine("Input vehicle description");
    string description = Console.ReadLine();
    Console.WriteLine("Input vehicle top speed");
    int topSpeed = int.Parse(Console.ReadLine());
    Vehicles category = Vehicles.Commerce;
    Console.WriteLine("Input vehicle distance traveled");
    int distanceTraveled = int.Parse(Console.ReadLine());
    Console.WriteLine("Input vehicle number of seats");
    int numberOfSeats = int.Parse(Console.ReadLine());
    Console.WriteLine("Input vehicle killometers per liter");
    int kilometersPerLiter = int.Parse(Console.ReadLine());
    CommerceVehicle Cvehicle = new(name, description, category, topSpeed, distanceTraveled, numberOfSeats, kilometersPerLiter, type);
}

void CreatePublicVehicle(Public type)
{
    Console.WriteLine("Input vehicle name");
    string name = Console.ReadLine();
    Console.WriteLine("Input vehicle description");
    string description = Console.ReadLine();
    Console.WriteLine("Input vehicle top speed");
    int topSpeed = int.Parse(Console.ReadLine());
    Vehicles category = Vehicles.Public;
    Console.WriteLine("Input vehicle distance traveled");
    int distanceTraveled = int.Parse(Console.ReadLine());
    Console.WriteLine("Input vehicle number of seats");
    int numberOfSeats = int.Parse(Console.ReadLine());
    Console.WriteLine("Input if vehicle has AC");
    bool hasAC = bool.Parse(Console.ReadLine());
    PublicVehicle Pvehicle = new(name, description, category, topSpeed, distanceTraveled, numberOfSeats, hasAC, type);
}

void CreateSportVehicle(Sport type)
{
    Console.WriteLine("Input vehicle name");
    string name = Console.ReadLine();
    Console.WriteLine("Input vehicle description");
    string description = Console.ReadLine();
    Console.WriteLine("Input vehicle top speed");
    int topSpeed = int.Parse(Console.ReadLine());
    Vehicles category = Vehicles.Sport;
    Console.WriteLine("Input vehicle distance traveled");
    int distanceTraveled = int.Parse(Console.ReadLine());
    Console.WriteLine("Input vehicle acceleration");
    int numberOfSeats = int.Parse(Console.ReadLine());
    Console.WriteLine("Input if vehicle is street legal");
    bool isStreetLegal = bool.Parse(Console.ReadLine());
    SportVehicle Svehicle = new(name, description, category, topSpeed, distanceTraveled, numberOfSeats, isStreetLegal, type);
}
