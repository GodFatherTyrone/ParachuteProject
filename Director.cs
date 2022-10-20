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
            Word Main_Word= new Word();
            ImageOutput Jumper= new _parachuteMan();
            ImageOutput _GameOver = new Fell();
            string guess = "";

        }

        /// <summary>
        /// Starts the game by running the main game loop.
        /// </summary>
        public void StartGame()
        {
            while (_isPlaying)
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
            Console.WriteLine($"There is a 5 letter word, Please guess a letter [a-z]: ");
            guess= Console.Readline();


        }

        /// <summary>
        /// Desides whether the guess is write or wrong.
        /// Make sure the task has been updated to work with the Guesses class
        /// </summary>
        private void DoUpdates()
        {
           
            Guesses."Task"(guess);
            ImageOutput Jumper= _parachuteMan();
            /// Is man dead
            ImageOutput _GameOver = Fell();


        }

        /// <summary>
        /// Outputs the result of the guess
        /// Prints updated image of jumper
        /// Ends/Contunies the game.
        /// </summary>
        private void DoOutputs()
        {
            Console.WriteLine($"{_parachuteMan}");
            
            if (GameOver == True)
            {
                _isPlaying = false;
            }
            
        }
    }
}