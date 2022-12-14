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
            "   X   \n  /|\\  \n  / \\  \n^^^^^^^\n",
            "   o   \n  \\|/ \n  / \\  \n^^^^^^^\n"
        };
        
        // Creates the image of the letter spaces and the parachute while game is going
        public void DrawOutput(int Phase)
        {
            Console.WriteLine();
            Console.WriteLine(_parachuteMan[Phase]);
        }

        // Creates the image right before the game ends
        public void DeadEndMessage()
        {
            Console.WriteLine("--Game Over--");
            Console.WriteLine("Correct Word was:");
            Console.WriteLine(_parachuteMan[5]);
        }

        public void AliveEndMessage()
        {
            
            Console.WriteLine("--You Win!--");
            Console.WriteLine("Correct Word was:");
            Console.WriteLine(_parachuteMan[6]);
        }


    }
}