using System;
using Unit03.Game;

namespace ParachuteProject
{
    internal class Program
    {
        static int Main(string[] args)
        {
            Director theDirector = new Director();
            theDirector.StartGame();
            return 0;
        }
    }
}