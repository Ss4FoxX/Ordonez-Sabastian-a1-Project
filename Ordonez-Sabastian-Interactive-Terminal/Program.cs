using System.Xml.Serialization;

int Gold = 0;


Console.WriteLine("Hello, I  am Irrelivance,I will be your narrirator. Let us begin, You awaken at a crossroads, all but a bag of 50 Gold, where will you go?");
Console.WriteLine("1, to the right a Shaded Forest, 2, to the left are vast plains, finally 3, behind you to a dense jungle. where do you go? ");

Gold += 50;
string Choice = Console.ReadLine();

if (Choice == "1")
{
    Console.WriteLine("You deside to go to the Shaded Forest, slightly darkened by the tree's.");
    Console.WriteLine("As you walk, you spot something slightly humanoid, it's wielding a dagger coated in a viscous orange sap.");
    Console.WriteLine("you have 2 Choices, either 1, sneak past it, or try to attack it. your choice.");
    Choice = Console.ReadLine();
    if (Choice == "1")
    {
        Console.WriteLine("You manage to sneak past, you see the Juvenile Golblin over a clearly poisoned rabbit. While you continue along your treck, you notice something intesting. just off the path.");
        Console.WriteLine("A graveyard with graves made of stones and wood, you notice many riches, items and weapons around the graves.");
        Console.WriteLine("You can respect the dead, or just ignore the graves and riches. You may steal all the riches of the grave blind aswell, Choose.");
    }
    else if (Choice == "2")
    {
        Console.WriteLine("The Juvenile Goblin hears your running steps, in an almost blind panic it stabs you in the abdomen. Within seconds, the now known poison begins to take hold, your body feels hot and your sight fades. ");
        Console.WriteLine("You died to Inferium Poisoning.");
    }
}
else if (Choice == "2")
{
    
}
else if (Choice == "3")
{

}