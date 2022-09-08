Console.WriteLine("*****************************************");
Console.WriteLine("Let's build a calculator using functions!");
Console.WriteLine("*****************************************");
Console.WriteLine("");

//let's call the GetNumber() function to get the two numbers
var number1 = GetNumber("first");
var number2 = GetNumber("second");

//let's create a 'done' variable for our while loop.
var done = false;

while (!done)
{
    //clear the screen and display the menu
    Console.Clear();
    Console.WriteLine("Select the equation you'd like to run:");
    Console.WriteLine($"1.) ADDITION {number1} + {number2} = ?");
    Console.WriteLine($"2.) SUBTRACTION {number1} - {number2} = ?");
    Console.WriteLine($"3.) MULTIPLICATION {number1} * {number2} = ?");
    Console.WriteLine($"4.) DIVISION {number1} / {number2} = ?");
    Console.WriteLine("5.) Exit");

    var input = Console.ReadLine();

    //ensure that the user entered an integer
    if (int.TryParse(input, out var selection))
    {
        //execute the appropriate function using a switch
        switch (selection)
        {
            case 1:
                Console.WriteLine($"{number1} + {number2} = {Addition(number1, number2)}");
                break;
            case 2:
                Console.WriteLine($"{number1} - {number2} = {Subtraction(number1, number2)}");
                break;
            case 3:
                Console.WriteLine($"{number1} * {number2} = {Multiplication(number1, number2)}");
                break;
            case 4:
                Console.WriteLine($"{number1} / {number2} = {Division(number1, number2)}");
                break;
            case 5:
                Console.WriteLine("Bye bye!");
                done = true;
                break;
            default:
                Console.WriteLine("Invalid selection, please try again.");
                break;
        }
    }
    else
    {
        Console.WriteLine("Invalid selection, please try again.");
    }

    Console.ReadLine();
}

#region Functions

static int GetNumber(string numberName)
{
    while (true)
    {
        Console.Write($"Enter the {numberName} number:");
        var input = Console.ReadLine();

        if (int.TryParse(input, out var number))
        {
            return number;
        }
        else
        {
            Console.WriteLine("That's not a number, please try again!");
        }
    }
}

static int Addition(int number1, int number2)
{
    return number1 + number2;
}

static int Subtraction(int number1, int number2)
{
    return number1 - number2;
}

static int Multiplication(int number1, int number2)
{
    return number1 * number2;
}

static double Division(int number1, int number2)
{
    return number1 / (double)number2;
}

#endregion