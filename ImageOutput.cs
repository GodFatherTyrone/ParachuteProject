using System;
// create parachute image and letter spaces

namespace Unit03.Game
{
    // Responsibility of ImageOutput is to show current parachute and guessed word.
    public class ImageOutput
    {
        // an array holding the different phases of the parachute man
        private string[] _parachuteMan = {
            "  ___  \n /___\\ \n \\   / \n  \\ /  \n   O   \n  /|\\  \n  / \\  \n^^^^^^^\n", 
            " /___\\ \n \\   / \n  \\ /  \n   O   \n  /|\\  \n  / \\  \n^^^^^^^\n",
            "  ___  \n \\   / \n  \\ /  \n   O   \n  /|\\  \n  / \\  \n^^^^^^^\n",
            " \\   / \n  \\ /  \n   O   \n  /|\\  \n  / \\  \n^^^^^^^\n",
            "  \\ /  \n   O   \n  /|\\  \n  / \\  \n^^^^^^^\n",
            "   X   \n  /|\\  \n  / \\  \n^^^^^^^\n"

        };
        
        // Creates the image of the letter spaces and the parachute
        public void DrawOutput()
        {
            // a placeholder, will use a variable instead
            Console.WriteLine(_parachuteMan[1]);
            
        }


    }
}