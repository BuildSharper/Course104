using System.Runtime.CompilerServices;

//let's define a global variable, number, that will be used for adding
int number = 0;

//first, lets add 1 to number 10 times using By Value (separate copy of the variable)
Console.WriteLine("By Value:");
for (int i = 0; i < 10; i++)
{
    AddByVal(number);
}

//next, lets add 1 to number 10 times using By Reference (points to the existing variable)
Console.WriteLine("By Reference:");
for (int i = 0; i < 10; i++)
{
    AddByRef(ref number);
}

//finally, lets add 1 to number 10 times using a global variable (no variable is scoped locally)
Console.WriteLine("Global Variable:");
for (int i = 0; i < 10; i++)
{
    AddGlobal();
}

Console.WriteLine("Press any key to continue.");
Console.ReadLine();

#region Functions

//NOTE there is no "ref" before "int number", this makes the variable By Value
void AddByVal(int number)
{
    number++;
    Console.WriteLine($"\t{number}");
}

//NOTE "ref" before "int number", this makes the variable By Reference
void AddByRef(ref int number)
{
    number++;
    Console.WriteLine($"\t{number}");
}

//NOTE there are no parameters to this function, so "number" within this function is a global variable
void AddGlobal()
{
    number++;
    Console.WriteLine($"\t{number}");
}

#endregion