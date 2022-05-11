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
            int newCard = 0;
            int scoreChange = 0;
            string userInput = "<3";

            bool keepPlaying = true;
            Console.WriteLine($"Beginning Score: {score}");
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
                    newCard = deck.GuessCardGen(oldCard);

                    //Uses userInput, oldCard, and userInput to calculate the score change needed
                    scoreChange = ScoreAddition(oldCard, newCard, userInput);

                    //Calculates the new score
                    
                    score = ChangeScore(score, scoreChange);
                    

                    //Displays the score
                    deck.DisplayScore(score); 

                    //Check if player loses
                    CheckIfLose(score, keepPlaying);
                }
                else if(playingInput == "n" || score <= 0)
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
            Console.WriteLine($"The new card was: {randNum}");

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
            else if(userGuess == "lo")
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
            else
            {
                Console.WriteLine("Invalid input.  Please try again.");
                scoreChange = 0;
            }
            return scoreChange;
        }
        public bool CheckIfLose(int score, bool keepPlaying)
        {
            if(score <= 0)
            {
                Console.WriteLine("You Lose!");
                keepPlaying = false;
                return keepPlaying;
            }
            else
            {
                keepPlaying = true;
                return keepPlaying;
            }
        }
        public int ChangeScore(int score, int ScoreChange)
        {   
            int newScore;
            newScore = score + ScoreChange;
            return newScore;
        }
    }
}