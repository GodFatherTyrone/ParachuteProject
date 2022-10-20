using System;
using System.Collections.Generic;


namespace Unit03.Game 
{
    public class Word{
        //Attributes:
        private List<string> _word = new List<string> ();

        public List<List<string>> compileWord() {
            // creates the list of random words
            // I just didn't like it in newWord()
            List<List<string>> randomWords = new List<List<string>> ();

            string[] new1 = {"B", "A", "N", "D"};
            List<string> word1 = new List<string>(new1);
            randomWords.Add(word1);

            string[] new2 = {"N", "A", "M", "E"};
            List<string> word2 = new List<string>(new2);
            randomWords.Add(word2);

            string[] new3 = {"F", "I", "R", "E"};
            List<string> word3 = new List<string>(new3);
            randomWords.Add(word3);

            string[] new4 = {"C", "O", "V", "E"};
            List<string> word4 = new List<string>(new4);
            randomWords.Add(word4);

            return randomWords;
        }
        public void newWord() {
            // creates the word for the director to set, will have to access it through getWord()
            List<List<string>> wordList = compileWord();
            Random randomGenerator = new Random();
            int index = randomGenerator.Next(0, wordList.Count);
            List<string> finalWord = wordList[index];

            this._word = finalWord;
        }

        public List<string> getWord() {
            // returns the word for the director to access
            return _word;
        }
    }
}