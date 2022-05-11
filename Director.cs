using System;
namespace HighLow
{
    class Director
    {
        private Deck deck = new Deck();
        //Constructor
        public void StartGame()
        {
            // bool keepPlaying = true;
            
            // while(keepPlaying == true)
            // {
            //     string playingInput = GetPlayingInput();
            //     if (playingInput == "y")
            //     {
                    
            //         deck.CardGen();
            //         string userInput = HiLowInput();
            //         deck.DisplayScore(); 
            //     }
            //     else if(playingInput == "n")
            //     {
            //         keepPlaying = false;
            //     }
            //     else
            //     {
            //         Console.WriteLine("Error.  Invalid input.");
            //     }
            // }
            bool keepPlaying = false;

            do{
                string playingInput = getPlayingInput();
                if (playingInput == "y"){

                    keepPlaying = true;
                    deck.CardGen();
                    string userInput = HiLowInput();

                } else if (playingInput == "n")
                    {
                        keepPlaying = false;
                    }
                else 
                    {
                        Console.WriteLine("Error. Invalid Input. Try again ");
                        keepPlaying = true;
                    }

                
            }while(keepPlaying = true);
        }

        public string getPlayingInput() 
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