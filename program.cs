﻿using System;
using Unit03.Game;

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