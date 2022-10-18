using System;

namespace ParachuteProject
{
    internal class Program
    {
        static int Main(string[] args)
        {
            Director director = new Director();
            director.StartGame();
            return 0;
        }
    }
}