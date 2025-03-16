using System;

Random rnd = new Random();
// randomize the digits of the number that is trying to be guessed
int digit1 = rnd.Next(1, 7);
int digit2 = rnd.Next(1, 7);
int digit3 = rnd.Next(1, 7);
int digit4 = rnd.Next(1, 7);

// turn the digits into a number
string num = Convert.ToString(digit1) + Convert.ToString(digit2) + Convert.ToString(digit3) + Convert.ToString(digit4);

// variable to count the number of guesses
int numGuesses = 0;

// let the user guess until they reach 10 guesses
while (numGuesses < 10)
{
    // increase the guess counter
    numGuesses++;

    // get the user's guess
    Console.WriteLine("Enter a 4 digit number with each digit ranging from 1-6: ");
    string userGuess = Console.ReadLine();

    // ensures that user entered a number with length 4
    if (userGuess.Length != 4)
    {
        Console.WriteLine("Please enter a 4 digit number: ");
        userGuess = Console.ReadLine();
    }

    // variable to store the amount of + signs
    int plusCount = 0;

    // variable to store the amount of - signs
    int minusCount = 0;

    // compare the digits of the user guess and number & print appropriate symbol
    for (int i = 0; i < userGuess.Length; i++)
    {
        if (userGuess[i] == num[i])
        {
            plusCount++;
        }
        else if (userGuess[i] == num[0] && i != 0)
        {
            minusCount++;
        }
        else if (userGuess[i] == num[1] && i != 1)
        {
            minusCount++;
        }
        else if (userGuess[i] == num[2] && i != 2)
        {
            minusCount++;
        }
        else if (userGuess[i] == num[3] && i != 3)
        {
            minusCount++;
        } // end if statement
    } // end for loop

    if (plusCount == 4)
    { // if the plus count is 4, then you guessed the number
        Console.WriteLine("YOU WIN");
        break;
    }
    else
    { // else print the number of + and - signs
        for (int j = 0; j < plusCount; j++)
        {
            Console.Write("+");
        } // end for loop

        for (int k = 0; k < minusCount; k++)
        {
            Console.Write("-");
        } // end for loop
        Console.WriteLine();
    } // end if else statement

} // end of while Loop
if (numGuesses == 10)
{
    Console.WriteLine("GAME OVER - You Ran Out Of Guesses");
}