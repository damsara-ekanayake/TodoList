bool isExiting = false;

do
{
    Console.WriteLine("Hello!");
    Console.WriteLine("What do you want to do?");
    Console.WriteLine("[S]ee all TODOs");
    Console.WriteLine("[A]dd a TODO");
    Console.WriteLine("[R]emove a TODO");
    Console.WriteLine("[E]xit");

    var userInput = Console.ReadLine();

    switch (userInput)
    {
        case "S":
        case "s":
            Console.WriteLine("\n See all \n");
            break;

        case "A":
        case "a":
            Console.WriteLine("\n add memo \n");
            break;

        case "R":
        case "r":
            Console.WriteLine("\n remove memo \n ");
            break;

        case "E":
        case "e":
            isExiting = true;
            break;

        default:
            Console.WriteLine("\n Invalid Input! \n");
            break;
    }

}
while (!isExiting);



