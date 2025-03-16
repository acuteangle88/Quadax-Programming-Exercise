using System;

class MasterMind {
    static void Main(string[] args) {
        
        Random rnd = new Random();
        // randomize the digits of the number that is trying to be guessed
        int digit1 = rnd.Next(1, 7);
        int digit2 = rnd.Next(1,7);
        int digit3 = rnd.Next(1,7);
        int digit4 = rnd.Next(1,7);

        // variable to count the number of guesses
        int numGuesses = 1;

        // let the user guess until they reach 10 guesses
        while (numGuesses <= 10) {
            // get the user's guess
            Console.WriteLine("Enter a 4 digit number with each digit ranging from 1-6: ");
            string userGuess = Console.ReadLine();

            // variable to store the amount of + signs
            int plusCount = 0;

            // variable to store the amount of - signs
            int minusCount = 0;
        
            // compare the digits of the user guess and number & print appropriate symbol
            for (int i = 0; i < userGuess.Length; i++) {
                switch (userGuess[i]) {
                    case (userGuess[i] == num[i]):
                        plusCount++;
                        break;
                    case (userGuess[i] == Convert.ToString(digit1) || userGuess[i] == Convert.ToString(digit2) 
                            || userGuess[i] == Convert.ToString(digit3) || userGuess[i] == Convert.ToString(digit4)):
                        minusCount++;
                        break;
                    default:
                        break;
                } // end of switch
            } // end for loop
            
            if (plusCount == 4) { // if the plus count is 4, then you guessed the number
                Console.WriteLine("\n YOU WIN");
                break;
            } else { // else print the number of + and - signs
                for (int j = 0; j < plusCount; j++) {
                Console.Write("+");
                } // end for loop
                
                for (int k = 0; k < minusCount; k++){
                Console.Write("-");
                } // end for loop
            } // end if else statement
            
            i++;
        } // end of while Loop
        
        // check the number of Guesses
        if (numGuesses == 10) { // if you hit 10 guesses you lost
            Console.WriteLine("\n GAME OVER - You Ran Out Of Guesses");
        }
    } // end of main method
} // end of Mastermind class
