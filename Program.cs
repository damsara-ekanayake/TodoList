bool isExiting = false;
List<string> todoList = new List<string>();


Console.WriteLine("Hello!");
do
{

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
            SeeFromList();
            break;

        case "A":
        case "a":
            AddIntoTheList();
            break;

        case "R":
        case "r":
            RemoveFromList();
            break;

        case "E":
        case "e":
            isExiting = true;
            break;

        default:
            Console.WriteLine($"\n Invalid Input! \n your input was : {userInput} \n");
            break;
    }

}
while (!isExiting);

void AddIntoTheList()
{
    bool isValidInput = false;
    while (!isValidInput)
    {
        Console.WriteLine("Enter the TODO description : ");
        var newInputMemo = Console.ReadLine();

        if (newInputMemo == "")
        {
            Console.WriteLine("The description cannot be empty!\n");
        }
        else if (todoList.Contains(newInputMemo))
        {
            Console.WriteLine("The description must be unique!\n");
        }
        else
        {
            isValidInput = true;
            todoList.Add(newInputMemo);
            Console.WriteLine($"TODO successfully added : {newInputMemo} \n");
        }
    }

}

void SeeFromList()
{

    if (todoList.Count == 0)
    {
        Console.WriteLine("No TODOs has been added yet\n");
    }
    else
    {
        
        for (int i = 0; i < todoList.Count; ++i)
        {
            Console.WriteLine($" {i + 1}. {todoList[i]}");
        }
        Console.WriteLine();
    }


}

void RemoveFromList()
{
   
    if (todoList.Count == 0)
    {
        Console.WriteLine("NO TODOs have been added yet!\n");
        return;
    }

    bool isValidIndex = false;
    while (!isValidIndex)
    {
        Console.WriteLine("Select the index of the TODO you want to remove : ");
        SeeFromList();
        var inputIndex = Console.ReadLine();

        if ( inputIndex == "")
        {
            Console.WriteLine("Selected index cannot be empty!\n");
            continue;
        }
        if ( int.TryParse(inputIndex, out int index) && index >= 1 && index <= todoList.Count)
        {
            var indexToBeRemoved = todoList[index - 1];
            isValidIndex = true;
            todoList.RemoveAt(index - 1);
            Console.WriteLine($"TODO removed : {indexToBeRemoved}");
        }
        else
        {
            Console.WriteLine("The given index is not valid!\n");
        }
    }
}

