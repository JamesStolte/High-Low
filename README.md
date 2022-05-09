# High-Low
A higher or lower game

1. The player starts the game with 300 points.
2. Individual cards are represented as a number from 1 to 13.
3. The current card is displayed.
4. The player guesses if the next one will be higher or lower.
5. The next card is displayed.
6. The player earns 100 points if they guessed correctly.
7. The player loses 75 points if they guessed incorrectly.
8. If a player reaches 0 points the game is over.
9. If a player has more than 0 points they decide if they want to keep playing.
10. If a player decides not to play again the game is over.

The card: 9
Higher or lower? [h/l] l
Next card was: 5
Your score is: 400
Play again? [y/n] y

Questions for GITHUB:
1. How can I push changes to main on GITHUB instead of creating forks
2. How can i make it so I dont have to ask to commit changes to main
3. How can I ask to get a specific pull? 

Classes:
Director
Deck

Objects:
D: KeepPlaying = Bool

States:
D: STartGame
// Starts the game 

GetPlayingInput
// Gets players input whether they're still playing or not

HiLowInput
// Guess whether the card is High or Low

ScoreAddition
//Adds Score from High Low

CheckIfLose
// Checks whether player lost or not
D----------------

DK CardGen
// Creates the card and tells the user what the card is, returns card as an integer 

GuessCardGen
// Takes the input of the old number and uses it to make sure the new card is different than the old card
DK-----------
