
using System;

namespace Unit03.Game
{
    /// <summary>
    /// <para>A person who directs the game.</para>
    /// <para>
    /// The responsibility of a Director is to control the sequence of play.
    /// </para>
    /// </summary>
    public class Director
    {
      

        /// <summary>
        /// Constructs a new instance of Director.
        /// </summary>
        public Director()
        {
            private bool _isPlaying= true;
            Word Main_Word= new Word();
            private string guess= "";

        }

        /// <summary>
        /// Starts the game by running the main game loop.
        /// </summary>
        public void StartGame()
        {
            while (_isPlaying = true)
            {
                GetInputs();
                DoUpdates();
                DoOutputs();
            }
        }

        /// <summary>
        /// Grabs a letter from the user
        /// </summary>
        private void GetInputs()
        {
            Console.WriteLine($"There is a 4 letter word, Please guess a letter [a-z]: ");
            string guess = Console.Readline();


        }

        /// <summary>
        /// Desides whether the guess is write or wrong.
        /// Make sure the task has been updated to work with the Guesses class
        /// </summary>
        public void DoUpdates()
        {
            ///push
            Guesses."Task"(guess);
            
            ///pull
            Guesses."Variable" = Wrong_Guess_Count();
            
    
        }

        /// <summary>
        /// Outputs the result of the guess
        /// Prints updated image of jumper
        /// Ends/Contunies the game.
        /// </summary>
        private void DoOutputs()
        {   
            ///too many wrong guesses, End game
            if (Wrong_Guess_Count > 4)
            {
                _isPlaying = false;
                ImageOutput.EndMessage();
            }
            ///Correct guess, continue
            else if(Wrong_Guess_Count <= 4)
            {
                ImageOutput.DrawOutput(Wrong_Guess_Count);
            }
            else{
                return;
            }
        }
    }
}