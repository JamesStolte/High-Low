using System;
namespace HighLow
{
    class Director
    {
        private Deck deck = new Deck();
        //Constructor
        public void StartGame()
        {
            //initalizing variables early to prevent variable name overwrite issues
            int score = 300;
            int oldCard = 0;
            string userInput = "<3";

            bool keepPlaying = true;
            
            while(keepPlaying == true)
            {
                string playingInput = GetPlayingInput();
                if (playingInput == "y")
                {
                    //Generates the first card, print the card. Saves to oldCard
                    oldCard = deck.CardGen();

                    //Asks the user What they would like to guess. Saves guess to userInput
                    userInput = HiLowInput();

                    //Generates the second card, checks if it is higher or lower than oldCard
                    deck.GuessCardGen(oldCard);

                    deck.DisplayScore(score); 
                }
                else if(playingInput == "n")
                {
                    keepPlaying = false;
                }
                else
                {
                    Console.WriteLine("Error.  Invalid input.");
                }
            }
        }

        public string GetPlayingInput() 
        {
            Console.WriteLine("Are you still playing? (y/n)");
            string stillPlaying = Console.ReadLine();  
            return stillPlaying;
        }
        
        public string HiLowInput() 
        {
            bool keepLoop = true;
            while (keepLoop == true)
            {
                Console.WriteLine("Is the next card HIGHER or LOWER? (hi/lo)");
                string userInput = Console.ReadLine();
                if (userInput == "hi" || userInput == "lo")
                {
                    return userInput;
                }
                else
                {
                    Console.WriteLine("Error.  Invalid input.");
                    return "error";
                }
            }
            return "This should never be returned. This is just to help dotnet build succeed.";
        }

        public int ScoreAddition(int startNum, int randNum, string userGuess) 
        {

            int scoreChange = 0;
            
            if (userGuess == "hi") 
            {
                if (startNum < randNum) 
                {
                    scoreChange = 100;
                }
                else 
                {
                    scoreChange = -75;
                }
            }
            else 
            {
                if (startNum > randNum) 
                {
                    scoreChange = 100;
                }
                else 
                {
                    scoreChange = -75;
                }
            }

            return scoreChange;
        }
    }
}