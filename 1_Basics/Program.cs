#region 
//The "#region" can be used to 'collapse' areas of code so you can focus on the key areas
//Comments can be done in a couple different ways, after // and multiline between /* comment */
/*
multi
line
comment
*/

//All of these functionalities is for the programmers, the compiler deletes them when creating the executable (.exe)
//Programmers can use them to document their code and help future programmers understand their thinking.
#endregion

#region Assignment; Write your own story
/* Todays assignment
*   Run this program
*   Read and understand this programs source code
*   Write a short story using the Console for input and output
*   Try to make use of as many of the below techniques as possible
*/

//Console.WriteLine("...");
//Console.ReadLine();
//int.Parse("123");
//if, elseif, else

//bool ExampleBool = true;
//int ExampleInt = 123;
//float ExampleFloat = 123.21f;
//string ExampleString = "Example 123";
#endregion

#region Variables
Console.WriteLine("Hello adventurer! \nWould you like to hear a story?");

string answer = Console.ReadLine();
bool StartStory = false;
if (answer == "yes")
{
    StartStory = true;
}

if (StartStory == true)
{
    Console.WriteLine("Okay firstly I need your name");

    string AName = Console.ReadLine();
    Console.WriteLine("\nOkay " + AName + "! \nThe story starts deep in a forest, far away from nearest civilization.\n");
    Console.WriteLine("You are running in a direct direction but suddenly a t-shaped path forms. Which way do you run?");
    Console.WriteLine("\nLeft\nRight\nStraight\n");

    answer = Console.ReadLine();
    //Start the storyline of turning right
    if (answer == "right")
    {
        Console.WriteLine("\nYou go Right, and after you run for almost 5 minutes you see a scary looking house.\nDo you dare to enter?");
        answer = Console.ReadLine();

        //Enter the house
        if (answer == "yes")
        {
            Console.WriteLine("You hurry to the house and knock");
            Thread.Sleep(1200);
            Console.WriteLine("*knock* *knock*");
            Thread.Sleep(1200);
            Console.WriteLine("Silence");
            Thread.Sleep(1200);
            Console.WriteLine("You slowly push the door open and hear a creaking sound.");
            Console.WriteLine("Cockroaches run all over the floor, making it so that every step from now on will make a sound.");
            Console.ReadLine();
        }

        //Run past the house
        else if (answer == "no")
        {
            Console.WriteLine("\nYou run past the spooky looking house, and until you enter a large grassfield.\nIt seems like you have escaped the cursed forrest.");
            Console.WriteLine("Some hours pass by and you find you'r village and house.\nYou can finally rest");
            Console.ReadLine();
        }   
    }

    //Start the storyline of turning left
    else if (answer == "left")
    {


        Console.ReadLine();

    }

    //Start the storyline of going straight
    else if (answer == "straight")
    {


        Console.ReadLine();
    }

}

else if (answer == "no")
{
    Console.WriteLine("Im sorry to hear that");
    Console.ReadLine(); //Stops program from exiting until we press a key
}


#endregion


/* Teachers corner

* Operators; +, -, /, *, %, ++, --, *=, +=, -=

* Casting
int.Parse()
Convert.ToInt32()
(int)
*/

/*
* The four main basic types we we will work with in the beginning are:
* bool, Int, Float and String   
* bool or boolean, can only be 'true' or 'false'
* Int, or integer, is a whole number; 1, 2, 3
* Float is a decimal number; 3.14 or 7.777
* Strings is just text found between quotationmarks "This is a string, easy right?"
*
* Programmers use these different types to better communicate their thoughts and optimize the program
* C# have, at the time of writing; 10 different types of numbers, choosing the right ones can be key to your objective.
*
* There are many different data types which can be explored in the Microsoft C# documentation, see link below.
* https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/built-in-types
*/