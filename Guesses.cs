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
        public void MakeNewGuesslist()
        {
            String[] list = {"_","_","_","_"};
            List<string> New_Guesslist = new List<string>(list);
        }
    
        public void CheckGuesses()
        {
            Director.guess= Guess();
            Director.Main_Word = Main_Word();
            String[] Old_Guesslist = New_Guesslist;
            
            for (int i = 0; i < 4; i+ )
            {
                ///if correct changes the correct letter in the correct position
                ///if incorrect do nothing
                if (Main_Word{i} == Guess)
                {
                    New_Guesslist = Guess[i];
                }
                else
                {
                    return;
                }
            }
            ///if incorect add to wrong guess count
            ///if correct do nothing
            if (Old_Guesslist != New_Guesslist);
            {
                ///Add +1 to wrongguesscount
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