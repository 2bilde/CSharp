string answer;
void PlayGameBG(int bet) //Betting game//
{
    if (bet > 100)
    {
        Console.WriteLine("WOW! That a lot of money. Well okay then lets play!");
    }
    else
    {
        Console.WriteLine("Okay lets play!");
    }

    Console.WriteLine("We will play a game where you try to guess the right number");

    Console.WriteLine("How many x yould you like as a reward?");
    int xBet = Convert.ToInt32(Console.ReadLine());

    if (xBet < 5)
    {
        Console.WriteLine("Okay the bet will be x" + xBet + "\nGuess a number between 1 - 5\n");
        Thread.Sleep(1000);
        Console.WriteLine("You have 3 guesses");
        int guess = 0;
        Random randomNumbers = new Random(); // random number generator for betting
        int betAnswer = randomNumbers.Next(1, 5);
        Console.WriteLine("Enter a number: ");
        bool win1 = false;
        for (int i = 0; i <= 2; i++)
        {
            guess = Convert.ToInt32(Console.ReadLine());
            if (guess == betAnswer)
            {
                win1 = true;
                Console.WriteLine("Well done! you win " + bet * xBet + "$ back!");
                break;
            }
            else
            {
                Console.WriteLine("That was wrong you have " + (2 - i) + " gusses back!");
            }
        }
        if (win1 == false)
        {
            Console.WriteLine("You lost. Your money is now mine!");
        }
    }
    else if (xBet == 5)
    {
        Console.WriteLine("Okay the bet will be x" + xBet + "\nGuess a number between 1 - 10\n");
        Thread.Sleep(1000);
        Console.WriteLine("You have 5 guesses");
        int guess = 0;
        Random randomNumbers = new Random(); // random number generator for betting
        int betAnswer = randomNumbers.Next(1, 10);
        Console.WriteLine("Enter a number: ");
        bool win2 = false;
        for (int i2 = 0; i2 <= 4; i2++)
        {
            guess = Convert.ToInt32(Console.ReadLine());
            if (guess == betAnswer)
            {
                win2 = true;
                Console.WriteLine("Well done! you win " + bet * xBet + "$ back!");
                break;
            }
            else
            {
                Console.WriteLine("That was wrong you have " + (2 - i2) + " gusses back!");
            }
            if (win2 == false)
            {
                Console.WriteLine("Ahahah you lost. Your money is now mine!");
            }
        }
    }
    else if (xBet > 5)
    {
        Console.WriteLine("Okay the bet will be x" + xBet + "\nGuess a number between 1 - 30\n");
        Thread.Sleep(1000);
        Console.WriteLine("You have 10 guesses");
        int guess = 0;
        Random randomNumbers = new Random(); // random number generator for betting
        int betAnswer = randomNumbers.Next(1, 30);
        Console.WriteLine("Enter a number: ");
        bool win3 = false;
        for (int i3 = 0; i3 <= 9; i3++)
        {
            guess = Convert.ToInt32(Console.ReadLine());
            if (guess == betAnswer)
            {
                win3 = true;
                Console.WriteLine("Well done! you win " + bet * xBet + "$ back!");
                break;
            }
            else
            {
                Console.WriteLine("That was wrong you have " + (2 - i3) + " gusses back!");
            }
        }
        if (win3 == false)
        {
            Console.WriteLine("Ahahah you lost. Your money is now mine!");
        }
    }

    Console.WriteLine("\nDo you want to try again?");
    answer = Console.ReadLine();

    if (answer == "yes")
    {
        Console.WriteLine("\nHow much are you willing to bet?");

        bet = Convert.ToInt32(Console.ReadLine());
        PlayGameBG(bet);
    }
    else if (answer == "no")
    {

        Console.WriteLine("\nDo you want to play my other game?");
        answer = Console.ReadLine();

        if (answer == "yes")
        {
            Console.WriteLine("\nThis is a simple game of Rock Paper Scissors");

            PlayGameRPS();
        }
    }
}
void PlayGameRPS() //Rock, Paper, Scissors//
{
    string user;
    string ans = "";
    int count = 0;
    int count1 = 0;

    Console.WriteLine("Welcome to a simple Rock Paper Scissors game\n");

    while (ans != "no")
    {
        Console.WriteLine("*What do you pick?*\nRock\nPaper\nScissor\n");
        string[] choices = new string[3] { "rock", "paper", "scissor" };
        Random rnd = new Random();
        int n = rnd.Next(0, 2);
        user = Console.ReadLine();

        Console.WriteLine("\nAre you ready?");
        Thread.Sleep(200);
        Console.WriteLine("Rock");
        Thread.Sleep(400);
        Console.WriteLine("Paper");
        Thread.Sleep(400);
        Console.WriteLine("Scissor");
        Thread.Sleep(400);
        Console.WriteLine("SHOOT!\n");
        Thread.Sleep(400);

        if (user == "rock" && choices[n] == "scissor")
        {
            Console.WriteLine("ORH NOLLER! You won..");
            count += 1;
        }
        else if (user == "rock" && choices[n] == "paper")
        {
            Console.WriteLine("HA I WIN!");
            count1 += 1;
        }
        else if (user == "paper" && choices[n] == "rock")
        {
            Console.WriteLine("ORH NOLLER! You won..");
            count += 1;
        }
        else if (user == "paper" && choices[n] == "scissor")
        {
            Console.WriteLine("HA I WIN!");
            count1 += 1;
        }
        else if (user == "scissor" && choices[n] == "rock")
        {
            Console.WriteLine("HA I WIN!");
            count1 += 1;
        }
        else if (user == "scissor" && choices[n] == "paper")
        {
            Console.WriteLine("ORH NOLLER! You won..");
            count += 1;
        }
        else
        {
            Console.WriteLine("Oh nice we chose the same. Wanna try again?");
        }
        Console.WriteLine("Do u want to try again?");
        ans = Console.ReadLine();
        Console.WriteLine("________________________________\n");
    }
    Console.WriteLine("User wins " + count + " times");
    Console.WriteLine("Computer wins " + count1 + " times");
    Console.WriteLine("\nDo you want to play my other game?\n");
    answer = Console.ReadLine();

    if (answer == "yes")
    {
        Console.WriteLine("\nThis is a betting game");
        Thread.Sleep(200);
        Console.WriteLine("\nHow much are you willing to bet?");

        int bet = Convert.ToInt32(Console.ReadLine());
        PlayGameBG(bet);
    }

}

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

bool StartStory = false;
answer = Console.ReadLine();
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
            Thread.Sleep(1000);
            Console.WriteLine("Cockroaches run all over the floor, making it so that every step from now on will make a sound.");
            Thread.Sleep(3000);
            Console.WriteLine("\nAs you enter the room and kill the first 3 cockroaches, the door slams behind you");
            Thread.Sleep(1000);
            Console.WriteLine("The silence becomes loud and as your eyes adapt to the dark room \nYou hear a sudden laugh from what feels like under you");
            Thread.Sleep(6000);
            Console.WriteLine("\nThe room you are standing in seems like a corridor with 3 doors.\nOne on the right and 2 on the left.");
            Thread.Sleep(2000);
            Console.WriteLine("The door on the left is wide open and you spot what looks like a fridge and an oven.");
            Thread.Sleep(1500);
            Console.WriteLine("The wierd sound seems to be comming from the first door on the right.");
            Thread.Sleep(2000);

            Console.WriteLine("\nleave\ndoor on left\n1 door right\n2 door right\n");

            answer = Console.ReadLine();

            switch (answer)
            {
                //Leave the house
                case "leave":
                    {
                        Console.WriteLine("You quickly turn around and try to open the door, making a loud sound, but the door wont open.");
                        Thread.Sleep(2500);
                        Console.WriteLine("Behind you, you hear a very loud step. You turn around and before you realize whats happening");
                        Thread.Sleep(2000);
                        Console.WriteLine("A claw hits across your face turning everything dark");
                        Thread.Sleep(700);
                        Console.WriteLine(".");
                        Thread.Sleep(700);
                        Console.WriteLine(".");
                        Thread.Sleep(700);
                        Console.WriteLine(".");
                        Console.ReadLine();
                        break;
                    }
                case "door on left":
                    {
                        //Turn left to kitchen
                        Console.WriteLine("You quickly run to the kitchen, and it seems like the steps under you become louder.");
                        Thread.Sleep(2000);
                        Console.WriteLine("Pots and pans are on the stove and some knives hang on the wall, the fridge is filled with food.");
                        Thread.Sleep(2000);
                        Console.WriteLine("Growling apears behind you from what seems like the first door. You cant spot it yet.");
                        Thread.Sleep(2000);
                        Console.WriteLine("There doesnt seem to be any hiding spaces other than the window that is wide open.");
                        Thread.Sleep(2000);
                        Console.WriteLine("\nFlee\nFight\n");
                        answer = Console.ReadLine();

                        //Fight
                        if (answer == "fight")
                        {
                            Random randomNumbers = new Random(); // random number generator for weapon
                            int Weapon = randomNumbers.Next(1, 3);

                            switch (Weapon)
                            {
                                case 1:
                                    //Knife
                                    Console.WriteLine("You reach for the biggest knife in the knifeblock and pull it out");
                                    Thread.Sleep(1200);
                                    Console.WriteLine("just to find out that it was the smallest knife you got");
                                    Thread.Sleep(1200);
                                    Console.WriteLine("After grabbing the knife it seems near to impossible to kill the growling thing");
                                    Thread.Sleep(1400);
                                    Console.WriteLine("You run towards the sound and stab around the corner into what now seems like a big scream");
                                    Thread.Sleep(1600);
                                    Console.WriteLine("You look down and see that you have stabbed a small girl in the neck");
                                    Thread.Sleep(1200);
                                    Console.WriteLine("She falls to the ground and behind her a big dark creature apears in the shadow");
                                    Thread.Sleep(1500);
                                    Console.WriteLine("Out of guilt and fear you wank the knife towards yourself and everything becomes dark");
                                    Thread.Sleep(700);
                                    Console.WriteLine(".");
                                    Thread.Sleep(700);
                                    Console.WriteLine(".");
                                    Thread.Sleep(700);
                                    Console.WriteLine(".");
                                    Console.ReadLine();
                                    break;
                                case 2:
                                    Console.WriteLine("You panic and freeze. Your mind wants to grab the nearest pan but cant");
                                    Thread.Sleep(1600);
                                    Console.WriteLine("Something big enters the kitchen and growls at you.");
                                    Thread.Sleep(1000);
                                    Console.WriteLine("You cant seem to put a finger on what it is but it doesnt matter");
                                    Thread.Sleep(1100);
                                    Console.WriteLine("It lunches at you and everything becomes dark");
                                    Thread.Sleep(700);
                                    Console.WriteLine(".");
                                    Thread.Sleep(700);
                                    Console.WriteLine(".");
                                    Thread.Sleep(700);
                                    Console.WriteLine(".");
                                    Console.ReadLine();
                                    break;
                                case 3:
                                    Console.WriteLine("You panic and freeze. Your mind wants to grab the nearest pan but cant");
                                    Thread.Sleep(1600);
                                    Console.WriteLine("A big shadow apears on the wall due to the kitchen light");
                                    Thread.Sleep(1200);
                                    Console.WriteLine("The shadow becomes bigger and bigger and as it turns the corner");
                                    Thread.Sleep(400);
                                    Console.WriteLine(".");
                                    Thread.Sleep(400);
                                    Console.WriteLine(".");
                                    Thread.Sleep(400);
                                    Console.WriteLine(".");
                                    Thread.Sleep(1000);
                                    Console.WriteLine("\nA small hamster looking creature on its back legs apears");
                                    Thread.Sleep(1200);
                                    Console.WriteLine("It looks like it has rabies. You run towards it and kick it");
                                    Thread.Sleep(1200);
                                    Console.WriteLine("You grab the pan and smacks it till it die\n");
                                    Thread.Sleep(1200);
                                    Console.WriteLine("You find a bed after its dead and the next morning you head to your village and find your home");
                                    Thread.Sleep(1200);
                                    Console.WriteLine("The same day you quit your job as an adventure. You have had too much\n");
                                    Thread.Sleep(1200);
                                    Console.WriteLine("Thanks for listening to my adventure brave one :D");
                                    Console.WriteLine();
                                    break;
                            }


                        }

                        //Flee
                        if (answer == "flee")
                        {
                            Console.WriteLine("You leap towards the window and hear someone screm wait behind you");
                            Thread.Sleep(1400);
                            Console.WriteLine("You run throgh the night at suddenly your back at your own village and sleep in fear");
                            Thread.Sleep(1650);
                            Console.WriteLine("The next day you quit your job as adventure and retire");
                            Console.ReadLine();

                        }
                        break;
                    }


                    //Go to the noice


                    //Far door


                    Console.ReadLine();
            }



        }

        //Run past the house
        else if (answer == "no")
        {
            Console.WriteLine("\nYou run past the spooky looking house, and until you enter a large grassfield.\nIt seems like you have escaped the cursed forrest.");
            Thread.Sleep(500);
            Console.WriteLine("Some hours pass by and you find you'r village and house.\nYou can finally rest");
            Console.ReadLine();
        }
    }

    //Start the storyline of turning left
    else if (answer == "left")
    {
        Console.WriteLine("You run left and after some time you see a small village");
        Thread.Sleep(1200);
        Console.WriteLine("You suddenly reach a market place and an old man stares straight at you");
        Thread.Sleep(1200);
        Console.WriteLine("The man calls you over and forces you to try a new gamen\n");
        Thread.Sleep(1200);
        Console.WriteLine("I have created two new games. Rock papir scissors, and a betting game");
        Thread.Sleep(1200);
        Console.WriteLine("Which one do you want to play?");
        Thread.Sleep(1200);
        Console.WriteLine("RPS\nBG");
        Thread.Sleep(1200);

        answer = Console.ReadLine().ToUpper();
        if (answer == "BG") //Betting Game//
        {
            Console.WriteLine("How much are you willing to bet?");

            int bet = Convert.ToInt32(Console.ReadLine());
            PlayGameBG(bet);
        }

        else if (answer == "RPS") //Sten Saks Papir Challenge

        {
            PlayGameRPS();
        }
    }


    //Start the storyline of going straight
    else if (answer == "straight")
    {

        Console.WriteLine("You walk straight and hear the sound from behind closing in");
        Thread.Sleep(1200);
        Console.WriteLine("You come across a highway with multiple cars passing by");
        Thread.Sleep(1200);

        List<string> cars = new List<string>();
        cars.Add("yellow");
        cars.Add("red");
        cars.Add("green");
        cars.Add("blue");
        cars.Add("purple");


        Console.WriteLine("Multiple cars in mulitple colors like");
        foreach (string car in cars)
        {
            Console.WriteLine(car);
            Thread.Sleep(600);
        }
        Thread.Sleep(1200);
        Console.WriteLine("Pass by. Its now or never");
        Thread.Sleep(1200);
        Console.WriteLine("You make a run for it");
        Thread.Sleep(1200);
        Console.WriteLine(".");
        Thread.Sleep(1200);
        Console.WriteLine(".");
        Thread.Sleep(1200);
        Console.WriteLine(".");
        Thread.Sleep(1200);
        Console.WriteLine("You made it?");
        Thread.Sleep(1200);
        Console.WriteLine("How?");
        Thread.Sleep(1200);
        Console.WriteLine("I mean great!");
        Thread.Sleep(1200);
        Console.WriteLine("But how?");
        Thread.Sleep(1200);
        Console.WriteLine("Well let me continue then\n");
        Thread.Sleep(2400);
        Console.WriteLine("You turn around and see multiple cars crashed");
        Thread.Sleep(1200);
        Console.WriteLine("The colors you see are " + cars[3] + " and " + cars[0]);

        cars.Remove("blue");
        cars.Remove("yellow");

        Thread.Sleep(1200);
        Console.WriteLine("A big puddle of blood lays on the road");
        Thread.Sleep(1200);
        Console.WriteLine("You notice that people are running out of their cars");
        Thread.Sleep(1200);
        Console.WriteLine("You get an idea to steal one. Which one do you pick?\n");

        foreach (string car in cars)
        {
            Console.WriteLine(car);
            Thread.Sleep(600);
        }

        string pCar;
        pCar = Console.ReadLine();

        while (!cars.Contains(pCar))
        {
            Console.WriteLine("Thats not one of the cars. Try again\n");
            pCar = Console.ReadLine();
            break;
        }

        Console.WriteLine("\n" + pCar + " nice pick");
        Thread.Sleep(1200);
        Console.WriteLine("You get in the " + pCar + " car and drive off into the sunset");
        Console.ReadLine();
        Console.WriteLine("Thanks for your time " + AName);
        Console.ReadLine();
    }

    else if (answer == "no")
    {
        Console.WriteLine("Im sorry to hear that");
        Console.ReadLine(); //Stops program from exiting until we press a key
    }
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