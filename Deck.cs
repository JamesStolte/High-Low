using System;
namespace HighLow {

    class Deck 
    {
        //Creates and prints a random number
        private readonly Random _random = new Random();
        public int CardGen() 
        {
            int newCard =  _random.Next(1,14);
            Console.WriteLine($"The Card: {newCard}");
            return newCard;
        }

        //Creates the card to guess, makes sure the guessing card != the first card
        public int GuessCardGen(int oldNum) 
        {
            int guessCard = 0;

            do
            {
            guessCard = _random.Next(1,14);
            } while (guessCard == oldNum);
            
            return guessCard;
        }


        // Displays the Players Score after Guessing 
        public void DisplayScore(int score)
        {
            Console.WriteLine($"Your Score is {score}");
        }
    }
}