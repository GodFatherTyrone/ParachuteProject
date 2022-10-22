///Director pushes New_User_Guess to Guesses

///Figures out if it is correct or not
///Adds to the Wrong guess count for every error

///Make sure the guess wrong count is public

///saves the correct letter in the correct position in a new list

///ImageOutput pulls number of failed guesses and the list

using System;
using System.Collections.Generic;

namespace Unit03.Game
{
    public class Guesses
    {
        public int Wrong_Guess_Count  = 0;

            public List<Guesses> myListOfGuesses = new List<Guesses>();
            public List<Guesses> myListOfFailedGuesses = new List<Guesses>();

    
        public void CheckGuesses(string Guess)
        {
            for (int i = 0; i < 4; i+ ) 
            {
                // This changes the correct letter in the correct position
                if (Director.Main_Word{i} == Guess)
                {

                }
                //changes the wrong guess count
                else if(Director.Main_Word{i} != Guess)
                {

                }
            }

        }

        static void Main(string[] args)
        {
            Guesses tasks = new Guesses();
            Guesses variables = new Guesses();
            Guesses correct_wordlist = new Guesses();
            Guesses correct_variables = new Guesses();
        }

        public class Wrong_Guess
        {
            public string error{ get; set; }
            public string New_User_Guess{ get; set; }
        }
       
    }

}