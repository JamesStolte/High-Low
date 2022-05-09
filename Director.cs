using System;
namespace HighLow
{
    class Director
    {
        //Constructor
        public void StartGame()
        {
            bool keepPlaying = true;
            while(keepPlaying == true)
            {
                string playingInput = GetPlayingInput();
                if (playingInput == "y")
                {
                    cardGen();
                    string userInput = HiLowInput();
                    DoOutputs(); 
                }
                else if(playingInput == "n")
                {
                    bool keepPlaying = false();
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
        }
    }
}