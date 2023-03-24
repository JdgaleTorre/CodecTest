// See https://aka.ms/new-console-template for more information
string option = "";

do
{
    if (option == "N")
    {
        Console.Write("Insert Plateu Size, ex. 5,5: ");
        string size = Console.ReadLine().ToString();
        Console.Write("Insert Moves: ex. FFRFLFLF:");
        string moves = Console.ReadLine().ToString();


        Plateau newPlateau = new Plateau(int.Parse(size.Split(",")[0]), int.Parse(size.Split(",")[1]));
        Rovers.RoversRobot newRovers = new Rovers.RoversRobot(newPlateau, 1);
        Console.WriteLine(newRovers.Instructions(moves));

    }
    Console.Write("Write `N` to create a new Rovers, to Exit write `E`:");
    option = Console.ReadLine().ToString();
} while (option != "E");

Console.WriteLine("Thank you to control the Rovers!");


